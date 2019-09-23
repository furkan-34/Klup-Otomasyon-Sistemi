namespace KARSAVOTOMASYON
{
    partial class Kayitlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayitlar));
            this.tabKayitlar = new System.Windows.Forms.TabControl();
            this.uyeListe = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUyeSayi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUyeArama = new System.Windows.Forms.TextBox();
            this.cbUyeArama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvUye = new System.Windows.Forms.DataGridView();
            this.panelUyeler = new System.Windows.Forms.Panel();
            this.btnUyeDuzenle = new System.Windows.Forms.Button();
            this.btnUyeYeni = new System.Windows.Forms.Button();
            this.btnUyeYenile = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.btnUyeKapat = new System.Windows.Forms.Button();
            this.gorevliListe = new System.Windows.Forms.TabPage();
            this.dtgvGrvli = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrvDuzenle = new System.Windows.Forms.Button();
            this.btnGrvYeni = new System.Windows.Forms.Button();
            this.btnGrvYenile = new System.Windows.Forms.Button();
            this.btnGrvSil = new System.Windows.Forms.Button();
            this.btnGrvKapa = new System.Windows.Forms.Button();
            this.referansListesi = new System.Windows.Forms.TabPage();
            this.dtgvRef = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRfrYeni = new System.Windows.Forms.Button();
            this.btnRfrYenile = new System.Windows.Forms.Button();
            this.btnRfrSil = new System.Windows.Forms.Button();
            this.btnRfrKapat = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabKayitlar.SuspendLayout();
            this.uyeListe.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUye)).BeginInit();
            this.panelUyeler.SuspendLayout();
            this.gorevliListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrvli)).BeginInit();
            this.panel2.SuspendLayout();
            this.referansListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRef)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKayitlar
            // 
            this.tabKayitlar.Controls.Add(this.uyeListe);
            this.tabKayitlar.Controls.Add(this.gorevliListe);
            this.tabKayitlar.Controls.Add(this.referansListesi);
            this.tabKayitlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKayitlar.ImageList = this.ımageList1;
            this.tabKayitlar.Location = new System.Drawing.Point(0, 0);
            this.tabKayitlar.Name = "tabKayitlar";
            this.tabKayitlar.SelectedIndex = 0;
            this.tabKayitlar.Size = new System.Drawing.Size(1048, 430);
            this.tabKayitlar.TabIndex = 0;
            // 
            // uyeListe
            // 
            this.uyeListe.Controls.Add(this.panel4);
            this.uyeListe.Controls.Add(this.dtgvUye);
            this.uyeListe.Controls.Add(this.panelUyeler);
            this.uyeListe.ImageIndex = 0;
            this.uyeListe.Location = new System.Drawing.Point(4, 23);
            this.uyeListe.Name = "uyeListe";
            this.uyeListe.Padding = new System.Windows.Forms.Padding(3);
            this.uyeListe.Size = new System.Drawing.Size(1040, 403);
            this.uyeListe.TabIndex = 0;
            this.uyeListe.Text = "Üye Listesi";
            this.uyeListe.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lblUyeSayi);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtUyeArama);
            this.panel4.Controls.Add(this.cbUyeArama);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 40);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KARSAVOTOMASYON.Properties.Resources.flag_400__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(963, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 26);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KARSAVOTOMASYON.Properties.Resources.flag_400__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(924, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KARSAVOTOMASYON.Properties.Resources.flag_400__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(1002, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 26);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lblUyeSayi
            // 
            this.lblUyeSayi.AutoSize = true;
            this.lblUyeSayi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeSayi.ForeColor = System.Drawing.Color.Blue;
            this.lblUyeSayi.Location = new System.Drawing.Point(876, 12);
            this.lblUyeSayi.Name = "lblUyeSayi";
            this.lblUyeSayi.Size = new System.Drawing.Size(0, 16);
            this.lblUyeSayi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(770, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ÜYE SAYISI :";
            // 
            // txtUyeArama
            // 
            this.txtUyeArama.Location = new System.Drawing.Point(380, 8);
            this.txtUyeArama.Name = "txtUyeArama";
            this.txtUyeArama.Size = new System.Drawing.Size(366, 20);
            this.txtUyeArama.TabIndex = 7;
            this.txtUyeArama.TextChanged += new System.EventHandler(this.txtUyeArama_TextChanged_1);
            // 
            // cbUyeArama
            // 
            this.cbUyeArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUyeArama.FormattingEnabled = true;
            this.cbUyeArama.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "Bölüm"});
            this.cbUyeArama.Location = new System.Drawing.Point(173, 8);
            this.cbUyeArama.Name = "cbUyeArama";
            this.cbUyeArama.Size = new System.Drawing.Size(172, 21);
            this.cbUyeArama.TabIndex = 6;
            this.cbUyeArama.SelectedIndexChanged += new System.EventHandler(this.cbUyeArama_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aranacak Kategori";
            // 
            // dtgvUye
            // 
            this.dtgvUye.AllowUserToAddRows = false;
            this.dtgvUye.AllowUserToDeleteRows = false;
            this.dtgvUye.AllowUserToOrderColumns = true;
            this.dtgvUye.AllowUserToResizeColumns = false;
            this.dtgvUye.AllowUserToResizeRows = false;
            this.dtgvUye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvUye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUye.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvUye.Location = new System.Drawing.Point(0, 49);
            this.dtgvUye.Name = "dtgvUye";
            this.dtgvUye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUye.Size = new System.Drawing.Size(1062, 301);
            this.dtgvUye.TabIndex = 3;
            // 
            // panelUyeler
            // 
            this.panelUyeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelUyeler.Controls.Add(this.btnUyeDuzenle);
            this.panelUyeler.Controls.Add(this.btnUyeYeni);
            this.panelUyeler.Controls.Add(this.btnUyeYenile);
            this.panelUyeler.Controls.Add(this.btnUyeSil);
            this.panelUyeler.Controls.Add(this.btnUyeKapat);
            this.panelUyeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUyeler.Location = new System.Drawing.Point(3, 346);
            this.panelUyeler.Name = "panelUyeler";
            this.panelUyeler.Size = new System.Drawing.Size(1034, 54);
            this.panelUyeler.TabIndex = 2;
            // 
            // btnUyeDuzenle
            // 
            this.btnUyeDuzenle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUyeDuzenle.ForeColor = System.Drawing.Color.Red;
            this.btnUyeDuzenle.Image = global::KARSAVOTOMASYON.Properties.Resources.UpdateListItem_32x;
            this.btnUyeDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeDuzenle.Location = new System.Drawing.Point(243, 6);
            this.btnUyeDuzenle.Name = "btnUyeDuzenle";
            this.btnUyeDuzenle.Size = new System.Drawing.Size(194, 40);
            this.btnUyeDuzenle.TabIndex = 4;
            this.btnUyeDuzenle.Text = "DÜZENLE";
            this.btnUyeDuzenle.UseVisualStyleBackColor = true;
            this.btnUyeDuzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUyeYeni
            // 
            this.btnUyeYeni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUyeYeni.ForeColor = System.Drawing.Color.Red;
            this.btnUyeYeni.Image = global::KARSAVOTOMASYON.Properties.Resources._112_Plus_Blue_16x16_72;
            this.btnUyeYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeYeni.Location = new System.Drawing.Point(858, 6);
            this.btnUyeYeni.Name = "btnUyeYeni";
            this.btnUyeYeni.Size = new System.Drawing.Size(177, 40);
            this.btnUyeYeni.TabIndex = 3;
            this.btnUyeYeni.Text = "YENİ KAYIT";
            this.btnUyeYeni.UseVisualStyleBackColor = true;
            this.btnUyeYeni.Click += new System.EventHandler(this.btnUyeYeni_Click);
            // 
            // btnUyeYenile
            // 
            this.btnUyeYenile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUyeYenile.ForeColor = System.Drawing.Color.Red;
            this.btnUyeYenile.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnUyeYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeYenile.Location = new System.Drawing.Point(653, 6);
            this.btnUyeYenile.Name = "btnUyeYenile";
            this.btnUyeYenile.Size = new System.Drawing.Size(194, 40);
            this.btnUyeYenile.TabIndex = 2;
            this.btnUyeYenile.Text = "YENİLE";
            this.btnUyeYenile.UseVisualStyleBackColor = true;
            this.btnUyeYenile.Click += new System.EventHandler(this.btnUyeYenile_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUyeSil.ForeColor = System.Drawing.Color.Red;
            this.btnUyeSil.Image = global::KARSAVOTOMASYON.Properties.Resources.cop_orji___Kopya;
            this.btnUyeSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeSil.Location = new System.Drawing.Point(448, 6);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(194, 40);
            this.btnUyeSil.TabIndex = 1;
            this.btnUyeSil.Text = "SİL";
            this.btnUyeSil.UseVisualStyleBackColor = true;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // btnUyeKapat
            // 
            this.btnUyeKapat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUyeKapat.ForeColor = System.Drawing.Color.Red;
            this.btnUyeKapat.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnUyeKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeKapat.Location = new System.Drawing.Point(12, 5);
            this.btnUyeKapat.Name = "btnUyeKapat";
            this.btnUyeKapat.Size = new System.Drawing.Size(161, 40);
            this.btnUyeKapat.TabIndex = 0;
            this.btnUyeKapat.Text = "KAPAT";
            this.btnUyeKapat.UseVisualStyleBackColor = true;
            this.btnUyeKapat.Click += new System.EventHandler(this.btnUyeKapat_Click);
            // 
            // gorevliListe
            // 
            this.gorevliListe.Controls.Add(this.dtgvGrvli);
            this.gorevliListe.Controls.Add(this.panel2);
            this.gorevliListe.ImageIndex = 1;
            this.gorevliListe.Location = new System.Drawing.Point(4, 23);
            this.gorevliListe.Name = "gorevliListe";
            this.gorevliListe.Padding = new System.Windows.Forms.Padding(3);
            this.gorevliListe.Size = new System.Drawing.Size(1040, 403);
            this.gorevliListe.TabIndex = 1;
            this.gorevliListe.Text = "Görevli Listesi";
            this.gorevliListe.UseVisualStyleBackColor = true;
            // 
            // dtgvGrvli
            // 
            this.dtgvGrvli.AllowUserToAddRows = false;
            this.dtgvGrvli.AllowUserToDeleteRows = false;
            this.dtgvGrvli.AllowUserToResizeColumns = false;
            this.dtgvGrvli.AllowUserToResizeRows = false;
            this.dtgvGrvli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGrvli.BackgroundColor = System.Drawing.Color.White;
            this.dtgvGrvli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrvli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvGrvli.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvGrvli.Location = new System.Drawing.Point(3, 3);
            this.dtgvGrvli.MultiSelect = false;
            this.dtgvGrvli.Name = "dtgvGrvli";
            this.dtgvGrvli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGrvli.Size = new System.Drawing.Size(1034, 343);
            this.dtgvGrvli.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnGrvDuzenle);
            this.panel2.Controls.Add(this.btnGrvYeni);
            this.panel2.Controls.Add(this.btnGrvYenile);
            this.panel2.Controls.Add(this.btnGrvSil);
            this.panel2.Controls.Add(this.btnGrvKapa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 54);
            this.panel2.TabIndex = 3;
            // 
            // btnGrvDuzenle
            // 
            this.btnGrvDuzenle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvDuzenle.ForeColor = System.Drawing.Color.Red;
            this.btnGrvDuzenle.Image = global::KARSAVOTOMASYON.Properties.Resources.UpdateListItem_32x;
            this.btnGrvDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvDuzenle.Location = new System.Drawing.Point(243, 6);
            this.btnGrvDuzenle.Name = "btnGrvDuzenle";
            this.btnGrvDuzenle.Size = new System.Drawing.Size(199, 40);
            this.btnGrvDuzenle.TabIndex = 5;
            this.btnGrvDuzenle.Text = "DÜZENLE";
            this.btnGrvDuzenle.UseVisualStyleBackColor = true;
            this.btnGrvDuzenle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGrvYeni
            // 
            this.btnGrvYeni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvYeni.ForeColor = System.Drawing.Color.Red;
            this.btnGrvYeni.Image = global::KARSAVOTOMASYON.Properties.Resources._112_Plus_Blue_16x16_72;
            this.btnGrvYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvYeni.Location = new System.Drawing.Point(858, 6);
            this.btnGrvYeni.Name = "btnGrvYeni";
            this.btnGrvYeni.Size = new System.Drawing.Size(199, 40);
            this.btnGrvYeni.TabIndex = 3;
            this.btnGrvYeni.Text = "YENİ KAYIT";
            this.btnGrvYeni.UseVisualStyleBackColor = true;
            this.btnGrvYeni.Click += new System.EventHandler(this.btnGrvYeni_Click);
            // 
            // btnGrvYenile
            // 
            this.btnGrvYenile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvYenile.ForeColor = System.Drawing.Color.Red;
            this.btnGrvYenile.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnGrvYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvYenile.Location = new System.Drawing.Point(653, 6);
            this.btnGrvYenile.Name = "btnGrvYenile";
            this.btnGrvYenile.Size = new System.Drawing.Size(199, 40);
            this.btnGrvYenile.TabIndex = 2;
            this.btnGrvYenile.Text = "YENİLE";
            this.btnGrvYenile.UseVisualStyleBackColor = true;
            this.btnGrvYenile.Click += new System.EventHandler(this.btnGrvYenile_Click);
            // 
            // btnGrvSil
            // 
            this.btnGrvSil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvSil.ForeColor = System.Drawing.Color.Red;
            this.btnGrvSil.Image = global::KARSAVOTOMASYON.Properties.Resources.cop_orji___Kopya;
            this.btnGrvSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvSil.Location = new System.Drawing.Point(448, 6);
            this.btnGrvSil.Name = "btnGrvSil";
            this.btnGrvSil.Size = new System.Drawing.Size(199, 40);
            this.btnGrvSil.TabIndex = 1;
            this.btnGrvSil.Text = "SİL";
            this.btnGrvSil.UseVisualStyleBackColor = true;
            this.btnGrvSil.Click += new System.EventHandler(this.btnGrvSil_Click);
            // 
            // btnGrvKapa
            // 
            this.btnGrvKapa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrvKapa.ForeColor = System.Drawing.Color.Red;
            this.btnGrvKapa.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnGrvKapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrvKapa.Location = new System.Drawing.Point(12, 5);
            this.btnGrvKapa.Name = "btnGrvKapa";
            this.btnGrvKapa.Size = new System.Drawing.Size(166, 40);
            this.btnGrvKapa.TabIndex = 0;
            this.btnGrvKapa.Text = "KAPAT";
            this.btnGrvKapa.UseVisualStyleBackColor = true;
            this.btnGrvKapa.Click += new System.EventHandler(this.btnGrvKapa_Click);
            // 
            // referansListesi
            // 
            this.referansListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.referansListesi.Controls.Add(this.dtgvRef);
            this.referansListesi.Controls.Add(this.panel3);
            this.referansListesi.ImageIndex = 4;
            this.referansListesi.Location = new System.Drawing.Point(4, 23);
            this.referansListesi.Name = "referansListesi";
            this.referansListesi.Padding = new System.Windows.Forms.Padding(3);
            this.referansListesi.Size = new System.Drawing.Size(1044, 407);
            this.referansListesi.TabIndex = 2;
            this.referansListesi.Text = "Referanslar";
            this.referansListesi.UseVisualStyleBackColor = true;
            // 
            // dtgvRef
            // 
            this.dtgvRef.AllowUserToAddRows = false;
            this.dtgvRef.AllowUserToDeleteRows = false;
            this.dtgvRef.AllowUserToResizeColumns = false;
            this.dtgvRef.AllowUserToResizeRows = false;
            this.dtgvRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRef.BackgroundColor = System.Drawing.Color.White;
            this.dtgvRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvRef.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvRef.Location = new System.Drawing.Point(3, 3);
            this.dtgvRef.Name = "dtgvRef";
            this.dtgvRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRef.Size = new System.Drawing.Size(1038, 347);
            this.dtgvRef.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btnRfrYeni);
            this.panel3.Controls.Add(this.btnRfrYenile);
            this.panel3.Controls.Add(this.btnRfrSil);
            this.panel3.Controls.Add(this.btnRfrKapat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 54);
            this.panel3.TabIndex = 3;
            // 
            // btnRfrYeni
            // 
            this.btnRfrYeni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRfrYeni.ForeColor = System.Drawing.Color.Red;
            this.btnRfrYeni.Image = global::KARSAVOTOMASYON.Properties.Resources._112_Plus_Blue_16x16_72;
            this.btnRfrYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRfrYeni.Location = new System.Drawing.Point(749, 5);
            this.btnRfrYeni.Name = "btnRfrYeni";
            this.btnRfrYeni.Size = new System.Drawing.Size(199, 40);
            this.btnRfrYeni.TabIndex = 3;
            this.btnRfrYeni.Text = "YENİ KAYIT";
            this.btnRfrYeni.UseVisualStyleBackColor = true;
            this.btnRfrYeni.Click += new System.EventHandler(this.btnRfrYeni_Click);
            // 
            // btnRfrYenile
            // 
            this.btnRfrYenile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRfrYenile.ForeColor = System.Drawing.Color.Red;
            this.btnRfrYenile.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnRfrYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRfrYenile.Location = new System.Drawing.Point(544, 5);
            this.btnRfrYenile.Name = "btnRfrYenile";
            this.btnRfrYenile.Size = new System.Drawing.Size(199, 40);
            this.btnRfrYenile.TabIndex = 2;
            this.btnRfrYenile.Text = "YENİLE";
            this.btnRfrYenile.UseVisualStyleBackColor = true;
            this.btnRfrYenile.Click += new System.EventHandler(this.btnRfrYenile_Click);
            // 
            // btnRfrSil
            // 
            this.btnRfrSil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRfrSil.ForeColor = System.Drawing.Color.Red;
            this.btnRfrSil.Image = global::KARSAVOTOMASYON.Properties.Resources.cop_orji___Kopya;
            this.btnRfrSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRfrSil.Location = new System.Drawing.Point(339, 5);
            this.btnRfrSil.Name = "btnRfrSil";
            this.btnRfrSil.Size = new System.Drawing.Size(199, 40);
            this.btnRfrSil.TabIndex = 1;
            this.btnRfrSil.Text = "SİL";
            this.btnRfrSil.UseVisualStyleBackColor = true;
            this.btnRfrSil.Click += new System.EventHandler(this.btnRfrSil_Click);
            // 
            // btnRfrKapat
            // 
            this.btnRfrKapat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRfrKapat.ForeColor = System.Drawing.Color.Red;
            this.btnRfrKapat.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnRfrKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRfrKapat.Location = new System.Drawing.Point(12, 5);
            this.btnRfrKapat.Name = "btnRfrKapat";
            this.btnRfrKapat.Size = new System.Drawing.Size(166, 40);
            this.btnRfrKapat.TabIndex = 0;
            this.btnRfrKapat.Text = "KAPAT";
            this.btnRfrKapat.UseVisualStyleBackColor = true;
            this.btnRfrKapat.Click += new System.EventHandler(this.btnRfrKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "memberorgi.png");
            this.ımageList1.Images.SetKeyName(1, "person111.png");
            this.ımageList1.Images.SetKeyName(2, "conference.png");
            this.ımageList1.Images.SetKeyName(3, "basic1-110_star_favorite-512.png");
            this.ımageList1.Images.SetKeyName(4, "star.png");
            // 
            // Kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 430);
            this.ControlBox = false;
            this.Controls.Add(this.tabKayitlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1080, 485);
            this.Name = "Kayitlar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıtlar";
            this.Load += new System.EventHandler(this.Kayitlar_Load);
            this.tabKayitlar.ResumeLayout(false);
            this.uyeListe.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUye)).EndInit();
            this.panelUyeler.ResumeLayout(false);
            this.gorevliListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrvli)).EndInit();
            this.panel2.ResumeLayout(false);
            this.referansListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRef)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKayitlar;
        private System.Windows.Forms.TabPage uyeListe;
        private System.Windows.Forms.TabPage gorevliListe;
        private System.Windows.Forms.Panel panelUyeler;
        private System.Windows.Forms.Button btnUyeYeni;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Button btnUyeKapat;
        private System.Windows.Forms.TabPage referansListesi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRfrYeni;
        private System.Windows.Forms.Button btnRfrYenile;
        private System.Windows.Forms.Button btnRfrSil;
        private System.Windows.Forms.Button btnRfrKapat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button btnUyeYenile;
        private System.Windows.Forms.Button btnUyeDuzenle;
        public System.Windows.Forms.DataGridView dtgvUye;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUyeArama;
        private System.Windows.Forms.ComboBox cbUyeArama;
        private System.Windows.Forms.DataGridView dtgvGrvli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGrvYeni;
        private System.Windows.Forms.Button btnGrvYenile;
        private System.Windows.Forms.Button btnGrvSil;
        private System.Windows.Forms.Button btnGrvKapa;
        private System.Windows.Forms.Button btnGrvDuzenle;
        private System.Windows.Forms.DataGridView dtgvRef;
        public System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lblUyeSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}