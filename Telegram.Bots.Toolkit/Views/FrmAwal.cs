using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telegram.Bots.Toolkit.Model;
using Telegram.Bots.Toolkit.Services;

namespace Telegram.Bots.Toolkit.Views
{
    public partial class FrmAwal : Form
    {
        private SWebhookInfo sWebhook = new SWebhookInfo();

        public FrmAwal()
        {
            InitializeComponent();

            LoadBots();
            LoadSettings();
            MainNotif.Visible = true;
        }

        #region Fungsi2

        private void LoadBot()
        {
            if (!string.IsNullOrEmpty(CmbBots.Text))
            {
                TbxToken.Text = SBots.GetBots(CmbBots.Text.Trim())[0].Token;
                TbxUri.Text = SBots.GetBots(CmbBots.Text.Trim())[0].UriClean;
                TbxUriDefault.Text = SBots.GetBots(CmbBots.Text.Trim())[0].UriCurrent;
                Pengaturan.Tulis("BotTerpilih", CmbBots.Text);
            }
        }

        private void LoadBots()
        {
            int sel = CmbBots.SelectedIndex;
            CmbBots.DataSource = SBots.GetSemuaBot();
            CmbBots.SelectedIndex = sel;
        }

        private void LoadSettings()
        {
            int h = Convert.ToInt32(Pengaturan.Baca("WinHeight"));
            int w = Convert.ToInt32(Pengaturan.Baca("WinWidth"));

            periksaStatusOtomatisToolStripMenuItem.Checked = Convert.ToBoolean(Pengaturan.Baca("AutoCekWebhook"));
            bersihkanPendingCountOtomatisToolStripMenuItem.Checked = Convert.ToBoolean(Pengaturan.Baca("AutoCleanPendingUpdate"));
            SetURIHookSetBersihkanToolStripMenuItem.Checked = Convert.ToBoolean(Pengaturan.Baca("SetURIHookSetBersih"));
            tutupKeTrayToolStripMenuItem.Checked = Convert.ToBoolean(Pengaturan.Baca("TutupKeTray"));
            CmbBots.Text = Pengaturan.Baca("BotTerpilih").ToString();
            Location = new Point(Convert.ToInt16(Pengaturan.Baca("WinLocX")), Convert.ToInt16(Pengaturan.Baca("WinLocY")));
            Size = new Size(w, h);
        }

        private void PushNotif(string notif)
        {
            MainNotif.BalloonTipText = notif;
            MainNotif.BalloonTipIcon = ToolTipIcon.Info;
            MainNotif.ShowBalloonTip(3000);
        }

        #endregion Fungsi2

        #region Workers

        private void BgCleaner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            sWebhook.Token = TbxToken.Text.Trim();
            sWebhook.UriClean = TbxUri.Text.Trim();
            sWebhook.UriCurrent = TbxUriDefault.Text.Trim();

            if (!string.IsNullOrEmpty(sWebhook.Token) &&
                !string.IsNullOrEmpty(sWebhook.UriClean))
            {
                int count = sWebhook.GetWebhookInfo().PendingUpdateCount;
                tsProgBar.GetCurrentParent().Invoke(new MethodInvoker(delegate
                {
                    tsProgBar.Maximum = count;
                }));
                for (int x = 0; x <= count; count--)
                {
                    sWebhook.HapusWebhook();
                    sWebhook.GetUpdates();
                    sWebhook.SetWebhook();
                    count = sWebhook.GetWebhookInfo().PendingUpdateCount;
                    e.Result = count;
                    tsProgBar.GetCurrentParent().Invoke(new MethodInvoker(delegate
                    {
                        tsProgBar.Value = tsProgBar.Maximum - count;
                    }));

                    LblResult.Invoke(new MethodInvoker(delegate
                    {
                        LblResult.Text = "Sisa pending : " + count;
                    }));
                }

                if (!string.IsNullOrEmpty(sWebhook.UriCurrent) &&
                    SetURIHookSetBersihkanToolStripMenuItem.Checked)
                {
                    sWebhook.SetWebhookDefault();
                }

                if (!BwChecker.IsBusy)
                {
                    BwChecker.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Token & URI Clear Hook dibutuhkan!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BgCleaner_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tsLStatus.Text = "Siaga..";
            BtnBersihkan.Text = "Mulai Bersihkan";
            tsProgBar.Value = 0;

            if (ContainsFocus)
            {
                MessageBox.Show("Pragat!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PushNotif("Pragat!");
            }
        }

        private void BwChecker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            sWebhook.Token = TbxToken.Text.Trim();
            sWebhook.UriClean = TbxUri.Text.Trim();
            sWebhook.UriCurrent = TbxUriDefault.Text.Trim();

            if (!string.IsNullOrEmpty(sWebhook.Token))
            {
                var data = sWebhook.GetWebhookInfo();
                LblResult.Invoke(new MethodInvoker(delegate
                {
                    LblResult.Text = "URI Webhook         : " + data.Url +
                                     "\nPending Update     : " + data.PendingUpdateCount +
                                     "\nMax Connection     : " + data.MaxConnections +
                                     "\nLast Error Date       : " + data.LastErrorDate +
                                     "\nLast Error Message : " + data.LastErrorMessage;
                }));

                if (data.PendingUpdateCount > 5)
                {
                    LblResult.Invoke(new MethodInvoker(delegate
                    {
                        LblResult.Text += "\nLebih dari " + data.PendingUpdateCount;
                    }));

                    if (bersihkanPendingCountOtomatisToolStripMenuItem.Checked)
                    {
                        BgCleaner.RunWorkerAsync();
                    }
                    //PushNotif("Pending Update Count : " + data.PendingUpdateCount);
                }
            }
            else
            {
                MessageBox.Show("Token dibutuhkan!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Workers

        #region Automation

        private void TimerChecker_Tick(object sender, EventArgs e)
        {
            if (periksaStatusOtomatisToolStripMenuItem.Checked &&
                !string.IsNullOrEmpty(TbxToken.Text.Trim()))
            {
                if (!BwChecker.IsBusy)
                {
                    BwChecker.RunWorkerAsync();
                }
            }
        }

        private void CmbBots_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBot();
        }

        private void CmbBots_DropDown(object sender, EventArgs e)
        {
            LoadBots();
        }

        private void FrmAwal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!tutupKeTrayToolStripMenuItem.Checked)
            {
                var dlgRes = MessageBox.Show("Apakah kamu yakin mau menutup?", Application.ProductName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dlgRes != DialogResult.Yes)
                { e.Cancel = true; }
            }
            else
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void FrmAwal_LocationChanged(object sender, EventArgs e)
        {
            Pengaturan.Tulis("WinLocX", Location.X.ToString());
            Pengaturan.Tulis("WinLocY", Location.Y.ToString());
            Pengaturan.Tulis("WinHeight", Height.ToString());
            Pengaturan.Tulis("WinWidth", Width.ToString());
        }

        #endregion Automation

        #region Tindakan

        private void BtnCek_Click(object sender, EventArgs e)
        {
            sWebhook.Token = TbxToken.Text.Trim();
            sWebhook.UriClean = TbxUri.Text.Trim();
            sWebhook.UriCurrent = TbxUriDefault.Text.Trim();

            try
            {
                sWebhook.SetWebhookDefault();
                tsLStatus.Text = "Webhook berhasil di set";
                BwChecker.RunWorkerAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Silakan tunggu hingga proses check selesai", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBersihkan_Click(object sender, EventArgs e)
        {
            if (BgCleaner.IsBusy)
            {
                BgCleaner.CancelAsync();
                tsLStatus.Text = "Siaga..";
                BtnBersihkan.Text = "Mulai Bersihkan";
            }
            else
            {
                BgCleaner.RunWorkerAsync();
                tsLStatus.Text = "Memulai membersihkan..";
                BtnBersihkan.Text = "Stop Bersihkan";
            }
        }

        private void BtnSimpanBot_Click(object sender, EventArgs e)
        {
            var data = new List<TelegramBot>
            {
                new TelegramBot
                {
                    Token = TbxToken.Text.Trim(),
                    UriClean = TbxUri.Text.Trim(),
                    UriCurrent = TbxUriDefault.Text.Trim()
                }
            };

            SBots.TambahBot(CmbBots.Text.Trim(), data);
            LoadBots();
            tsLStatus.Text = "Berhasil menambahkan Bot..";
        }

        private void BtnHapusBot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CmbBots.Text))
            {
                SBots.HapusBot(CmbBots.Text);
                tsLStatus.Text = "Berhasil hapus Bot..";
                LoadBots();
            }
            else
            {
                tsLStatus.Text = "Pilih Bot yg mau di Hapus..";
            }
        }

        private void MainNotif_Click(object sender, EventArgs e)
        {
            if (Visible) { Hide(); } else { Show(); }
        }

        #endregion Tindakan

        #region Menus

        private void bersihkanPendingCountOtomatisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengaturan.Tulis("AutoCleanPendingUpdate", bersihkanPendingCountOtomatisToolStripMenuItem.Checked.ToString());
        }

        private void segarkanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBot();
        }

        private void periksaStatusOtomatisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengaturan.Tulis("AutoCekWebhook", periksaStatusOtomatisToolStripMenuItem.Checked.ToString());
        }

        private void SetURIHookSetBersihkanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengaturan.Tulis("SetURIHookSetBersih", SetURIHookSetBersihkanToolStripMenuItem.Checked.ToString());
        }

        private void tutupKeTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengaturan.Tulis("TutupKeTray", tutupKeTrayToolStripMenuItem.Checked.ToString());
        }

        #endregion Menus
    }
}