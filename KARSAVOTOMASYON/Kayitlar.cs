using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KARSAVOTOMASYON
{
    public partial class Kayitlar : Form
    {
        public Kayitlar()
        {
            InitializeComponent();
        }

        dbEngine db = new dbEngine();
        public static string sID,sAd,sSoyad,sBolum,sTel,sMail,sOgNo,sHava,sKara,sDeniz,sSiber,sAciklama;
        public static string sPozisyon, yetKgor, yetUgor, yetUk, yetGg, yetGk, sKul, sSifre;
        string uyeK;
        public static string uyeGor, uyeKay, grvGor, grvKay, refGor, refKay;


        public static int btnduzen = 0;

        DataTable dtGrv = new DataTable();
       DataTable dtUye = new DataTable();
        DataTable dtRfr = new DataTable();

        private void btnGrvYenile_Click(object sender, EventArgs e)
        {
            try
            {

                dtgvGrvli.DataSource = db.grvListeleme();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void btnGrvSil_Click(object sender, EventArgs e)
        {
            grvSil();
        }

        private void btnRfrYeni_Click(object sender, EventArgs e)
        {
            yeniReferans yr = new yeniReferans();
            yr.ShowDialog();
        }

        private void btnRfrYenile_Click(object sender, EventArgs e)
        {
            try
            {

                dtgvRef.DataSource = db.rfrListeleme();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void cbUyeArama_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
        }

        private void btnRfrSil_Click(object sender, EventArgs e)
        {
            rfrSil();
        }

        private void btnGrvYeni_Click(object sender, EventArgs e)
        {
            btnduzen = 0;

            yeniGorevli ac = new yeniGorevli();
            ac.ShowDialog();
        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbUyeArama_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            txtUyeArama.Enabled = true;

            if (cbUyeArama.SelectedItem == "ID")
            {
                uyeK = "ID";
            }


            if (cbUyeArama.SelectedItem == "Ad")
            {
                uyeK = "Ad";
            }


            if (cbUyeArama.SelectedItem == "Soyad")
            {
                uyeK = "Soyad";
            }


            if (cbUyeArama.SelectedItem == "Bölüm")
            {
                uyeK = "Bölüm";
            }
        }


        // GÖREVLİ DÜZENLEME BUTONU ---------------------------------------

        private void button1_Click_1(object sender, EventArgs e)
        {
            duzenleGrv();
        }

        private void txtUyeArama_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                DataTable dtUyeA = db.uyeListeleme();
                dtgvUye.DataSource = dtUyeA;

                if (uyeK == "Ad")
                {

                    dtUyeA.DefaultView.RowFilter = string.Format("Isim LIKE '%{0}%'", txtUyeArama.Text);
                }

                if (uyeK == "Soyad")
                {
                    dtUyeA.DefaultView.RowFilter = string.Format("Soyisim LIKE '%{0}%'", txtUyeArama.Text);
                }

                if (uyeK == "Bölüm")
                {

                    dtUyeA.DefaultView.RowFilter = string.Format("Bolum LIKE '%{0}%'", txtUyeArama.Text);
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

           


           

        }


        private void btnRfrKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGrvKapa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUyeKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Kayitlar_Load(object sender, EventArgs e)
        {
           

            //yetkiKontrol();
            if (uyeGor== "var")
            {
                dtgvUye.Visible = true;
            }
            else
            {
                dtgvUye.Visible = false;
            }
            //---------------------------
            if (uyeKay == "var")
            {
                btnUyeSil.Enabled = true;
                btnUyeDuzenle.Enabled = true;
                btnUyeYeni.Enabled = true;
            }
            else
            {
                btnUyeSil.Enabled = false;
                btnUyeDuzenle.Enabled = false;
                btnUyeYeni.Enabled = false;
            }
            //---------------------------


            if (grvGor == "var")
            {
                dtgvGrvli.Visible = true;
            }
            else
            {
                dtgvGrvli.Visible = false;
            }
            //---------------------------
            if (grvKay == "var")
            {
                btnGrvSil.Enabled = true;
                btnGrvDuzenle.Enabled = true;
                btnGrvYeni.Enabled = true;
            }
            else
            {
                btnGrvSil.Enabled = false;
                btnGrvDuzenle.Enabled = false;
                btnGrvYeni.Enabled = false;
            }
            //---------------------------


            if (refGor == "var")
            {
                dtgvRef.Visible = true;
            }
            else
            {
                dtgvRef.Visible = false;
            }
            //---------------------------
            if (refKay == "var")
            {
                btnRfrSil.Enabled = true;
                btnRfrYeni.Enabled = true;
                
            }
            else
            {
                btnRfrSil.Enabled = false;
                btnRfrYeni.Enabled = false;
            }
            //---------------------------

            txtUyeArama.Enabled = false;
            

            try
            {
               dtUye = db.uyeListeleme();
                dtGrv = db.grvListeleme();
                dtRfr = db.rfrListeleme();

                dtgvUye.DataSource = dtUye;
                dtgvGrvli.DataSource = dtGrv;
                dtgvRef.DataSource = dtRfr;

                if (AnaForm.Pozisyon == "Başkan Yardımcısı")
                {
                    this.dtgvGrvli.Columns["KullaniciAd"].Visible = false;
                    this.dtgvGrvli.Columns["Sifre"].Visible = false;
                    this.dtgvGrvli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {
                    for (int i = 4; i < 24; i++)
                    {
                        this.dtgvGrvli.Columns[i].Visible = false;
                    }
                }
                

                


                lblUyeSayi.Text = dtgvUye.Rows.Count.ToString();



            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

            
        }
       

        private void btnUyeYeni_Click(object sender, EventArgs e)
        {
            btnduzen = 0;
            yeniUye ac = new yeniUye();
            ac.ShowDialog();
        }

        private void btnUyeYenile_Click(object sender, EventArgs e)
        {
            try
            {

                dtgvUye.DataSource = db.uyeListeleme();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void txtUyeArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                dtUye = db.uyeListeleme();
                dtgvUye.DataSource = dtUye;


            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }


        
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {


            uSil();
            

           
        }




        // ÜYE DÜZENLEME BUTONU ----------------------------------

        private void button1_Click(object sender, EventArgs e)
        {

            duzenleUye();


        }

        // YETKİLENDİRME KONTROLLERİ ---------------------------------------------
        void yetkiKontrol()
        {


            if (uyeGor == "var")
            {
                dtgvUye.Visible = true;
                btnUyeYenile.Enabled = true;
                cbUyeArama.Enabled = true;
            }
            else
            {
                dtgvUye.Visible = false;
                btnUyeYenile.Enabled = false;
                cbUyeArama.Enabled = false;
            }

            if (uyeKay == "var")
            {
                btnUyeYeni.Enabled = true;
                btnUyeSil.Enabled = true;
                btnUyeDuzenle.Enabled = true;


            }
            else
            {
                btnUyeYeni.Enabled = false;
                btnUyeSil.Enabled = false;
                btnUyeDuzenle.Enabled = false;
            }



            if (grvGor == "var")
            {

                dtgvGrvli.Visible = true;
                btnGrvYenile.Enabled = true;



            }
            else
            {
                dtgvGrvli.Visible = false;
                btnGrvYenile.Enabled = false;
            }



            if (grvKay == "var")
            {
                btnGrvYeni.Enabled = true;
                btnGrvSil.Enabled = true;
                btnGrvDuzenle.Enabled = true;


            }
            else
            {
                btnGrvYeni.Enabled = false;
                btnGrvSil.Enabled = false;
                btnGrvDuzenle.Enabled = false;
            }


        }

        void rfrSil()
        {

            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    sID = dtgvRef.CurrentRow.Cells["ID"].Value.ToString();
                    sAd = dtgvRef.CurrentRow.Cells["Isim"].Value.ToString();

                    db.rfrSil(sID);
                    btnRfrYenile.PerformClick();

                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }

                AnaForm ana = new AnaForm();
                string islem = "Referans Silme, " + sAd + "-" + sID;
                ana.LogKayit(islem);
            }
        }


        void grvSil()
        {

            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    sID = dtgvGrvli.CurrentRow.Cells["ID"].Value.ToString();
                    sAd = dtgvGrvli.CurrentRow.Cells["Isim"].Value.ToString();

                    db.grvSil(sID);
                    btnGrvYenile.PerformClick();

                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }

                AnaForm ana = new AnaForm();
                string islem = "Görevli Silme, " + sAd + "-" + sID;
                ana.LogKayit(islem);
            }
        }

        void duzenleGrv()
        {
            sID = dtgvGrvli.CurrentRow.Cells["ID"].Value.ToString();
            sAd = dtgvGrvli.CurrentRow.Cells["Isim"].Value.ToString();
            sSoyad = dtgvGrvli.CurrentRow.Cells["Soyisim"].Value.ToString();
            sPozisyon = dtgvGrvli.CurrentRow.Cells["Pozisyon"].Value.ToString();
            yetKgor = dtgvGrvli.CurrentRow.Cells["KayitGo"].Value.ToString();
            yetUgor = dtgvGrvli.CurrentRow.Cells["UyeGo"].Value.ToString();
            yetUk = dtgvGrvli.CurrentRow.Cells["UyeKay"].Value.ToString();
            //sOgNo = dtgvUye.CurrentRow.Cells["GrvGo"].Value.ToString();
            //sOgNo = dtgvUye.CurrentRow.Cells["GrvKay"].Value.ToString();
            sKul = dtgvGrvli.CurrentRow.Cells["KullaniciAd"].Value.ToString();
            sSifre = dtgvGrvli.CurrentRow.Cells["Sifre"].Value.ToString();


            btnduzen = 1;


            yeniGorevli duzenleme = new yeniGorevli();
            duzenleme.ShowDialog();

        }

        void duzenleUye() {
            sID = dtgvUye.CurrentRow.Cells["ID"].Value.ToString();
            sAd = dtgvUye.CurrentRow.Cells["Isim"].Value.ToString();
            sSoyad = dtgvUye.CurrentRow.Cells["Soyisim"].Value.ToString();
            sBolum = dtgvUye.CurrentRow.Cells["Bolum"].Value.ToString();
            sTel = dtgvUye.CurrentRow.Cells["Telefon"].Value.ToString();
            sMail = dtgvUye.CurrentRow.Cells["Mail"].Value.ToString();
            sOgNo = dtgvUye.CurrentRow.Cells["OgrenciNO"].Value.ToString();

            sHava = dtgvUye.CurrentRow.Cells["Hava"].Value.ToString();
            sKara = dtgvUye.CurrentRow.Cells["Kara"].Value.ToString();
            sDeniz = dtgvUye.CurrentRow.Cells["Deniz"].Value.ToString();
            sSiber = dtgvUye.CurrentRow.Cells["Siber"].Value.ToString();

            sAciklama = dtgvUye.CurrentRow.Cells["Aciklama"].Value.ToString();

            btnduzen = 1;


            yeniUye duzenleme = new yeniUye();
            duzenleme.ShowDialog();

        }


        void uSil()
        {

            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    sID = dtgvUye.CurrentRow.Cells["ID"].Value.ToString();
                    sAd = dtgvUye.CurrentRow.Cells["Isim"].Value.ToString();

                    db.uyeSil(sID);
                    db.grvSil(sID);
                    btnUyeYenile.PerformClick();

                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }

                AnaForm ana = new AnaForm();
                string islem = "Üye Silme, " + sAd + "-" + sID;
                ana.LogKayit(islem);

            }
        }
    }
}
