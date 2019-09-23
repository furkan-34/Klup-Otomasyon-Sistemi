namespace KARSAVOTOMASYON
{
    partial class yeniProje
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrjAciklama = new System.Windows.Forms.RichTextBox();
            this.txtPrjAd = new System.Windows.Forms.TextBox();
            this.txtPrjAdminAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrjAdminAra = new System.Windows.Forms.TextBox();
            this.btnPrjAdmnAra = new System.Windows.Forms.Button();
            this.dtgvYprjUyeler = new System.Windows.Forms.DataGridView();
            this.txtYprjUyeAra = new System.Windows.Forms.TextBox();
            this.listByPrjUyeler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listeSecID = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrjKaydet = new System.Windows.Forms.Button();
            this.btnYGrvapat = new System.Windows.Forms.Button();
            this.btnGrvTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvYprjUyeler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(590, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 72;
            this.label12.Text = "AÇIKLAMA";
            // 
            // txtPrjAciklama
            // 
            this.txtPrjAciklama.Location = new System.Drawing.Point(522, 39);
            this.txtPrjAciklama.Name = "txtPrjAciklama";
            this.txtPrjAciklama.Size = new System.Drawing.Size(203, 198);
            this.txtPrjAciklama.TabIndex = 71;
            this.txtPrjAciklama.Text = "";
            // 
            // txtPrjAd
            // 
            this.txtPrjAd.Location = new System.Drawing.Point(149, 47);
            this.txtPrjAd.MaxLength = 25;
            this.txtPrjAd.Name = "txtPrjAd";
            this.txtPrjAd.Size = new System.Drawing.Size(275, 20);
            this.txtPrjAd.TabIndex = 51;
            // 
            // txtPrjAdminAd
            // 
            this.txtPrjAdminAd.Enabled = false;
            this.txtPrjAdminAd.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtPrjAdminAd.Location = new System.Drawing.Point(149, 147);
            this.txtPrjAdminAd.MaxLength = 25;
            this.txtPrjAdminAd.Name = "txtPrjAdminAd";
            this.txtPrjAdminAd.Size = new System.Drawing.Size(216, 22);
            this.txtPrjAdminAd.TabIndex = 73;
            this.txtPrjAdminAd.Click += new System.EventHandler(this.txtPrjAdminAd_Click);
            this.txtPrjAdminAd.TextChanged += new System.EventHandler(this.txtPrjAdminAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(22, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Proje Yöneticisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(22, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Proje Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(590, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "ÜYELER";
            // 
            // txtPrjAdminAra
            // 
            this.txtPrjAdminAra.Location = new System.Drawing.Point(149, 97);
            this.txtPrjAdminAra.MaxLength = 13;
            this.txtPrjAdminAra.Name = "txtPrjAdminAra";
            this.txtPrjAdminAra.Size = new System.Drawing.Size(216, 20);
            this.txtPrjAdminAra.TabIndex = 77;
            this.txtPrjAdminAra.Text = "Yönetici için Öğrenci No Giriniz";
            this.txtPrjAdminAra.Click += new System.EventHandler(this.txtPrjAdminAra_Click);
            this.txtPrjAdminAra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrjAdminAra_MouseClick);
            this.txtPrjAdminAra.TextChanged += new System.EventHandler(this.txtPrjAdminAra_Click);
            this.txtPrjAdminAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrjAdminAra_KeyPress);
            this.txtPrjAdminAra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtPrjAdminAra_MouseDoubleClick);
            // 
            // btnPrjAdmnAra
            // 
            this.btnPrjAdmnAra.Location = new System.Drawing.Point(371, 97);
            this.btnPrjAdmnAra.Name = "btnPrjAdmnAra";
            this.btnPrjAdmnAra.Size = new System.Drawing.Size(53, 21);
            this.btnPrjAdmnAra.TabIndex = 78;
            this.btnPrjAdmnAra.Text = "Ara";
            this.btnPrjAdmnAra.UseVisualStyleBackColor = true;
            this.btnPrjAdmnAra.Click += new System.EventHandler(this.btnPrjAdmnAra_Click);
            // 
            // dtgvYprjUyeler
            // 
            this.dtgvYprjUyeler.AllowUserToAddRows = false;
            this.dtgvYprjUyeler.AllowUserToDeleteRows = false;
            this.dtgvYprjUyeler.AllowUserToResizeColumns = false;
            this.dtgvYprjUyeler.AllowUserToResizeRows = false;
            this.dtgvYprjUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvYprjUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvYprjUyeler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvYprjUyeler.Location = new System.Drawing.Point(25, 276);
            this.dtgvYprjUyeler.MultiSelect = false;
            this.dtgvYprjUyeler.Name = "dtgvYprjUyeler";
            this.dtgvYprjUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvYprjUyeler.Size = new System.Drawing.Size(371, 165);
            this.dtgvYprjUyeler.TabIndex = 79;
            this.dtgvYprjUyeler.SelectionChanged += new System.EventHandler(this.dtgvYprjUyeler_SelectionChanged);
            // 
            // txtYprjUyeAra
            // 
            this.txtYprjUyeAra.Location = new System.Drawing.Point(91, 240);
            this.txtYprjUyeAra.Name = "txtYprjUyeAra";
            this.txtYprjUyeAra.Size = new System.Drawing.Size(246, 20);
            this.txtYprjUyeAra.TabIndex = 80;
            this.txtYprjUyeAra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtYprjUyeAra_MouseClick);
            this.txtYprjUyeAra.TextChanged += new System.EventHandler(this.txtYprjUyeAra_TextChanged);
            this.txtYprjUyeAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYprjUyeAra_KeyPress);
            // 
            // listByPrjUyeler
            // 
            this.listByPrjUyeler.FormattingEnabled = true;
            this.listByPrjUyeler.Location = new System.Drawing.Point(522, 290);
            this.listByPrjUyeler.Name = "listByPrjUyeler";
            this.listByPrjUyeler.Size = new System.Drawing.Size(203, 147);
            this.listByPrjUyeler.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(433, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listeSecID
            // 
            this.listeSecID.FormattingEnabled = true;
            this.listeSecID.Location = new System.Drawing.Point(731, 303);
            this.listeSecID.Name = "listeSecID";
            this.listeSecID.Size = new System.Drawing.Size(51, 134);
            this.listeSecID.TabIndex = 84;
            this.listeSecID.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(433, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 85;
            this.button3.Text = "<<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnPrjKaydet);
            this.panel2.Controls.Add(this.btnYGrvapat);
            this.panel2.Controls.Add(this.btnGrvTemizle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 54);
            this.panel2.TabIndex = 86;
            // 
            // btnPrjKaydet
            // 
            this.btnPrjKaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrjKaydet.ForeColor = System.Drawing.Color.Red;
            this.btnPrjKaydet.Image = global::KARSAVOTOMASYON.Properties.Resources.save_16xLG;
            this.btnPrjKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrjKaydet.Location = new System.Drawing.Point(538, 5);
            this.btnPrjKaydet.Name = "btnPrjKaydet";
            this.btnPrjKaydet.Size = new System.Drawing.Size(246, 40);
            this.btnPrjKaydet.TabIndex = 3;
            this.btnPrjKaydet.Text = "EKLE";
            this.btnPrjKaydet.UseVisualStyleBackColor = true;
            this.btnPrjKaydet.Click += new System.EventHandler(this.btnGrvKaydet_Click);
            // 
            // btnYGrvapat
            // 
            this.btnYGrvapat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnYGrvapat.ForeColor = System.Drawing.Color.Red;
            this.btnYGrvapat.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnYGrvapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYGrvapat.Location = new System.Drawing.Point(12, 5);
            this.btnYGrvapat.Name = "btnYGrvapat";
            this.btnYGrvapat.Size = new System.Drawing.Size(202, 40);
            this.btnYGrvapat.TabIndex = 0;
            this.btnYGrvapat.Text = "KAPAT";
            this.btnYGrvapat.UseVisualStyleBackColor = true;
            this.btnYGrvapat.Click += new System.EventHandler(this.btnYGrvapat_Click);
            // 
            // btnGrvTemizle
            // 
            this.btnGrvTemizle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvTemizle.ForeColor = System.Drawing.Color.Red;
            this.btnGrvTemizle.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnGrvTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvTemizle.Location = new System.Drawing.Point(286, 5);
            this.btnGrvTemizle.Name = "btnGrvTemizle";
            this.btnGrvTemizle.Size = new System.Drawing.Size(246, 40);
            this.btnGrvTemizle.TabIndex = 2;
            this.btnGrvTemizle.Text = "TEMİZLE";
            this.btnGrvTemizle.UseVisualStyleBackColor = true;
            this.btnGrvTemizle.Click += new System.EventHandler(this.btnGrvTemizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(128, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "ÜYE ARAMA (Öğrenci No)";
            // 
            // yeniProje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 508);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listeSecID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listByPrjUyeler);
            this.Controls.Add(this.txtYprjUyeAra);
            this.Controls.Add(this.dtgvYprjUyeler);
            this.Controls.Add(this.btnPrjAdmnAra);
            this.Controls.Add(this.txtPrjAdminAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrjAdminAd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrjAciklama);
            this.Controls.Add(this.txtPrjAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(808, 547);
            this.Name = "yeniProje";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Proje Kayıt";
            this.Load += new System.EventHandler(this.yeniProje_Load);
            this.Click += new System.EventHandler(this.yeniProje_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvYprjUyeler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtPrjAciklama;
        private System.Windows.Forms.TextBox txtPrjAd;
        private System.Windows.Forms.TextBox txtPrjAdminAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrjAdminAra;
        private System.Windows.Forms.Button btnPrjAdmnAra;
        private System.Windows.Forms.DataGridView dtgvYprjUyeler;
        private System.Windows.Forms.TextBox txtYprjUyeAra;
        private System.Windows.Forms.ListBox listByPrjUyeler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listeSecID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPrjKaydet;
        private System.Windows.Forms.Button btnYGrvapat;
        private System.Windows.Forms.Button btnGrvTemizle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}