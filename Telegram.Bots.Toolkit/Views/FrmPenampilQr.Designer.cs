namespace Telegram.Bots.Toolkit.Views
{
    partial class FrmPenampilQr
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
            this.PicPenampilQr = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbxQrProperti = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPenampilQr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicPenampilQr
            // 
            this.PicPenampilQr.Location = new System.Drawing.Point(28, 31);
            this.PicPenampilQr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicPenampilQr.Name = "PicPenampilQr";
            this.PicPenampilQr.Size = new System.Drawing.Size(250, 250);
            this.PicPenampilQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPenampilQr.TabIndex = 0;
            this.PicPenampilQr.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbxQrProperti);
            this.groupBox1.Location = new System.Drawing.Point(310, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(297, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TbxQrProperti
            // 
            this.TbxQrProperti.BackColor = System.Drawing.SystemColors.Control;
            this.TbxQrProperti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxQrProperti.Location = new System.Drawing.Point(11, 25);
            this.TbxQrProperti.Multiline = true;
            this.TbxQrProperti.Name = "TbxQrProperti";
            this.TbxQrProperti.Size = new System.Drawing.Size(270, 215);
            this.TbxQrProperti.TabIndex = 0;
            // 
            // FrmPenampilQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicPenampilQr);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPenampilQr";
            this.Text = "FrmPenampilQr";
            ((System.ComponentModel.ISupportInitialize)(this.PicPenampilQr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PicPenampilQr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxQrProperti;
    }
}