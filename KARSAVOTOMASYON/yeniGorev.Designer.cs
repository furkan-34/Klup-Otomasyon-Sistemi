namespace KARSAVOTOMASYON
{
    partial class yeniGorev
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrvKaydet = new System.Windows.Forms.Button();
            this.btnGrvKapat = new System.Windows.Forms.Button();
            this.btnGrvTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtSaat = new System.Windows.Forms.DateTimePicker();
            this.dtTarihGrv = new System.Windows.Forms.DateTimePicker();
            this.btnSilGrvli = new System.Windows.Forms.Button();
            this.listBoxGorevlilerID = new System.Windows.Forms.ListBox();
            this.btnEkleGrvli = new System.Windows.Forms.Button();
            this.listBoxGorevliler = new System.Windows.Forms.ListBox();
            this.txtGrvAra = new System.Windows.Forms.TextBox();
            this.dtgvGrvUye = new System.Windows.Forms.DataGridView();
            this.txtGrvIcerik = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrvAd = new System.Windows.Forms.TextBox();
            this.cbGorevKate = new System.Windows.Forms.ComboBox();
            this.cbGorevliArama = new System.Windows.Forms.ComboBox();
            this.dtSaatSon = new System.Windows.Forms.DateTimePicker();
            this.dtTarihSon = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrvUye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnGrvKaydet);
            this.panel2.Controls.Add(this.btnGrvKapat);
            this.panel2.Controls.Add(this.btnGrvTemizle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 54);
            this.panel2.TabIndex = 103;
            // 
            // btnGrvKaydet
            // 
            this.btnGrvKaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvKaydet.ForeColor = System.Drawing.Color.Red;
            this.btnGrvKaydet.Image = global::KARSAVOTOMASYON.Properties.Resources.save_16xLG;
            this.btnGrvKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvKaydet.Location = new System.Drawing.Point(597, 5);
            this.btnGrvKaydet.Name = "btnGrvKaydet";
            this.btnGrvKaydet.Size = new System.Drawing.Size(278, 40);
            this.btnGrvKaydet.TabIndex = 3;
            this.btnGrvKaydet.Text = "EKLE";
            this.btnGrvKaydet.UseVisualStyleBackColor = true;
            this.btnGrvKaydet.Click += new System.EventHandler(this.btnPrjKaydet_Click);
            // 
            // btnGrvKapat
            // 
            this.btnGrvKapat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvKapat.ForeColor = System.Drawing.Color.Red;
            this.btnGrvKapat.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnGrvKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvKapat.Location = new System.Drawing.Point(12, 5);
            this.btnGrvKapat.Name = "btnGrvKapat";
            this.btnGrvKapat.Size = new System.Drawing.Size(202, 40);
            this.btnGrvKapat.TabIndex = 0;
            this.btnGrvKapat.Text = "KAPAT";
            this.btnGrvKapat.UseVisualStyleBackColor = true;
            this.btnGrvKapat.Click += new System.EventHandler(this.btnGrvKapat_Click);
            // 
            // btnGrvTemizle
            // 
            this.btnGrvTemizle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvTemizle.ForeColor = System.Drawing.Color.Red;
            this.btnGrvTemizle.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnGrvTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvTemizle.Location = new System.Drawing.Point(313, 5);
            this.btnGrvTemizle.Name = "btnGrvTemizle";
            this.btnGrvTemizle.Size = new System.Drawing.Size(278, 40);
            this.btnGrvTemizle.TabIndex = 2;
            this.btnGrvTemizle.Text = "TEMİZLE";
            this.btnGrvTemizle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(40, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 122;
            this.label4.Text = "Arama Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(805, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 120;
            this.label7.Text = "Saat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(802, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 119;
            this.label5.Text = "Tarih";
            // 
            // dtSaat
            // 
            this.dtSaat.Enabled = false;
            this.dtSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSaat.Location = new System.Drawing.Point(668, 199);
            this.dtSaat.Name = "dtSaat";
            this.dtSaat.ShowUpDown = true;
            this.dtSaat.Size = new System.Drawing.Size(63, 20);
            this.dtSaat.TabIndex = 118;
            // 
            // dtTarihGrv
            // 
            this.dtTarihGrv.Enabled = false;
            this.dtTarihGrv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarihGrv.Location = new System.Drawing.Point(572, 199);
            this.dtTarihGrv.Name = "dtTarihGrv";
            this.dtTarihGrv.Size = new System.Drawing.Size(89, 20);
            this.dtTarihGrv.TabIndex = 117;
            // 
            // btnSilGrvli
            // 
            this.btnSilGrvli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilGrvli.Location = new System.Drawing.Point(489, 365);
            this.btnSilGrvli.Name = "btnSilGrvli";
            this.btnSilGrvli.Size = new System.Drawing.Size(53, 23);
            this.btnSilGrvli.TabIndex = 116;
            this.btnSilGrvli.Text = "<<<";
            this.btnSilGrvli.UseVisualStyleBackColor = true;
            this.btnSilGrvli.Click += new System.EventHandler(this.btnSilGrvli_Click);
            // 
            // listBoxGorevlilerID
            // 
            this.listBoxGorevlilerID.FormattingEnabled = true;
            this.listBoxGorevlilerID.Location = new System.Drawing.Point(790, 303);
            this.listBoxGorevlilerID.Name = "listBoxGorevlilerID";
            this.listBoxGorevlilerID.Size = new System.Drawing.Size(51, 134);
            this.listBoxGorevlilerID.TabIndex = 115;
            this.listBoxGorevlilerID.Visible = false;
            // 
            // btnEkleGrvli
            // 
            this.btnEkleGrvli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleGrvli.Location = new System.Drawing.Point(489, 326);
            this.btnEkleGrvli.Name = "btnEkleGrvli";
            this.btnEkleGrvli.Size = new System.Drawing.Size(53, 23);
            this.btnEkleGrvli.TabIndex = 114;
            this.btnEkleGrvli.Text = ">>>";
            this.btnEkleGrvli.UseVisualStyleBackColor = true;
            this.btnEkleGrvli.Click += new System.EventHandler(this.btnEkleGrvli_Click);
            // 
            // listBoxGorevliler
            // 
            this.listBoxGorevliler.FormattingEnabled = true;
            this.listBoxGorevliler.Location = new System.Drawing.Point(572, 290);
            this.listBoxGorevliler.Name = "listBoxGorevliler";
            this.listBoxGorevliler.Size = new System.Drawing.Size(203, 147);
            this.listBoxGorevliler.TabIndex = 113;
            // 
            // txtGrvAra
            // 
            this.txtGrvAra.Location = new System.Drawing.Point(215, 236);
            this.txtGrvAra.Name = "txtGrvAra";
            this.txtGrvAra.Size = new System.Drawing.Size(246, 20);
            this.txtGrvAra.TabIndex = 112;
            this.txtGrvAra.Text = "Kategori Seçiniz..";
            this.txtGrvAra.TextChanged += new System.EventHandler(this.txtGrvAra_TextChanged);
            // 
            // dtgvGrvUye
            // 
            this.dtgvGrvUye.AllowUserToAddRows = false;
            this.dtgvGrvUye.AllowUserToDeleteRows = false;
            this.dtgvGrvUye.AllowUserToResizeColumns = false;
            this.dtgvGrvUye.AllowUserToResizeRows = false;
            this.dtgvGrvUye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGrvUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrvUye.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvGrvUye.Location = new System.Drawing.Point(43, 272);
            this.dtgvGrvUye.MultiSelect = false;
            this.dtgvGrvUye.Name = "dtgvGrvUye";
            this.dtgvGrvUye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGrvUye.Size = new System.Drawing.Size(371, 165);
            this.dtgvGrvUye.TabIndex = 111;
            this.dtgvGrvUye.SelectionChanged += new System.EventHandler(this.dtgvGrvUye_SelectionChanged);
            // 
            // txtGrvIcerik
            // 
            this.txtGrvIcerik.Location = new System.Drawing.Point(456, 67);
            this.txtGrvIcerik.Name = "txtGrvIcerik";
            this.txtGrvIcerik.Size = new System.Drawing.Size(300, 115);
            this.txtGrvIcerik.TabIndex = 110;
            this.txtGrvIcerik.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(644, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "Görevli Kişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(550, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Görev İçeriği";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(40, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "Görev Kategorisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(40, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "Görev Adı";
            // 
            // txtGrvAd
            // 
            this.txtGrvAd.Location = new System.Drawing.Point(182, 60);
            this.txtGrvAd.Name = "txtGrvAd";
            this.txtGrvAd.Size = new System.Drawing.Size(177, 20);
            this.txtGrvAd.TabIndex = 104;
            // 
            // cbGorevKate
            // 
            this.cbGorevKate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGorevKate.FormattingEnabled = true;
            this.cbGorevKate.Items.AddRange(new object[] {
            "SSİG 19",
            "Proje",
            "Diğer"});
            this.cbGorevKate.Location = new System.Drawing.Point(182, 114);
            this.cbGorevKate.Name = "cbGorevKate";
            this.cbGorevKate.Size = new System.Drawing.Size(177, 21);
            this.cbGorevKate.TabIndex = 123;
            this.cbGorevKate.SelectedIndexChanged += new System.EventHandler(this.cbGorevKate_SelectedIndexChanged);
            // 
            // cbGorevliArama
            // 
            this.cbGorevliArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGorevliArama.FormattingEnabled = true;
            this.cbGorevliArama.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "Öğrenci Numarası"});
            this.cbGorevliArama.Location = new System.Drawing.Point(47, 235);
            this.cbGorevliArama.Name = "cbGorevliArama";
            this.cbGorevliArama.Size = new System.Drawing.Size(121, 21);
            this.cbGorevliArama.TabIndex = 124;
            this.cbGorevliArama.SelectedIndexChanged += new System.EventHandler(this.cbGorevliArama_SelectedIndexChanged);
            // 
            // dtSaatSon
            // 
            this.dtSaatSon.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSaatSon.Location = new System.Drawing.Point(763, 147);
            this.dtSaatSon.Name = "dtSaatSon";
            this.dtSaatSon.ShowUpDown = true;
            this.dtSaatSon.Size = new System.Drawing.Size(126, 20);
            this.dtSaatSon.TabIndex = 126;
            // 
            // dtTarihSon
            // 
            this.dtTarihSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarihSon.Location = new System.Drawing.Point(763, 67);
            this.dtTarihSon.Name = "dtTarihSon";
            this.dtTarihSon.Size = new System.Drawing.Size(126, 20);
            this.dtTarihSon.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(422, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 127;
            this.label8.Text = "Görev  Kayıt Tarihi ";
            // 
            // yeniGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 515);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtSaatSon);
            this.Controls.Add(this.dtTarihSon);
            this.Controls.Add(this.cbGorevliArama);
            this.Controls.Add(this.cbGorevKate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtSaat);
            this.Controls.Add(this.dtTarihGrv);
            this.Controls.Add(this.btnSilGrvli);
            this.Controls.Add(this.listBoxGorevlilerID);
            this.Controls.Add(this.btnEkleGrvli);
            this.Controls.Add(this.listBoxGorevliler);
            this.Controls.Add(this.txtGrvAra);
            this.Controls.Add(this.dtgvGrvUye);
            this.Controls.Add(this.txtGrvIcerik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGrvAd);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(917, 554);
            this.Name = "yeniGorev";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Görev Ekranı";
            this.Load += new System.EventHandler(this.yeniGorev_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrvUye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrvKaydet;
        private System.Windows.Forms.Button btnGrvKapat;
        private System.Windows.Forms.Button btnGrvTemizle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtSaat;
        private System.Windows.Forms.DateTimePicker dtTarihGrv;
        private System.Windows.Forms.Button btnSilGrvli;
        private System.Windows.Forms.ListBox listBoxGorevlilerID;
        private System.Windows.Forms.Button btnEkleGrvli;
        private System.Windows.Forms.ListBox listBoxGorevliler;
        private System.Windows.Forms.TextBox txtGrvAra;
        private System.Windows.Forms.DataGridView dtgvGrvUye;
        private System.Windows.Forms.RichTextBox txtGrvIcerik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrvAd;
        private System.Windows.Forms.ComboBox cbGorevKate;
        private System.Windows.Forms.ComboBox cbGorevliArama;
        private System.Windows.Forms.DateTimePicker dtSaatSon;
        private System.Windows.Forms.DateTimePicker dtTarihSon;
        private System.Windows.Forms.Label label8;
    }
}