namespace Telegram.Bots.Toolkit.Views
{
    partial class FrmTentang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTentang));
            this.LblProduk = new System.Windows.Forms.Label();
            this.LblVersi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProduk
            // 
            this.LblProduk.AutoSize = true;
            this.LblProduk.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.LblProduk.Location = new System.Drawing.Point(155, 29);
            this.LblProduk.Name = "LblProduk";
            this.LblProduk.Size = new System.Drawing.Size(90, 37);
            this.LblProduk.TabIndex = 1;
            this.LblProduk.Text = "label1";
            // 
            // LblVersi
            // 
            this.LblVersi.AutoSize = true;
            this.LblVersi.Location = new System.Drawing.Point(159, 66);
            this.LblVersi.Name = "LblVersi";
            this.LblVersi.Size = new System.Drawing.Size(43, 17);
            this.LblVersi.TabIndex = 2;
            this.LblVersi.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(157, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "3rd Library";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(159, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 120);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fody\r\nCostura.Fody\r\nini-parser\r\nNewtonsoft.Json\r\nSystem.Net.Request\r\nTelegram.Bot" +
    "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(302, 155);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(290, 120);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Telegram.Bots.Toolkit.Properties.Resources.defrag_256x256;
            this.pictureBox1.Location = new System.Drawing.Point(21, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTentang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 295);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblVersi);
            this.Controls.Add(this.LblProduk);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTentang";
            this.Text = "FrmTentang";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblProduk;
        private System.Windows.Forms.Label LblVersi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}