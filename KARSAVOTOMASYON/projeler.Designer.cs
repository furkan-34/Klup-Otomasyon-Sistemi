namespace KARSAVOTOMASYON
{
    partial class projeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projeler));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelUyeler = new System.Windows.Forms.Panel();
            this.btnPrjDuzenle = new System.Windows.Forms.Button();
            this.btnPrjYeni = new System.Windows.Forms.Button();
            this.btnPrjYenile = new System.Windows.Forms.Button();
            this.btnPrjSil = new System.Windows.Forms.Button();
            this.btnPrjKapat = new System.Windows.Forms.Button();
            this.dtgvProjeler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrjUyeYenile = new System.Windows.Forms.Button();
            this.btnPrjUyelerKpt = new System.Windows.Forms.Button();
            this.dtgvPrjUyeList = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrjUye = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrjAcik = new System.Windows.Forms.RichTextBox();
            this.lblPrjAd = new System.Windows.Forms.Label();
            this.lblPrjAdmin = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelUyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProjeler)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrjUyeList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1210, 538);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panelUyeler);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1202, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Projeler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelUyeler
            // 
            this.panelUyeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelUyeler.Controls.Add(this.btnPrjDuzenle);
            this.panelUyeler.Controls.Add(this.btnPrjYeni);
            this.panelUyeler.Controls.Add(this.btnPrjYenile);
            this.panelUyeler.Controls.Add(this.btnPrjSil);
            this.panelUyeler.Controls.Add(this.btnPrjKapat);
            this.panelUyeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUyeler.Location = new System.Drawing.Point(3, 454);
            this.panelUyeler.Name = "panelUyeler";
            this.panelUyeler.Size = new System.Drawing.Size(1196, 54);
            this.panelUyeler.TabIndex = 6;
            // 
            // btnPrjDuzenle
            // 
            this.btnPrjDuzenle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrjDuzenle.ForeColor = System.Drawing.Color.Red;
            this.btnPrjDuzenle.Image = global::KARSAVOTOMASYON.Properties.Resources.UpdateListItem_32x;
            this.btnPrjDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrjDuzenle.Location = new System.Drawing.Point(243, 6);
            this.btnPrjDuzenle.Name = "btnPrjDuzenle";
            this.btnPrjDuzenle.Size = new System.Drawing.Size(199, 40);
            this.btnPrjDuzenle.TabIndex = 4;
            this.btnPrjDuzenle.Text = "DÜZENLE";
            this.btnPrjDuzenle.UseVisualStyleBackColor = true;
            this.btnPrjDuzenle.Click += new System.EventHandler(this.btnPrjDuzenle_Click);
            // 
            // btnPrjYeni
            // 
            this.btnPrjYeni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrjYeni.ForeColor = System.Drawing.Color.Red;
            this.btnPrjYeni.Image = global::KARSAVOTOMASYON.Properties.Resources._112_Plus_Blue_16x16_72;
            this.btnPrjYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrjYeni.Location = new System.Drawing.Point(862, 6);
            this.btnPrjYeni.Name = "btnPrjYeni";
            this.btnPrjYeni.Size = new System.Drawing.Size(199, 40);
            this.btnPrjYeni.TabIndex = 3;
            this.btnPrjYeni.Text = "YENİ KAYIT";
            this.btnPrjYeni.UseVisualStyleBackColor = true;
            this.btnPrjYeni.Click += new System.EventHandler(this.btnPrjYeni_Click_1);
            // 
            // btnPrjYenile
            // 
            this.btnPrjYenile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrjYenile.ForeColor = System.Drawing.Color.Red;
            this.btnPrjYenile.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnPrjYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrjYenile.Location = new System.Drawing.Point(653, 6);
            this.btnPrjYenile.Name = "btnPrjYenile";
            this.btnPrjYenile.Size = new System.Drawing.Size(199, 40);
            this.btnPrjYenile.TabIndex = 2;
            this.btnPrjYenile.Text = "YENİLE";
            this.btnPrjYenile.UseVisualStyleBackColor = true;
            this.btnPrjYenile.Click += new System.EventHandler(this.btnPrjYenile_Click_1);
            // 
            // btnPrjSil
            // 
            this.btnPrjSil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrjSil.ForeColor = System.Drawing.Color.Red;
            this.btnPrjSil.Image = global::KARSAVOTOMASYON.Properties.Resources.cop_orji___Kopya;
            this.btnPrjSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrjSil.Location = new System.Drawing.Point(448, 6);
            this.btnPrjSil.Name = "btnPrjSil";
            this.btnPrjSil.Size = new System.Drawing.Size(199, 40);
            this.btnPrjSil.TabIndex = 1;
            this.btnPrjSil.Text = "SİL";
            this.btnPrjSil.UseVisualStyleBackColor = true;
            this.btnPrjSil.Click += new System.EventHandler(this.btnPrjSil_Click);
            // 
            // btnPrjKapat
            // 
            this.btnPrjKapat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrjKapat.ForeColor = System.Drawing.Color.Red;
            this.btnPrjKapat.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnPrjKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrjKapat.Location = new System.Drawing.Point(12, 5);
            this.btnPrjKapat.Name = "btnPrjKapat";
            this.btnPrjKapat.Size = new System.Drawing.Size(166, 40);
            this.btnPrjKapat.TabIndex = 0;
            this.btnPrjKapat.Text = "KAPAT";
            this.btnPrjKapat.UseVisualStyleBackColor = true;
            this.btnPrjKapat.Click += new System.EventHandler(this.btnPrjKapat_Click_1);
            // 
            // dtgvProjeler
            // 
            this.dtgvProjeler.AllowUserToAddRows = false;
            this.dtgvProjeler.AllowUserToDeleteRows = false;
            this.dtgvProjeler.AllowUserToResizeColumns = false;
            this.dtgvProjeler.AllowUserToResizeRows = false;
            this.dtgvProjeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProjeler.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProjeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProjeler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvProjeler.Location = new System.Drawing.Point(0, 0);
            this.dtgvProjeler.Name = "dtgvProjeler";
            this.dtgvProjeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProjeler.Size = new System.Drawing.Size(1206, 225);
            this.dtgvProjeler.TabIndex = 5;
            this.dtgvProjeler.SelectionChanged += new System.EventHandler(this.dtgvProjeler_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dtgvPrjUyeList);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1202, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Projelerde Görevli Üyeler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnPrjUyeYenile);
            this.panel1.Controls.Add(this.btnPrjUyelerKpt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 54);
            this.panel1.TabIndex = 7;
            // 
            // btnPrjUyeYenile
            // 
            this.btnPrjUyeYenile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrjUyeYenile.ForeColor = System.Drawing.Color.Red;
            this.btnPrjUyeYenile.Image = global::KARSAVOTOMASYON.Properties.Resources.refresh_16xLG;
            this.btnPrjUyeYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrjUyeYenile.Location = new System.Drawing.Point(653, 6);
            this.btnPrjUyeYenile.Name = "btnPrjUyeYenile";
            this.btnPrjUyeYenile.Size = new System.Drawing.Size(199, 40);
            this.btnPrjUyeYenile.TabIndex = 2;
            this.btnPrjUyeYenile.Text = "YENİLE";
            this.btnPrjUyeYenile.UseVisualStyleBackColor = true;
            this.btnPrjUyeYenile.Click += new System.EventHandler(this.btnPrjUyeYenile_Click);
            // 
            // btnPrjUyelerKpt
            // 
            this.btnPrjUyelerKpt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrjUyelerKpt.ForeColor = System.Drawing.Color.Red;
            this.btnPrjUyelerKpt.Image = global::KARSAVOTOMASYON.Properties.Resources.Exit_16x;
            this.btnPrjUyelerKpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrjUyelerKpt.Location = new System.Drawing.Point(12, 5);
            this.btnPrjUyelerKpt.Name = "btnPrjUyelerKpt";
            this.btnPrjUyelerKpt.Size = new System.Drawing.Size(166, 40);
            this.btnPrjUyelerKpt.TabIndex = 0;
            this.btnPrjUyelerKpt.Text = "KAPAT";
            this.btnPrjUyelerKpt.UseVisualStyleBackColor = true;
            this.btnPrjUyelerKpt.Click += new System.EventHandler(this.btnPrjUyelerKpt_Click);
            // 
            // dtgvPrjUyeList
            // 
            this.dtgvPrjUyeList.AllowUserToAddRows = false;
            this.dtgvPrjUyeList.AllowUserToDeleteRows = false;
            this.dtgvPrjUyeList.AllowUserToResizeColumns = false;
            this.dtgvPrjUyeList.AllowUserToResizeRows = false;
            this.dtgvPrjUyeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPrjUyeList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvPrjUyeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrjUyeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPrjUyeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvPrjUyeList.Location = new System.Drawing.Point(3, 3);
            this.dtgvPrjUyeList.Name = "dtgvPrjUyeList";
            this.dtgvPrjUyeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPrjUyeList.Size = new System.Drawing.Size(1196, 505);
            this.dtgvPrjUyeList.TabIndex = 6;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "memberorgi.png");
            this.ımageList1.Images.SetKeyName(1, "lightningBolt_16xLG.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvProjeler);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 225);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lblPrjAdmin);
            this.panel3.Controls.Add(this.lblPrjAd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPrjAcik);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtPrjUye);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1202, 228);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(889, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "PROJE ÜYELERİ";
            // 
            // txtPrjUye
            // 
            this.txtPrjUye.Location = new System.Drawing.Point(857, 35);
            this.txtPrjUye.Name = "txtPrjUye";
            this.txtPrjUye.Size = new System.Drawing.Size(199, 189);
            this.txtPrjUye.TabIndex = 20;
            this.txtPrjUye.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "PROJE YÖNETİCİSİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "PROJE ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(539, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "PROJE AÇIKLAMASI";
            // 
            // txtPrjAcik
            // 
            this.txtPrjAcik.Location = new System.Drawing.Point(502, 35);
            this.txtPrjAcik.Name = "txtPrjAcik";
            this.txtPrjAcik.Size = new System.Drawing.Size(247, 189);
            this.txtPrjAcik.TabIndex = 24;
            this.txtPrjAcik.Text = "";
            // 
            // lblPrjAd
            // 
            this.lblPrjAd.AutoSize = true;
            this.lblPrjAd.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPrjAd.ForeColor = System.Drawing.Color.Red;
            this.lblPrjAd.Location = new System.Drawing.Point(166, 13);
            this.lblPrjAd.Name = "lblPrjAd";
            this.lblPrjAd.Size = new System.Drawing.Size(0, 16);
            this.lblPrjAd.TabIndex = 26;
            // 
            // lblPrjAdmin
            // 
            this.lblPrjAdmin.AutoSize = true;
            this.lblPrjAdmin.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPrjAdmin.ForeColor = System.Drawing.Color.Blue;
            this.lblPrjAdmin.Location = new System.Drawing.Point(166, 128);
            this.lblPrjAdmin.Name = "lblPrjAdmin";
            this.lblPrjAdmin.Size = new System.Drawing.Size(0, 16);
            this.lblPrjAdmin.TabIndex = 27;
            // 
            // projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 538);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1226, 577);
            this.MinimizeBox = false;
            this.Name = "projeler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.projeler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelUyeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProjeler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrjUyeList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvProjeler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvPrjUyeList;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panelUyeler;
        private System.Windows.Forms.Button btnPrjDuzenle;
        private System.Windows.Forms.Button btnPrjYeni;
        public System.Windows.Forms.Button btnPrjYenile;
        private System.Windows.Forms.Button btnPrjSil;
        private System.Windows.Forms.Button btnPrjKapat;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnPrjUyeYenile;
        private System.Windows.Forms.Button btnPrjUyelerKpt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtPrjUye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtPrjAcik;
        private System.Windows.Forms.Label lblPrjAdmin;
        private System.Windows.Forms.Label lblPrjAd;
    }
}