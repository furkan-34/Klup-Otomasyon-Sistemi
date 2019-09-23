namespace KARSAVOTOMASYON
{
    partial class toplantilar
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
            this.panelUyeler = new System.Windows.Forms.Panel();
            this.btnTopDuzenle = new System.Windows.Forms.Button();
            this.btnTopYeni = new System.Windows.Forms.Button();
            this.btnTopYenile = new System.Windows.Forms.Button();
            this.btnTopSil = new System.Windows.Forms.Button();
            this.btnUyeKapat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvToplanti = new System.Windows.Forms.DataGridView();
            this.panelOnizleme = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTopSaat = new System.Windows.Forms.TextBox();
            this.listeKatilmayanlar = new System.Windows.Forms.ListBox();
            this.btnSilTopYok = new System.Windows.Forms.Button();
            this.listGelenDavetID = new System.Windows.Forms.ListBox();
            this.listeTopKatilmayan = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTopTar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTopAlKarar = new System.Windows.Forms.RichTextBox();
            this.cLTopDavet = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTopOlus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTopİcerik = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTopKonu = new System.Windows.Forms.TextBox();
            this.txtTopAd = new System.Windows.Forms.TextBox();
            this.panelUyeler.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvToplanti)).BeginInit();
            this.panelOnizleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUyeler
            // 
            this.panelUyeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelUyeler.Controls.Add(this.btnTopDuzenle);
            this.panelUyeler.Controls.Add(this.btnTopYeni);
            this.panelUyeler.Controls.Add(this.btnTopYenile);
            this.panelUyeler.Controls.Add(this.btnTopSil);
            this.panelUyeler.Controls.Add(this.btnUyeKapat);
            this.panelUyeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUyeler.Location = new System.Drawing.Point(0, 484);
            this.panelUyeler.Name = "panelUyeler";
            this.panelUyeler.Size = new System.Drawing.Size(1210, 54);
            this.panelUyeler.TabIndex = 3;
            // 
            // btnTopDuzenle
            // 
            this.btnTopDuzenle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTopDuzenle.ForeColor = System.Drawing.Color.Red;
            this.btnTopDuzenle.Image = global::KARSAVOTOMASYON.Properties.Resources.UpdateListItem_32x;
            this.btnTopDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopDuzenle.Location = new System.Drawing.Point(384, 5);
            this.btnTopDuzenle.Name = "btnTopDuzenle";
            this.btnTopDuzenle.Size = new System.Drawing.Size(199, 40);
            this.btnTopDuzenle.TabIndex = 4;
            this.btnTopDuzenle.Text = "DÜZENLE";
            this.btnTopDuzenle.UseVisualStyleBackColor = true;
            this.btnTopDuzenle.Click += new System.EventHandler(this.btnUyeDuzenle_Click);
            // 
            // btnTopYeni
            // 
            this.btnTopYeni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTopYeni.ForeColor = System.Drawing.Color.Red;
            this.btnTopYeni.Image = global::KARSAVOTOMASYON.Properties.Resources._112_Plus_Blue_16x16_72;
            this.btnTopYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopYeni.Location = new System.Drawing.Point(999, 5);
            this.btnTopYeni.Name = "btnTopYeni";
            this.btnTopYeni.Size = new System.Drawing.Size(199, 40);
            this.btnTopYeni.TabIndex = 3;
            this.btnTopYeni.Text = "YENİ TOPLANTI";
            this.btnTopYeni.UseVisualStyleBackColor = true;
            this.btnTopYeni.Click += new System.EventHandler(this.btnUyeYeni_Click);
            // 
            // btnTopYenile
            // 
            this.btnTopYenile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTopYenile.ForeColor = System.Drawing.Color.Red;
            this.btnTopYenile.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnTopYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopYenile.Location = new System.Drawing.Point(794, 5);
            this.btnTopYenile.Name = "btnTopYenile";
            this.btnTopYenile.Size = new System.Drawing.Size(199, 40);
            this.btnTopYenile.TabIndex = 2;
            this.btnTopYenile.Text = "YENİLE";
            this.btnTopYenile.UseVisualStyleBackColor = true;
            this.btnTopYenile.Click += new System.EventHandler(this.btnUyeYenile_Click);
            // 
            // btnTopSil
            // 
            this.btnTopSil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTopSil.ForeColor = System.Drawing.Color.Red;
            this.btnTopSil.Image = global::KARSAVOTOMASYON.Properties.Resources.cop_orji___Kopya;
            this.btnTopSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopSil.Location = new System.Drawing.Point(589, 5);
            this.btnTopSil.Name = "btnTopSil";
            this.btnTopSil.Size = new System.Drawing.Size(199, 40);
            this.btnTopSil.TabIndex = 1;
            this.btnTopSil.Text = "SİL";
            this.btnTopSil.UseVisualStyleBackColor = true;
            this.btnTopSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // btnUyeKapat
            // 
            this.btnUyeKapat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUyeKapat.ForeColor = System.Drawing.Color.Red;
            this.btnUyeKapat.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnUyeKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeKapat.Location = new System.Drawing.Point(12, 5);
            this.btnUyeKapat.Name = "btnUyeKapat";
            this.btnUyeKapat.Size = new System.Drawing.Size(166, 40);
            this.btnUyeKapat.TabIndex = 0;
            this.btnUyeKapat.Text = "KAPAT";
            this.btnUyeKapat.UseVisualStyleBackColor = true;
            this.btnUyeKapat.Click += new System.EventHandler(this.btnUyeKapat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvToplanti);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 200);
            this.panel1.TabIndex = 4;
            // 
            // dtgvToplanti
            // 
            this.dtgvToplanti.AllowUserToAddRows = false;
            this.dtgvToplanti.AllowUserToDeleteRows = false;
            this.dtgvToplanti.AllowUserToResizeColumns = false;
            this.dtgvToplanti.AllowUserToResizeRows = false;
            this.dtgvToplanti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvToplanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvToplanti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvToplanti.Location = new System.Drawing.Point(0, 3);
            this.dtgvToplanti.Name = "dtgvToplanti";
            this.dtgvToplanti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvToplanti.Size = new System.Drawing.Size(1207, 200);
            this.dtgvToplanti.TabIndex = 0;
            this.dtgvToplanti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvToplanti_CellContentClick);
            this.dtgvToplanti.SelectionChanged += new System.EventHandler(this.dtgvToplanti_SelectionChanged);
            // 
            // panelOnizleme
            // 
            this.panelOnizleme.Controls.Add(this.label9);
            this.panelOnizleme.Controls.Add(this.txtTopSaat);
            this.panelOnizleme.Controls.Add(this.listeKatilmayanlar);
            this.panelOnizleme.Controls.Add(this.btnSilTopYok);
            this.panelOnizleme.Controls.Add(this.listGelenDavetID);
            this.panelOnizleme.Controls.Add(this.listeTopKatilmayan);
            this.panelOnizleme.Controls.Add(this.button3);
            this.panelOnizleme.Controls.Add(this.label8);
            this.panelOnizleme.Controls.Add(this.label7);
            this.panelOnizleme.Controls.Add(this.txtTopTar);
            this.panelOnizleme.Controls.Add(this.label6);
            this.panelOnizleme.Controls.Add(this.txtTopAlKarar);
            this.panelOnizleme.Controls.Add(this.cLTopDavet);
            this.panelOnizleme.Controls.Add(this.label4);
            this.panelOnizleme.Controls.Add(this.lblTopOlus);
            this.panelOnizleme.Controls.Add(this.label5);
            this.panelOnizleme.Controls.Add(this.txtTopİcerik);
            this.panelOnizleme.Controls.Add(this.label3);
            this.panelOnizleme.Controls.Add(this.label2);
            this.panelOnizleme.Controls.Add(this.label1);
            this.panelOnizleme.Controls.Add(this.txtTopKonu);
            this.panelOnizleme.Controls.Add(this.txtTopAd);
            this.panelOnizleme.Location = new System.Drawing.Point(0, 211);
            this.panelOnizleme.Name = "panelOnizleme";
            this.panelOnizleme.Size = new System.Drawing.Size(1210, 272);
            this.panelOnizleme.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(4, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 96;
            this.label9.Text = "Toplantı Saati:";
            // 
            // txtTopSaat
            // 
            this.txtTopSaat.Location = new System.Drawing.Point(161, 119);
            this.txtTopSaat.Name = "txtTopSaat";
            this.txtTopSaat.Size = new System.Drawing.Size(229, 20);
            this.txtTopSaat.TabIndex = 95;
            // 
            // listeKatilmayanlar
            // 
            this.listeKatilmayanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeKatilmayanlar.ForeColor = System.Drawing.Color.Red;
            this.listeKatilmayanlar.FormattingEnabled = true;
            this.listeKatilmayanlar.Location = new System.Drawing.Point(683, 60);
            this.listeKatilmayanlar.Name = "listeKatilmayanlar";
            this.listeKatilmayanlar.Size = new System.Drawing.Size(151, 199);
            this.listeKatilmayanlar.TabIndex = 94;
            // 
            // btnSilTopYok
            // 
            this.btnSilTopYok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilTopYok.Location = new System.Drawing.Point(878, 186);
            this.btnSilTopYok.Name = "btnSilTopYok";
            this.btnSilTopYok.Size = new System.Drawing.Size(75, 31);
            this.btnSilTopYok.TabIndex = 93;
            this.btnSilTopYok.Text = ">>>";
            this.btnSilTopYok.UseVisualStyleBackColor = true;
            this.btnSilTopYok.Click += new System.EventHandler(this.btnSilTopYok_Click);
            // 
            // listGelenDavetID
            // 
            this.listGelenDavetID.FormattingEnabled = true;
            this.listGelenDavetID.Location = new System.Drawing.Point(959, 75);
            this.listGelenDavetID.Name = "listGelenDavetID";
            this.listGelenDavetID.Size = new System.Drawing.Size(34, 134);
            this.listGelenDavetID.TabIndex = 92;
            this.listGelenDavetID.Visible = false;
            // 
            // listeTopKatilmayan
            // 
            this.listeTopKatilmayan.FormattingEnabled = true;
            this.listeTopKatilmayan.Location = new System.Drawing.Point(840, 70);
            this.listeTopKatilmayan.Name = "listeTopKatilmayan";
            this.listeTopKatilmayan.Size = new System.Drawing.Size(32, 147);
            this.listeTopKatilmayan.TabIndex = 91;
            this.listeTopKatilmayan.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(878, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 86;
            this.button3.Text = "<<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(680, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "KATILMAYANLAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(4, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Toplantı Tarihi";
            // 
            // txtTopTar
            // 
            this.txtTopTar.Location = new System.Drawing.Point(161, 90);
            this.txtTopTar.Name = "txtTopTar";
            this.txtTopTar.Size = new System.Drawing.Size(229, 20);
            this.txtTopTar.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(467, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Alınan Kararlar";
            // 
            // txtTopAlKarar
            // 
            this.txtTopAlKarar.Location = new System.Drawing.Point(430, 70);
            this.txtTopAlKarar.Name = "txtTopAlKarar";
            this.txtTopAlKarar.Size = new System.Drawing.Size(199, 189);
            this.txtTopAlKarar.TabIndex = 12;
            this.txtTopAlKarar.Text = "";
            // 
            // cLTopDavet
            // 
            this.cLTopDavet.FormattingEnabled = true;
            this.cLTopDavet.Location = new System.Drawing.Point(999, 75);
            this.cLTopDavet.Name = "cLTopDavet";
            this.cLTopDavet.Size = new System.Drawing.Size(199, 184);
            this.cLTopDavet.TabIndex = 11;
            this.cLTopDavet.SelectedIndexChanged += new System.EventHandler(this.cLTopDavet_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(1057, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Davetliler";
            // 
            // lblTopOlus
            // 
            this.lblTopOlus.AutoSize = true;
            this.lblTopOlus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTopOlus.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTopOlus.Location = new System.Drawing.Point(157, 246);
            this.lblTopOlus.Name = "lblTopOlus";
            this.lblTopOlus.Size = new System.Drawing.Size(62, 13);
            this.lblTopOlus.TabIndex = 9;
            this.lblTopOlus.Text = "oluştucu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toplantıyı Oluşturan";
            // 
            // txtTopİcerik
            // 
            this.txtTopİcerik.Location = new System.Drawing.Point(160, 150);
            this.txtTopİcerik.Name = "txtTopİcerik";
            this.txtTopİcerik.Size = new System.Drawing.Size(229, 93);
            this.txtTopİcerik.TabIndex = 6;
            this.txtTopİcerik.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplantı İçeriği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplantı Konusu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplantı Adı";
            // 
            // txtTopKonu
            // 
            this.txtTopKonu.Location = new System.Drawing.Point(160, 56);
            this.txtTopKonu.Name = "txtTopKonu";
            this.txtTopKonu.Size = new System.Drawing.Size(229, 20);
            this.txtTopKonu.TabIndex = 1;
            // 
            // txtTopAd
            // 
            this.txtTopAd.Location = new System.Drawing.Point(160, 23);
            this.txtTopAd.Name = "txtTopAd";
            this.txtTopAd.Size = new System.Drawing.Size(229, 20);
            this.txtTopAd.TabIndex = 0;
            // 
            // toplantilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 538);
            this.ControlBox = false;
            this.Controls.Add(this.panelOnizleme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUyeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1226, 577);
            this.Name = "toplantilar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplantılar";
            this.Load += new System.EventHandler(this.toplantilar_Load);
            this.panelUyeler.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvToplanti)).EndInit();
            this.panelOnizleme.ResumeLayout(false);
            this.panelOnizleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTopDuzenle;
        private System.Windows.Forms.Button btnUyeKapat;
        private System.Windows.Forms.Panel panelUyeler;
        private System.Windows.Forms.Button btnTopYeni;
        public System.Windows.Forms.Button btnTopYenile;
        private System.Windows.Forms.Button btnTopSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvToplanti;
        private System.Windows.Forms.Panel panelOnizleme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTopOlus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtTopİcerik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTopKonu;
        private System.Windows.Forms.TextBox txtTopAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtTopAlKarar;
        private System.Windows.Forms.CheckedListBox cLTopDavet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTopTar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listeTopKatilmayan;
        private System.Windows.Forms.ListBox listGelenDavetID;
        private System.Windows.Forms.Button btnSilTopYok;
        private System.Windows.Forms.ListBox listeKatilmayanlar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTopSaat;
    }
}