namespace KARSAVOTOMASYON
{
    partial class gorevGoruntule
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
            this.grvBaslik = new System.Windows.Forms.TextBox();
            this.grvAciklama = new System.Windows.Forms.RichTextBox();
            this.grvRapor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grvVeren = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGGKapat = new System.Windows.Forms.Button();
            this.panelUyeler = new System.Windows.Forms.Panel();
            this.btnUyeYeni = new System.Windows.Forms.Button();
            this.btnUyeYenile = new System.Windows.Forms.Button();
            this.btnGorevGonder = new System.Windows.Forms.Button();
            this.panelUyeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvBaslik
            // 
            this.grvBaslik.Location = new System.Drawing.Point(160, 51);
            this.grvBaslik.Name = "grvBaslik";
            this.grvBaslik.Size = new System.Drawing.Size(281, 20);
            this.grvBaslik.TabIndex = 0;
            // 
            // grvAciklama
            // 
            this.grvAciklama.Location = new System.Drawing.Point(160, 182);
            this.grvAciklama.Name = "grvAciklama";
            this.grvAciklama.Size = new System.Drawing.Size(281, 121);
            this.grvAciklama.TabIndex = 1;
            this.grvAciklama.Text = "";
            // 
            // grvRapor
            // 
            this.grvRapor.Location = new System.Drawing.Point(160, 334);
            this.grvRapor.Name = "grvRapor";
            this.grvRapor.Size = new System.Drawing.Size(281, 121);
            this.grvRapor.TabIndex = 2;
            this.grvRapor.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Görev Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(253, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Görev İçeriği";
            // 
            // grvVeren
            // 
            this.grvVeren.Location = new System.Drawing.Point(160, 120);
            this.grvVeren.Name = "grvVeren";
            this.grvVeren.Size = new System.Drawing.Size(281, 20);
            this.grvVeren.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(252, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Görevi Veren";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(263, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Görev Raporu";
            // 
            // btnGGKapat
            // 
            this.btnGGKapat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGGKapat.ForeColor = System.Drawing.Color.Red;
            this.btnGGKapat.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnGGKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGGKapat.Location = new System.Drawing.Point(12, 5);
            this.btnGGKapat.Name = "btnGGKapat";
            this.btnGGKapat.Size = new System.Drawing.Size(156, 40);
            this.btnGGKapat.TabIndex = 0;
            this.btnGGKapat.Text = "KAPAT";
            this.btnGGKapat.UseVisualStyleBackColor = true;
            this.btnGGKapat.Click += new System.EventHandler(this.btnGGKapat_Click);
            // 
            // panelUyeler
            // 
            this.panelUyeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelUyeler.Controls.Add(this.btnGorevGonder);
            this.panelUyeler.Controls.Add(this.btnUyeYeni);
            this.panelUyeler.Controls.Add(this.btnUyeYenile);
            this.panelUyeler.Controls.Add(this.btnGGKapat);
            this.panelUyeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUyeler.Location = new System.Drawing.Point(0, 461);
            this.panelUyeler.Name = "panelUyeler";
            this.panelUyeler.Size = new System.Drawing.Size(633, 54);
            this.panelUyeler.TabIndex = 9;
            // 
            // btnUyeYeni
            // 
            this.btnUyeYeni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUyeYeni.ForeColor = System.Drawing.Color.Red;
            this.btnUyeYeni.Image = global::KARSAVOTOMASYON.Properties.Resources._112_Plus_Blue_16x16_72;
            this.btnUyeYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeYeni.Location = new System.Drawing.Point(858, 6);
            this.btnUyeYeni.Name = "btnUyeYeni";
            this.btnUyeYeni.Size = new System.Drawing.Size(199, 40);
            this.btnUyeYeni.TabIndex = 3;
            this.btnUyeYeni.Text = "YENİ KAYIT";
            this.btnUyeYeni.UseVisualStyleBackColor = true;
            // 
            // btnUyeYenile
            // 
            this.btnUyeYenile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUyeYenile.ForeColor = System.Drawing.Color.Red;
            this.btnUyeYenile.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnUyeYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeYenile.Location = new System.Drawing.Point(653, 6);
            this.btnUyeYenile.Name = "btnUyeYenile";
            this.btnUyeYenile.Size = new System.Drawing.Size(199, 40);
            this.btnUyeYenile.TabIndex = 2;
            this.btnUyeYenile.Text = "YENİLE";
            this.btnUyeYenile.UseVisualStyleBackColor = true;
            // 
            // btnGorevGonder
            // 
            this.btnGorevGonder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGorevGonder.ForeColor = System.Drawing.Color.Red;
            this.btnGorevGonder.Image = global::KARSAVOTOMASYON.Properties.Resources.PencilTool_206;
            this.btnGorevGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGorevGonder.Location = new System.Drawing.Point(256, 5);
            this.btnGorevGonder.Name = "btnGorevGonder";
            this.btnGorevGonder.Size = new System.Drawing.Size(365, 40);
            this.btnGorevGonder.TabIndex = 4;
            this.btnGorevGonder.Text = "GÖNDER";
            this.btnGorevGonder.UseVisualStyleBackColor = true;
            this.btnGorevGonder.Click += new System.EventHandler(this.button1_Click);
            // 
            // gorevGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 515);
            this.ControlBox = false;
            this.Controls.Add(this.panelUyeler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grvVeren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvRapor);
            this.Controls.Add(this.grvAciklama);
            this.Controls.Add(this.grvBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gorevGoruntule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Görüntüleme";
            this.Load += new System.EventHandler(this.gorevGoruntule_Load);
            this.panelUyeler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox grvBaslik;
        private System.Windows.Forms.RichTextBox grvAciklama;
        private System.Windows.Forms.RichTextBox grvRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grvVeren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGGKapat;
        private System.Windows.Forms.Panel panelUyeler;
        private System.Windows.Forms.Button btnUyeYeni;
        public System.Windows.Forms.Button btnUyeYenile;
        private System.Windows.Forms.Button btnGorevGonder;
    }
}