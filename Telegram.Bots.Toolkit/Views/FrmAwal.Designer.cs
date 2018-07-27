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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAwal));
            this.BtnCek = new System.Windows.Forms.Button();
            this.BtnBersihkan = new System.Windows.Forms.Button();
            this.TbxToken = new System.Windows.Forms.TextBox();
            this.TbxUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BgCleaner = new System.ComponentModel.BackgroundWorker();
            this.BwChecker = new System.ComponentModel.BackgroundWorker();
            this.setUrlDef = new System.Windows.Forms.CheckBox();
            this.TimerChecker = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periksaStatusOtomatisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxUriDefault = new System.Windows.Forms.TextBox();
            this.CmbBots = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tetapkanURIHookSetelahBersihkanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSimpanBot = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnHapusBot = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCek
            // 
            this.BtnCek.Location = new System.Drawing.Point(6, 25);
            this.BtnCek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCek.Name = "BtnCek";
            this.BtnCek.Size = new System.Drawing.Size(163, 25);
            this.BtnCek.TabIndex = 0;
            this.BtnCek.Text = "SetWebHook";
            this.BtnCek.UseVisualStyleBackColor = true;
            this.BtnCek.Click += new System.EventHandler(this.BtnCek_Click);
            // 
            // BtnBersihkan
            // 
            this.BtnBersihkan.Location = new System.Drawing.Point(6, 56);
            this.BtnBersihkan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBersihkan.Name = "BtnBersihkan";
            this.BtnBersihkan.Size = new System.Drawing.Size(163, 25);
            this.BtnBersihkan.TabIndex = 1;
            this.BtnBersihkan.Text = "Bersihkan pending";
            this.BtnBersihkan.UseVisualStyleBackColor = true;
            this.BtnBersihkan.Click += new System.EventHandler(this.BtnBersihkan_Click);
            // 
            // TbxToken
            // 
            this.TbxToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxToken.Location = new System.Drawing.Point(8, 44);
            this.TbxToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxToken.Name = "TbxToken";
            this.TbxToken.Size = new System.Drawing.Size(469, 25);
            this.TbxToken.TabIndex = 2;
            // 
            // TbxUri
            // 
            this.TbxUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUri.Location = new System.Drawing.Point(8, 95);
            this.TbxUri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxUri.Name = "TbxUri";
            this.TbxUri.Size = new System.Drawing.Size(468, 25);
            this.TbxUri.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bot Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "URI Hook";
            // 
            // LblResult
            // 
            this.LblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblResult.Location = new System.Drawing.Point(6, 17);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(663, 138);
            this.LblResult.TabIndex = 6;
            // 
            // BgCleaner
            // 
            this.BgCleaner.WorkerReportsProgress = true;
            this.BgCleaner.WorkerSupportsCancellation = true;
            this.BgCleaner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgCleaner_DoWork);
            this.BgCleaner.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgCleaner_ProgressChanged);
            this.BgCleaner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgCleaner_RunWorkerCompleted);
            // 
            // BwChecker
            // 
            this.BwChecker.WorkerReportsProgress = true;
            this.BwChecker.WorkerSupportsCancellation = true;
            this.BwChecker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwChecker_DoWork);
            // 
            // setUrlDef
            // 
            this.setUrlDef.AutoSize = true;
            this.setUrlDef.Location = new System.Drawing.Point(44, 150);
            this.setUrlDef.Name = "setUrlDef";
            this.setUrlDef.Size = new System.Drawing.Size(87, 21);
            this.setUrlDef.TabIndex = 8;
            this.setUrlDef.Text = "checkBox1";
            this.setUrlDef.UseVisualStyleBackColor = true;
            // 
            // TimerChecker
            // 
            this.TimerChecker.Enabled = true;
            this.TimerChecker.Interval = 3000;
            this.TimerChecker.Tick += new System.EventHandler(this.TimerChecker_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsProgBar,
            this.tsLStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 21);
            this.toolStripStatusLabel1.Text = "Proggress";
            // 
            // tsProgBar
            // 
            this.tsProgBar.Name = "tsProgBar";
            this.tsProgBar.Size = new System.Drawing.Size(200, 20);
            // 
            // tsLStatus
            // 
            this.tsLStatus.Name = "tsLStatus";
            this.tsLStatus.Size = new System.Drawing.Size(41, 21);
            this.tsLStatus.Text = "Siaga..";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 158);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.pengaturanToolStripMenuItem,
            this.bantuanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periksaStatusOtomatisToolStripMenuItem,
            this.tetapkanURIHookSetelahBersihkanToolStripMenuItem});
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // periksaStatusOtomatisToolStripMenuItem
            // 
            this.periksaStatusOtomatisToolStripMenuItem.CheckOnClick = true;
            this.periksaStatusOtomatisToolStripMenuItem.Name = "periksaStatusOtomatisToolStripMenuItem";
            this.periksaStatusOtomatisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.periksaStatusOtomatisToolStripMenuItem.Text = "Periksa Webhook otomatis";
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bantuanToolStripMenuItem.Text = "Bantuan";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnHapusBot);
            this.groupBox2.Controls.Add(this.BtnSimpanBot);
            this.groupBox2.Controls.Add(this.BtnCek);
            this.groupBox2.Controls.Add(this.BtnBersihkan);
            this.groupBox2.Controls.Add(this.setUrlDef);
            this.groupBox2.Location = new System.Drawing.Point(508, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 183);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tindakan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "URI Default Hook";
            // 
            // TbxUriDefault
            // 
            this.TbxUriDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUriDefault.Location = new System.Drawing.Point(8, 145);
            this.TbxUriDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxUriDefault.Name = "TbxUriDefault";
            this.TbxUriDefault.Size = new System.Drawing.Size(468, 25);
            this.TbxUriDefault.TabIndex = 13;
            // 
            // CmbBots
            // 
            this.CmbBots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbBots.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbBots.FormattingEnabled = true;
            this.CmbBots.Location = new System.Drawing.Point(80, 0);
            this.CmbBots.Name = "CmbBots";
            this.CmbBots.Size = new System.Drawing.Size(396, 25);
            this.CmbBots.TabIndex = 15;
            this.CmbBots.DropDown += new System.EventHandler(this.CmbBots_DropDown);
            this.CmbBots.SelectedIndexChanged += new System.EventHandler(this.CmbBots_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pilih Bot";
            // 
            // tetapkanURIHookSetelahBersihkanToolStripMenuItem
            // 
            this.tetapkanURIHookSetelahBersihkanToolStripMenuItem.CheckOnClick = true;
            this.tetapkanURIHookSetelahBersihkanToolStripMenuItem.Name = "tetapkanURIHookSetelahBersihkanToolStripMenuItem";
            this.tetapkanURIHookSetelahBersihkanToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.tetapkanURIHookSetelahBersihkanToolStripMenuItem.Text = "Tetapkan URI Default setelah Bersihkan";
            // 
            // BtnSimpanBot
            // 
            this.BtnSimpanBot.Location = new System.Drawing.Point(6, 88);
            this.BtnSimpanBot.Name = "BtnSimpanBot";
            this.BtnSimpanBot.Size = new System.Drawing.Size(163, 25);
            this.BtnSimpanBot.TabIndex = 17;
            this.BtnSimpanBot.Text = "Simpan Bot";
            this.BtnSimpanBot.UseVisualStyleBackColor = true;
            this.BtnSimpanBot.Click += new System.EventHandler(this.BtnSimpanBot_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbBots);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TbxToken);
            this.groupBox3.Controls.Add(this.TbxUri);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TbxUriDefault);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 183);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // BtnHapusBot
            // 
            this.BtnHapusBot.Location = new System.Drawing.Point(6, 119);
            this.BtnHapusBot.Name = "BtnHapusBot";
            this.BtnHapusBot.Size = new System.Drawing.Size(163, 25);
            this.BtnHapusBot.TabIndex = 18;
            this.BtnHapusBot.Text = "Hapus Bot";
            this.BtnHapusBot.UseVisualStyleBackColor = true;
            this.BtnHapusBot.Click += new System.EventHandler(this.BtnHapusBot_Click);
            // 
            // FrmAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 407);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelegramBots Toolkit";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCek;
        private System.Windows.Forms.Button BtnBersihkan;
        private System.Windows.Forms.TextBox TbxToken;
        private System.Windows.Forms.TextBox TbxUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResult;
        private System.ComponentModel.BackgroundWorker BgCleaner;
        private System.ComponentModel.BackgroundWorker BwChecker;
        private System.Windows.Forms.CheckBox setUrlDef;
        private System.Windows.Forms.Timer TimerChecker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar tsProgBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel tsLStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periksaStatusOtomatisToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxUriDefault;
        private System.Windows.Forms.ComboBox CmbBots;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tetapkanURIHookSetelahBersihkanToolStripMenuItem;
        private System.Windows.Forms.Button BtnSimpanBot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnHapusBot;
    }
}

