namespace Telegram.Bots.Toolkit.Views
{
    partial class FrmAwal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnCek = new System.Windows.Forms.Button();
            this.BtnBersihkan = new System.Windows.Forms.Button();
            this.TbxToken = new System.Windows.Forms.TextBox();
            this.TbxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BgCleaner = new System.ComponentModel.BackgroundWorker();
            this.BwChecker = new System.ComponentModel.BackgroundWorker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TimerChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnCek
            // 
            this.BtnCek.Location = new System.Drawing.Point(521, 59);
            this.BtnCek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCek.Name = "BtnCek";
            this.BtnCek.Size = new System.Drawing.Size(163, 31);
            this.BtnCek.TabIndex = 0;
            this.BtnCek.Text = "Cek Token";
            this.BtnCek.UseVisualStyleBackColor = true;
            this.BtnCek.Click += new System.EventHandler(this.BtnCek_Click);
            // 
            // BtnBersihkan
            // 
            this.BtnBersihkan.Location = new System.Drawing.Point(521, 98);
            this.BtnBersihkan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBersihkan.Name = "BtnBersihkan";
            this.BtnBersihkan.Size = new System.Drawing.Size(163, 31);
            this.BtnBersihkan.TabIndex = 1;
            this.BtnBersihkan.Text = "Bersihkan pending";
            this.BtnBersihkan.UseVisualStyleBackColor = true;
            this.BtnBersihkan.Click += new System.EventHandler(this.BtnBersihkan_Click);
            // 
            // TbxToken
            // 
            this.TbxToken.Location = new System.Drawing.Point(35, 65);
            this.TbxToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxToken.Name = "TbxToken";
            this.TbxToken.Size = new System.Drawing.Size(445, 25);
            this.TbxToken.TabIndex = 2;
            this.TbxToken.Text = "483238348:AAG9MXBs-drSwOszpXcLGlTAmF8oTbx22Nw";
            // 
            // TbxUrl
            // 
            this.TbxUrl.Location = new System.Drawing.Point(35, 122);
            this.TbxUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxUrl.Name = "TbxUrl";
            this.TbxUrl.Size = new System.Drawing.Size(444, 25);
            this.TbxUrl.TabIndex = 3;
            this.TbxUrl.Text = "https://app.winten.tk/telebhoth/ori/hook.php";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bot Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "URI Hook";
            // 
            // LblResult
            // 
            this.LblResult.Location = new System.Drawing.Point(33, 192);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(447, 185);
            this.LblResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasil";
            // 
            // BgCleaner
            // 
            this.BgCleaner.WorkerReportsProgress = true;
            this.BgCleaner.WorkerSupportsCancellation = true;
            this.BgCleaner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgCleaner_DoWork);
            this.BgCleaner.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgCleaner_ProgressChanged);
            // 
            // BwChecker
            // 
            this.BwChecker.WorkerReportsProgress = true;
            this.BwChecker.WorkerSupportsCancellation = true;
            this.BwChecker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwChecker_DoWork);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(533, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TimerChecker
            // 
            this.TimerChecker.Enabled = true;
            this.TimerChecker.Interval = 10000;
            this.TimerChecker.Tick += new System.EventHandler(this.TimerChecker_Tick);
            // 
            // FrmAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 386);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxUrl);
            this.Controls.Add(this.TbxToken);
            this.Controls.Add(this.BtnBersihkan);
            this.Controls.Add(this.BtnCek);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAwal";
            this.Text = "TelegramBots Toolkit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCek;
        private System.Windows.Forms.Button BtnBersihkan;
        private System.Windows.Forms.TextBox TbxToken;
        private System.Windows.Forms.TextBox TbxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker BgCleaner;
        private System.ComponentModel.BackgroundWorker BwChecker;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer TimerChecker;
    }
}

