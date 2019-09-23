namespace KARSAVOTOMASYON
{
    partial class duyuruGoruntule
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
            this.duyuruWeb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // duyuruWeb
            // 
            this.duyuruWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duyuruWeb.Location = new System.Drawing.Point(0, 0);
            this.duyuruWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.duyuruWeb.Name = "duyuruWeb";
            this.duyuruWeb.Size = new System.Drawing.Size(1168, 545);
            this.duyuruWeb.TabIndex = 0;
            // 
            // duyuruGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 545);
            this.Controls.Add(this.duyuruWeb);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "duyuruGoruntule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.duyuruGoruntule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser duyuruWeb;
    }
}