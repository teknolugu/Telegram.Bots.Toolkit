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
            try
            {
                BwChecker.RunWorkerAsync();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, Application.ProductName); }
        }

        private void BtnBersihkan_Click(object sender, EventArgs e)
        {
            if (BgCleaner.IsBusy)
            {
                BgCleaner.CancelAsync();
                BtnBersihkan.Text = "Mulai Bersihkan";
            }
            else
            {
                BgCleaner.RunWorkerAsync();
                LblResult.Text = "Memulai membersihkan...";
                BtnBersihkan.Text = "Stop Bersihkan";
            }
        }

        private void BgCleaner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Pending pending = new Pending()
            {
                Token = TbxToken.Text.Trim(),
                Uri = TbxUrl.Text.Trim(),
                UriDefault = TbxUrlDefault.Text.Trim()
            };

            if (!string.IsNullOrEmpty(pending.Token) &&
                !string.IsNullOrEmpty(pending.Uri))
            {
                int count = pending.GetWebhookInfo().PendingUpdateCount;
                for (int x = 0; x <= count; count--)
                {
                    pending.HapusWebhook();
                    pending.GetUpdates();
                    pending.SetWebhook();
                    count = pending.GetWebhookInfo().PendingUpdateCount;
                    e.Result = count;
                    LblResult.Invoke(new MethodInvoker(delegate
                    {
                        LblResult.Text = "Sisa pending : " + count;
                    }));
                }
                if (!string.IsNullOrEmpty(pending.UriDefault) && setUrlDef.Checked == true)
                {
                    pending.SetWebhookDefault();
                } else {}
                BwChecker.RunWorkerAsync();
                MessageBox.Show("Selesai membersihkan!");
            }
            else
            {
                MessageBox.Show("Token & URI Clear Hook dibutuhkan!");
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
                    LblResult.Text = "URI Webhook        : " + data.Url +
                                     "\nPending Update     : " + data.PendingUpdateCount +
                                     "\nMax Connection     : " + data.MaxConnections +
                                     "\nLast Error Date    : " + data.LastErrorDate +
                                     "\nLast Error Message : " + data.LastErrorMessage;
                }));
                if (data.PendingUpdateCount > 5)
                {
                    LblResult.Invoke(new MethodInvoker(delegate
                    {
                        LblResult.Text += "\nLebih dari 5";
                    }));
                }
            }
            else
            {
                MessageBox.Show("Token dibutuhkan!");
            }
        }

        private void TimerChecker_Tick(object sender, EventArgs e)
        {
            //BwChecker.RunWorkerAsync();
        }

        private void setWHD(object sender, EventArgs e)
        {
            TbxUrlDefault.Enabled = setUrlDef.Checked;
        }
    }
}