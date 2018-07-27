using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telegram.Bots.Toolkit.Model;
using Telegram.Bots.Toolkit.Services;

namespace Telegram.Bots.Toolkit.Views
{
    public partial class FrmAwal : Form
    {
        public FrmAwal()
        {
            InitializeComponent();
        }

        #region Fungsi2

        private void LoadBot()
        {
            if (!string.IsNullOrEmpty(CmbBots.Text))
            {
                TbxToken.Text = SBots.GetBots(CmbBots.Text.Trim())[0].Token;
                TbxUri.Text = SBots.GetBots(CmbBots.Text.Trim())[0].Uri;
                TbxUriDefault.Text = SBots.GetBots(CmbBots.Text.Trim())[0].UriDefault;
            }
        }

        private void LoadBots()
        {
            //CmbBots.Items.Clear();
            CmbBots.DataSource = SBots.GetSemuaBot();
        }

        #endregion Fungsi2

        #region Workers

        private void BgCleaner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Pending pending = new Pending()
            {
                Token = TbxToken.Text.Trim(),
                Uri = TbxUri.Text.Trim(),
                UriDefault = TbxUriDefault.Text.Trim()
            };

            if (!string.IsNullOrEmpty(pending.Token) &&
                !string.IsNullOrEmpty(pending.Uri))
            {
                int count = pending.GetWebhookInfo().PendingUpdateCount;
                tsProgBar.GetCurrentParent().Invoke(new MethodInvoker(delegate
                {
                    tsProgBar.Maximum = count;
                }));
                for (int x = 0; x <= count; count--)
                {
                    pending.HapusWebhook();
                    pending.GetUpdates();
                    pending.SetWebhook();
                    count = pending.GetWebhookInfo().PendingUpdateCount;
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

                if (!string.IsNullOrEmpty(pending.UriDefault) &&
                    tetapkanURIHookSetelahBersihkanToolStripMenuItem.Checked)
                {
                    pending.SetWebhookDefault();
                }
                BwChecker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Token & URI Clear Hook dibutuhkan!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BgCleaner_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
        }

        private void BgCleaner_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tsLStatus.Text = "Siaga..";
            BtnBersihkan.Text = "Mulai Bersihkan";
            MessageBox.Show("Pragat!", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BwChecker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Pending pending = new Pending()
            {
                Token = TbxToken.Text.Trim(),
                Uri = TbxUri.Text.Trim(),
                UriDefault = TbxUriDefault.Text.Trim()
            };

            if (!string.IsNullOrEmpty(pending.Token))
            {
                var data = pending.GetWebhookInfo();
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
                        LblResult.Text += "\nLebih dari 20";
                        LblResult.Text += "\nLebih dari 5";
                    }));
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

        #endregion Automation

        #region Tindakan

        private void BtnCek_Click(object sender, EventArgs e)
        {
            Pending pending = new Pending()
            {
                Token = TbxToken.Text.Trim(),
                Uri = TbxUri.Text.Trim(),
                UriDefault = TbxUriDefault.Text.Trim()
            };

            try
            {
                pending.SetWebhookDefault();
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
                    Uri = TbxUri.Text.Trim(),
                    UriDefault = TbxUriDefault.Text.Trim()
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

        private void segarkanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBot();
        }

        #endregion Tindakan
    }
}