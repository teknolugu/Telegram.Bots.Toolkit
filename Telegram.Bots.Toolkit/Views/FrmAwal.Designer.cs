﻿namespace Telegram.Bots.Toolkit.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAwal));
            this.BtnCek = new System.Windows.Forms.Button();
            this.BtnBersihkan = new System.Windows.Forms.Button();
            this.TbxToken = new System.Windows.Forms.TextBox();
            this.TbxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BgCleaner = new System.ComponentModel.BackgroundWorker();
            this.BwChecker = new System.ComponentModel.BackgroundWorker();
            this.TimerChecker = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxUrlDefault = new System.Windows.Forms.TextBox();
            this.setUrlDef = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnCek
            // 
            this.BtnCek.Location = new System.Drawing.Point(465, 29);
            this.BtnCek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCek.Name = "BtnCek";
            this.BtnCek.Size = new System.Drawing.Size(165, 26);
            this.BtnCek.TabIndex = 0;
            this.BtnCek.Text = "Cek Webhook";
            this.BtnCek.UseVisualStyleBackColor = true;
            this.BtnCek.Click += new System.EventHandler(this.BtnCek_Click);
            // 
            // BtnBersihkan
            // 
            this.BtnBersihkan.Location = new System.Drawing.Point(465, 143);
            this.BtnBersihkan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBersihkan.Name = "BtnBersihkan";
            this.BtnBersihkan.Size = new System.Drawing.Size(165, 26);
            this.BtnBersihkan.TabIndex = 1;
            this.BtnBersihkan.Text = "Mulai Bersihkan";
            this.BtnBersihkan.UseVisualStyleBackColor = true;
            this.BtnBersihkan.Click += new System.EventHandler(this.BtnBersihkan_Click);
            // 
            // TbxToken
            // 
            this.TbxToken.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxToken.Location = new System.Drawing.Point(14, 30);
            this.TbxToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxToken.Name = "TbxToken";
            this.TbxToken.Size = new System.Drawing.Size(445, 23);
            this.TbxToken.TabIndex = 2;
            this.TbxToken.Text = "483238348:AAG9MXBs-drSwOszpXcLGlTAmF8oTbx22Nw";
            // 
            // TbxUrl
            // 
            this.TbxUrl.Location = new System.Drawing.Point(15, 143);
            this.TbxUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxUrl.Name = "TbxUrl";
            this.TbxUrl.Size = new System.Drawing.Size(444, 25);
            this.TbxUrl.TabIndex = 3;
            this.TbxUrl.Text = "https://projekt-kripto.xyz/azhe403/ori/hook.php";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bot Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "URI Clear Hook";
            // 
            // LblResult
            // 
            this.LblResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(21, 207);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(601, 88);
            this.LblResult.TabIndex = 6;
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
            // TimerChecker
            // 
            this.TimerChecker.Enabled = true;
            this.TimerChecker.Interval = 10000;
            this.TimerChecker.Tick += new System.EventHandler(this.TimerChecker_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "URI Default Hook";
            // 
            // TbxUrlDefault
            // 
            this.TbxUrlDefault.Enabled = false;
            this.TbxUrlDefault.Location = new System.Drawing.Point(15, 86);
            this.TbxUrlDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxUrlDefault.Name = "TbxUrlDefault";
            this.TbxUrlDefault.Size = new System.Drawing.Size(444, 25);
            this.TbxUrlDefault.TabIndex = 10;
            this.TbxUrlDefault.Text = "https://projekt-kripto.xyz/azhe403/stable/hook.php";
            // 
            // setUrlDef
            // 
            this.setUrlDef.AutoSize = true;
            this.setUrlDef.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUrlDef.Location = new System.Drawing.Point(468, 90);
            this.setUrlDef.Name = "setUrlDef";
            this.setUrlDef.Size = new System.Drawing.Size(162, 19);
            this.setUrlDef.TabIndex = 12;
            this.setUrlDef.Text = "Auto setWebhook Default";
            this.setUrlDef.UseVisualStyleBackColor = true;
            this.setUrlDef.CheckedChanged += new System.EventHandler(this.setWHD);
            // 
            // FrmAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 320);
            this.Controls.Add(this.setUrlDef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxUrlDefault);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxUrl);
            this.Controls.Add(this.TbxToken);
            this.Controls.Add(this.BtnBersihkan);
            this.Controls.Add(this.BtnCek);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox TbxUrlDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblResult;
        private System.ComponentModel.BackgroundWorker BgCleaner;
        private System.ComponentModel.BackgroundWorker BwChecker;
        private System.Windows.Forms.Timer TimerChecker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox setUrlDef;
    }
}
