namespace KARSAVOTOMASYON
{
    partial class yeniGorevli
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelYgrvli = new System.Windows.Forms.Panel();
            this.txtGrvBul = new System.Windows.Forms.TextBox();
            this.dtGVyGrv = new System.Windows.Forms.DataGridView();
            this.txtGrvBilgi = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrvKaydet = new System.Windows.Forms.Button();
            this.btnYGrvapat = new System.Windows.Forms.Button();
            this.btnGrvTemizle = new System.Windows.Forms.Button();
            this.txtGrvKulAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrvSif = new System.Windows.Forms.TextBox();
            this.cbGrvPz = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPozD = new System.Windows.Forms.TextBox();
            this.cLyetki = new System.Windows.Forms.CheckedListBox();
            this.panelYgrvli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVyGrv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(156, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Aranacak Kişinin Öğrenci Numarası : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(289, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "SONUÇLAR";
            // 
            // panelYgrvli
            // 
            this.panelYgrvli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelYgrvli.Controls.Add(this.txtGrvBul);
            this.panelYgrvli.Controls.Add(this.label2);
            this.panelYgrvli.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYgrvli.Location = new System.Drawing.Point(0, 0);
            this.panelYgrvli.Name = "panelYgrvli";
            this.panelYgrvli.Size = new System.Drawing.Size(934, 43);
            this.panelYgrvli.TabIndex = 34;
            // 
            // txtGrvBul
            // 
            this.txtGrvBul.Location = new System.Drawing.Point(425, 12);
            this.txtGrvBul.MaxLength = 13;
            this.txtGrvBul.Name = "txtGrvBul";
            this.txtGrvBul.Size = new System.Drawing.Size(365, 20);
            this.txtGrvBul.TabIndex = 15;
            this.txtGrvBul.TextChanged += new System.EventHandler(this.txtGrvBul_TextChanged);
            this.txtGrvBul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrvBul_KeyPress);
            // 
            // dtGVyGrv
            // 
            this.dtGVyGrv.AllowUserToAddRows = false;
            this.dtGVyGrv.AllowUserToDeleteRows = false;
            this.dtGVyGrv.AllowUserToResizeColumns = false;
            this.dtGVyGrv.AllowUserToResizeRows = false;
            this.dtGVyGrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVyGrv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGVyGrv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtGVyGrv.Location = new System.Drawing.Point(12, 88);
            this.dtGVyGrv.MultiSelect = false;
            this.dtGVyGrv.Name = "dtGVyGrv";
            this.dtGVyGrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVyGrv.Size = new System.Drawing.Size(662, 123);
            this.dtGVyGrv.TabIndex = 33;
            this.dtGVyGrv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVyGrv_CellClick);
            this.dtGVyGrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVyGrv_CellContentClick);
            this.dtGVyGrv.SelectionChanged += new System.EventHandler(this.dtGVyGrv_SelectionChanged);
            // 
            // txtGrvBilgi
            // 
            this.txtGrvBilgi.Enabled = false;
            this.txtGrvBilgi.Location = new System.Drawing.Point(690, 88);
            this.txtGrvBilgi.Name = "txtGrvBilgi";
            this.txtGrvBilgi.Size = new System.Drawing.Size(256, 337);
            this.txtGrvBilgi.TabIndex = 32;
            this.txtGrvBilgi.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnGrvKaydet);
            this.panel2.Controls.Add(this.btnYGrvapat);
            this.panel2.Controls.Add(this.btnGrvTemizle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 54);
            this.panel2.TabIndex = 31;
            // 
            // btnGrvKaydet
            // 
            this.btnGrvKaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvKaydet.ForeColor = System.Drawing.Color.Red;
            this.btnGrvKaydet.Image = global::KARSAVOTOMASYON.Properties.Resources.save_16xLG;
            this.btnGrvKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvKaydet.Location = new System.Drawing.Point(680, 5);
            this.btnGrvKaydet.Name = "btnGrvKaydet";
            this.btnGrvKaydet.Size = new System.Drawing.Size(246, 40);
            this.btnGrvKaydet.TabIndex = 3;
            this.btnGrvKaydet.Text = "EKLE";
            this.btnGrvKaydet.UseVisualStyleBackColor = true;
            this.btnGrvKaydet.Click += new System.EventHandler(this.btnGrvKaydet_Click);
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
            this.btnGrvTemizle.Location = new System.Drawing.Point(428, 5);
            this.btnGrvTemizle.Name = "btnGrvTemizle";
            this.btnGrvTemizle.Size = new System.Drawing.Size(246, 40);
            this.btnGrvTemizle.TabIndex = 2;
            this.btnGrvTemizle.Text = "TEMİZLE";
            this.btnGrvTemizle.UseVisualStyleBackColor = true;
            this.btnGrvTemizle.Click += new System.EventHandler(this.btnGrvTemizle_Click);
            // 
            // txtGrvKulAd
            // 
            this.txtGrvKulAd.Location = new System.Drawing.Point(114, 217);
            this.txtGrvKulAd.Name = "txtGrvKulAd";
            this.txtGrvKulAd.Size = new System.Drawing.Size(147, 20);
            this.txtGrvKulAd.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(15, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(15, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Şifre :";
            // 
            // txtGrvSif
            // 
            this.txtGrvSif.Location = new System.Drawing.Point(114, 255);
            this.txtGrvSif.Name = "txtGrvSif";
            this.txtGrvSif.Size = new System.Drawing.Size(147, 20);
            this.txtGrvSif.TabIndex = 46;
            // 
            // cbGrvPz
            // 
            this.cbGrvPz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrvPz.FormattingEnabled = true;
            this.cbGrvPz.Items.AddRange(new object[] {
            "Başkan",
            "Başkan Yardımcısı",
            "Yönetim Kurulu Üyesi",
            "Denetim Kurulu Başkanı",
            "Denetim Kurulu Üyesi",
            "Sayman",
            "Yazman",
            "Üye",
            "Diğer"});
            this.cbGrvPz.Location = new System.Drawing.Point(114, 300);
            this.cbGrvPz.Name = "cbGrvPz";
            this.cbGrvPz.Size = new System.Drawing.Size(147, 21);
            this.cbGrvPz.TabIndex = 49;
            this.cbGrvPz.SelectedIndexChanged += new System.EventHandler(this.cbGrvPz_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(15, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Pozisyon :";
            // 
            // txtPozD
            // 
            this.txtPozD.Location = new System.Drawing.Point(277, 301);
            this.txtPozD.Name = "txtPozD";
            this.txtPozD.Size = new System.Drawing.Size(152, 20);
            this.txtPozD.TabIndex = 52;
            this.txtPozD.Text = "(Diğer)";
            // 
            // cLyetki
            // 
            this.cLyetki.FormattingEnabled = true;
            this.cLyetki.Items.AddRange(new object[] {
            "Kayıtlar Bölümü Görüntüleme",
            "Projeler Bölümü Görüntüleme",
            "Toplantılar Bölümü Görüntüleme",
            "Görevler Bölümü Görüntüleme",
            "Üye Listesi Görüntüleme",
            "Üye Listesi Düzenleme",
            "Görevli Listesi Görüntüleme",
            "Görevli Listesi Düzenleme",
            "Referans Listesi Görüntüleme",
            "Referans Listesi Düzenleme",
            "Bütün Projeleri Görüntüleme",
            "Bütün Proje Listesini Düzenleme",
            "Bütün Toplantıları Görüntüleme",
            "Bütün Toplantı Listesini Düzenleme",
            "Bütün Görevleri Görüntüleme",
            "Görev Listesi Düzenleme",
            "Maliye Listesi Görüntüleme",
            "Maliye Listesi Düzenleme"});
            this.cLyetki.Location = new System.Drawing.Point(448, 226);
            this.cLyetki.Name = "cLyetki";
            this.cLyetki.Size = new System.Drawing.Size(226, 199);
            this.cLyetki.TabIndex = 53;
            this.cLyetki.SelectedIndexChanged += new System.EventHandler(this.cLyetki_SelectedIndexChanged);
            // 
            // yeniGorevli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 478);
            this.ControlBox = false;
            this.Controls.Add(this.cLyetki);
            this.Controls.Add(this.txtPozD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGrvPz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrvSif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrvKulAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelYgrvli);
            this.Controls.Add(this.dtGVyGrv);
            this.Controls.Add(this.txtGrvBilgi);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(954, 521);
            this.Name = "yeniGorevli";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Görevli Kayıt Ekranı";
            this.Load += new System.EventHandler(this.yeniGorevli_Load);
            this.panelYgrvli.ResumeLayout(false);
            this.panelYgrvli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVyGrv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelYgrvli;
        private System.Windows.Forms.DataGridView dtGVyGrv;
        private System.Windows.Forms.RichTextBox txtGrvBilgi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGrvKaydet;
        private System.Windows.Forms.Button btnYGrvapat;
        private System.Windows.Forms.Button btnGrvTemizle;
        private System.Windows.Forms.TextBox txtGrvBul;
        private System.Windows.Forms.TextBox txtGrvKulAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrvSif;
        private System.Windows.Forms.ComboBox cbGrvPz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPozD;
        private System.Windows.Forms.CheckedListBox cLyetki;
    }
}