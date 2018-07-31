namespace Telegram.Bots.Toolkit.UserControls
{
    abstract partial class COverlayForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCloseOverlay = new System.Windows.Forms.Button();
            this.PnlFormDock = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnCloseOverlay
            // 
            this.BtnCloseOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseOverlay.Location = new System.Drawing.Point(405, 5);
            this.BtnCloseOverlay.Name = "BtnCloseOverlay";
            this.BtnCloseOverlay.Size = new System.Drawing.Size(31, 30);
            this.BtnCloseOverlay.TabIndex = 2;
            this.BtnCloseOverlay.Text = "X";
            this.BtnCloseOverlay.UseVisualStyleBackColor = true;
            // 
            // PnlFormDock
            // 
            this.PnlFormDock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFormDock.Location = new System.Drawing.Point(10, 10);
            this.PnlFormDock.Name = "PnlFormDock";
            this.PnlFormDock.Size = new System.Drawing.Size(420, 180);
            this.PnlFormDock.TabIndex = 3;
            // 
            // COverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCloseOverlay);
            this.Controls.Add(this.PnlFormDock);
            this.DoubleBuffered = true;
            this.Name = "COverlayForm";
            this.Size = new System.Drawing.Size(440, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCloseOverlay;
        private System.Windows.Forms.Panel PnlFormDock;
    }
}
