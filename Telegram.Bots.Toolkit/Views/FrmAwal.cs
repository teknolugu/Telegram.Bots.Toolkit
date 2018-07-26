using System;
using System.Windows.Forms;
using Telegram.Bots.Toolkit.Helpers;

namespace Telegram.Bots.Toolkit.Views
{
    public partial class FrmAwal : Form
    {
        public FrmAwal()
        {
            InitializeComponent();
        }

        /*
        private void CekHook()
        {
            Pending pending = new Pending()
            {
                Token = TbxToken.Text.Trim(),
                Uri = TbxUrl.Text.Trim()
            };

            if (!string.IsNullOrEmpty(pending.Token))
            {
                var data = pending.GetWebhookInfo();
                LblResult.Invoke(new MethodInvoker(delegate
                {
                    LblResult.Text = "URI Webhook \t : " + data.Url +
                                     "\nPending Update \t : " + data.PendingUpdateCount +
                                     "\nMax Connection \t : " + data.MaxConnections +
                                     "\nLast Error Date \t : " + data.LastErrorDate +
                                     "\nLast Error Message \t : " + data.LastErrorMessage;
                }));
            }
            else
            {
                MessageBox.Show("Token dibutuhkan");
            }
        }
        */

        private void BtnCek_Click(object sender, EventArgs e)
        {
            Pending pending = new Pending()
            {
                Token = TbxToken.Text.Trim(),
                Uri = TbxUrl.Text.Trim()
            };

            try
            {
                pending.SetWebhook();
                tsLStatus.Text = "Webhook berhasil di set";
                BwChecker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silakan tunggu hingga proses check selesai", Application.ProductName);
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

        private void BgCleaner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Pending pending = new Pending()
            {
                Token = TbxToken.Text.Trim(),
                Uri = TbxUrl.Text.Trim()
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
                        LblResult.Text = "Sisa : " + count;
                    }));
                }

                BwChecker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Token & url dibutuhkan");
            }
        }

        private void BgCleaner_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
        }

        private void BwChecker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Pending pending = new Pending()
            {
                Token = TbxToken.Text.Trim(),
                Uri = TbxUrl.Text.Trim()
            };

            if (!string.IsNullOrEmpty(pending.Token))
            {
                var data = pending.GetWebhookInfo();
                LblResult.Invoke(new MethodInvoker(delegate
                {
                    LblResult.Text = "URI Webhook \t : " + data.Url +
                                     "\nPending Update \t : " + data.PendingUpdateCount +
                                     "\nMax Connection \t : " + data.MaxConnections +
                                     "\nLast Error Date \t : " + data.LastErrorDate +
                                     "\nLast Error Message \t : " + data.LastErrorMessage;
                }));
                if (data.PendingUpdateCount > 20)
                {
                    LblResult.Invoke(new MethodInvoker(delegate
                    {
                        LblResult.Text += "\nLebih dari 20";
                    }));
                }
            }
            else
            {
                MessageBox.Show("Token dibutuhkan");
            }
        }

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

        private void BgCleaner_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tsLStatus.Text = "Siaga..";
            BtnBersihkan.Text = "Mulai Bersihkan";
            MessageBox.Show("Pragat!", Application.ProductName);
        }
    }
}