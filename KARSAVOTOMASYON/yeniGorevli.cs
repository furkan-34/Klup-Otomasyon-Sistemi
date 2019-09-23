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
    public partial class yeniGorevli : Form
    {
        public yeniGorevli()
        {
            InitializeComponent();
        }

        // GENEL BOŞLUK

        dbEngine db = new dbEngine();

        int butondurum; // butondurum 0 ise gelen istek yeni kayıt, 1 ise düzenleme modu
        string sPoz;
        string sgID, sgAd, sgSoyad, sgBolum, sgTel, sgMail, sgOgNo, sgHava, sgKara, sgDeniz, sgSiber, sgAciklama;
        string yKayGor, yPrjGor, yTopGor, yGorevGor, yUyeGor, yUyeKay, yGrvGor, yGrvKay, yRefGor, yRefKay;
        string yProjeGor, yProjeD, yTumTopGor, yTopKay, yTumGorevGor, yGorevKay, yMaliyeGor, yMaliyeKay;
        string duzengID;

        private void txtGrvBul_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dtGVyGrv_SelectionChanged(object sender, EventArgs e)
        {
            bilgiYazma();
        }

        private void btnGrvTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dtGVyGrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dtGVyGrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string thava, tkara, tdeniz, tsiber;



        private void txtGrvBul_TextChanged(object sender, EventArgs e)
        {
            yGrvUyeArama();
          
        }


        void yGrvUyeArama()
        {

            try
            {

                DataTable dtyGrv = db.uyeListeleme();
                dtGVyGrv.DataSource = dtyGrv;


                dtyGrv.DefaultView.RowFilter = string.Format("OgrenciNO LIKE '%{0}%'", txtGrvBul.Text);
                DataGridViewColumn columnBas = dtGVyGrv.Columns[0];
                DataGridViewColumn columnAd = dtGVyGrv.Columns[1];
                DataGridViewColumn columnSy = dtGVyGrv.Columns[2];
                DataGridViewColumn columnBo = dtGVyGrv.Columns[3];
                columnAd.Width = 0;
                columnAd.Width = 150;
                columnSy.Width = 150;
                columnBo.Width = 150;
                columnBo.Width = 200;

                bilgiYazma();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void yeniGorevli_Load(object sender, EventArgs e)
        {
            cLyetki.Enabled = false;
            txtPozD.Enabled = false;

            try
            {
                butondurum = Kayitlar.btnduzen;

                if (butondurum == 1)
                {
                    btnGrvKaydet.Text = "GÜNCELLE";
                    gelenDuzenleme();
                }
                if (butondurum == 0)
                {

                    btnGrvKaydet.Text = "KAYDET";
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void cbGrvPz_SelectedIndexChanged(object sender, EventArgs e)
        {
            sPoz = cbGrvPz.Text.Trim();
            txtPozD.Enabled = false;
           

            if (sPoz == "Başkan")
            {
                txtPozD.Enabled = false;
                cLyetki.Enabled = false;
                int toplam = cLyetki.Items.Count;
                for (int i = 0; i < toplam; i++)
                {
                    cLyetki.SetItemChecked(i, true);
                }

            }

            if (sPoz == "Başkan Yardımcısı")
            {
                txtPozD.Enabled = false;
                cLyetki.Enabled = false;
                int toplam = cLyetki.Items.Count;
                for (int i = 0; i < toplam; i++)
                {
                    cLyetki.SetItemChecked(i, true);
                }

                

            }

            if (sPoz == "Yönetim Kurulu Üyesi")
            {
                txtPozD.Enabled = false;
                cLyetki.Enabled = false;
                int toplam = cLyetki.Items.Count;
                for (int i = 0; i < toplam; i++)
                {
                    cLyetki.SetItemChecked(i, true);
                }

                cLyetki.SetItemChecked(5, false);
                cLyetki.SetItemChecked(7, false);
                cLyetki.SetItemChecked(8, false);
                cLyetki.SetItemChecked(9, false);
                cLyetki.SetItemChecked(11, false);
                cLyetki.SetItemChecked(13, false);
                cLyetki.SetItemChecked(15, false);
                cLyetki.SetItemChecked(16, false);
                cLyetki.SetItemChecked(17, false);

            }

            if (sPoz == "Denetim Kurulu Üyesi" || sPoz == "Denetim Kurulu Başkanı")
            {
                txtPozD.Enabled = false;
                cLyetki.Enabled = false;
                int toplam = cLyetki.Items.Count;
                for (int i = 0; i < toplam; i++)
                {
                    cLyetki.SetItemChecked(i, true);
                }

                cLyetki.SetItemChecked(5, false);
                cLyetki.SetItemChecked(7, false);
                cLyetki.SetItemChecked(9, false);
                cLyetki.SetItemChecked(11, false);
                cLyetki.SetItemChecked(13, false);
                cLyetki.SetItemChecked(15, false);
                cLyetki.SetItemChecked(17, false);
                

            }

            if (sPoz == "Yazman")
            {
                txtPozD.Enabled = false;
                cLyetki.Enabled = false;
                int toplam = cLyetki.Items.Count;
                for (int i = 0; i < toplam; i++)
                {
                    cLyetki.SetItemChecked(i, true);
                }

                cLyetki.SetItemChecked(5, false);
                cLyetki.SetItemChecked(7, false);
                cLyetki.SetItemChecked(8, false);
                cLyetki.SetItemChecked(9, false);
                cLyetki.SetItemChecked(11, false);
                
                cLyetki.SetItemChecked(15, false);
                cLyetki.SetItemChecked(16, false);
                cLyetki.SetItemChecked(17, false);

            }

            if (sPoz == "Sayman")
            {
                txtPozD.Enabled = false;
                cLyetki.Enabled = false;
                int toplam = cLyetki.Items.Count;
                for (int i = 0; i < toplam; i++)
                {
                    cLyetki.SetItemChecked(i, true);
                }

                cLyetki.SetItemChecked(5, false);   
                cLyetki.SetItemChecked(7, false);
                cLyetki.SetItemChecked(8, false);
                cLyetki.SetItemChecked(9, false);
                cLyetki.SetItemChecked(11, false);
                cLyetki.SetItemChecked(15, false);

            }



            if (sPoz == "Üye")
            {
                txtPozD.Enabled = false;
                cLyetki.Enabled = false;
                int toplam = cLyetki.Items.Count;
                for (int i = 0; i < toplam; i++)
                {
                    cLyetki.SetItemChecked(i, false);
                }

                cLyetki.SetItemChecked(1, true);
                cLyetki.SetItemChecked(2, true);
                cLyetki.SetItemChecked(3, true);

            }

            if (sPoz=="Diğer")
            {
                txtPozD.Enabled = true;
                int toplam = cLyetki.Items.Count;
                cLyetki.Enabled = true;
                txtPozD.Text = "";
               
                for (int i = 0; i < toplam; i++)
                {
                    cLyetki.SetItemChecked(i, false);

                }

               
            }


            

        }

        void gelenDuzenleme()
        {

            duzenlemeGrvBilgi();

            txtGrvKulAd.Text = Kayitlar.sKul;
            txtGrvSif.Text = Kayitlar.sSifre;

            cbGrvPz.Text = Kayitlar.sPozisyon;
         




        }






        void duzenlemeGrvBilgi()
        {

            duzengID = Kayitlar.sID; // secili ID tanımlama

            // secilen ID ye gore secilenin bilgilerini üye listesinden çağırma

            DataTable dt = db.grvBilgi(duzengID);
            


            sgAd = dt.Rows[0]["Isim"].ToString();
            sgSoyad= dt.Rows[0]["Soyisim"].ToString();
            sgBolum = dt.Rows[0]["Bolum"].ToString();
            sgTel = dt.Rows[0]["Telefon"].ToString();
            sgMail= dt.Rows[0]["Mail"].ToString();
            sgOgNo= dt.Rows[0]["OgrenciNO"].ToString();

            sgHava = dt.Rows[0]["Hava"].ToString();
            sgKara= dt.Rows[0]["Kara"].ToString();
            sgDeniz= dt.Rows[0]["Deniz"].ToString();
            sgSiber= dt.Rows[0]["Siber"].ToString();

            sgAciklama= dt.Rows[0]["Aciklama"].ToString();

            if (sgHava == "var")
            {
                thava = "✔";
            }

            if (sgKara == "var")
            {
                tkara = "✔";
            }

            if (sgDeniz == "var")
            {
                tdeniz = "✔";
            }

            if (sgSiber == "var")
            {
                tsiber = "✔";
            }


            txtGrvBilgi.Text = " Ad: " + sgAd + "\n\n Soyad : " + sgSoyad + "\n\n Bölüm : " + sgBolum + "\n\n Telefon : " + sgTel + "\n\n Mail Adresi : " + sgMail + "\n\n Öğrenci Numarası : " + sgOgNo + "\n\n                         HAVA     KARA     DENİZ     SİBER \n\n İlgi Alanları :            " + thava + "        " + tkara + "         " + tdeniz + "         " + tsiber + "\n\n  Açıklama : " + sgAciklama;





        }


        void yetkiDoldurma()
        {
            string kG = cLyetki.GetItemChecked(0).ToString();
            string pG = cLyetki.GetItemChecked(1).ToString();
            string tG = cLyetki.GetItemChecked(2).ToString();
            string gorevG = cLyetki.GetItemChecked(3).ToString();
            string uG = cLyetki.GetItemChecked(4).ToString();
            string uK = cLyetki.GetItemChecked(5).ToString();
            string gG = cLyetki.GetItemChecked(6).ToString();
            string gK = cLyetki.GetItemChecked(7).ToString();
            string rG = cLyetki.GetItemChecked(8).ToString();
            string rK = cLyetki.GetItemChecked(9).ToString();
            string prjG = cLyetki.GetItemChecked(10).ToString();
            string prjD = cLyetki.GetItemChecked(11).ToString();
            string topG = cLyetki.GetItemChecked(12).ToString();
            string topD = cLyetki.GetItemChecked(13).ToString();
            string tumgorevG = cLyetki.GetItemChecked(14).ToString();
            string tumgorevD = cLyetki.GetItemChecked(15).ToString();
            string maliyeGor = cLyetki.GetItemChecked(16).ToString();
            string maliyeKay = cLyetki.GetItemChecked(17).ToString();


            if (kG == "True")
            {

                yKayGor = "var";
            }
            else
            {

                yKayGor = "";
            }


            if (uG == "True")
            {

                yUyeGor = "var";
            }
            else
            {

                yUyeGor = "";
            }

            if (uK == "True")
            {
                yUyeKay = "var";
            }
            else
            {
                yUyeKay = "";
            }

            if (gG == "True")
            {
                yGrvGor = "var";
            }
            else
            {
                yGrvGor = "";
            }

            if (gK == "True")
            {
                yGrvKay = "var";
            }
            else
            {
                yGrvKay = "";
            }

            if (pG == "True")
            {
                yPrjGor = "var";
            }
            else
            {
                yPrjGor = "";
            }

            if (tG == "True")
            {
                yTopGor = "var";
            }
            else
            {
                yTopGor = "";
            }

            if (gorevG == "True")
            {
                yGorevGor = "var";
            }
            else
            {
                yGorevGor = "";
            }

            if (rG == "True")
            {
                yRefGor = "var";
            }
            else
            {
                yRefGor = "";
            }

            if (rK == "True")
            {
                yRefKay = "var";
            }
            else
            {
                yRefKay = "";
            }

            if (prjG == "True")
            {
                yProjeGor = "var";
            }
            else
            {
                yProjeGor = "";
            }

            if (prjD == "True")
            {
                yProjeD = "var";
            }
            else
            {
                yProjeD = "";
            }

            if (topG == "True")
            {
                yTumTopGor = "var";
            }
            else
            {
                yTumTopGor = "";
            }

            if (topD == "True")
            {
                yTopKay = "var";
            }
            else
            {
                yTopKay = "";
            }

            if (tumgorevG == "True")
            {
                yTumGorevGor = "var";
            }
            else
            {
                yTumGorevGor = "";
            }

            if (tumgorevD == "True")
            {
                yGorevKay = "var";
            }
            else
            {
                yGorevKay = "";
            }

           
            if (maliyeGor == "True")
            {
                yMaliyeGor = "var";
            }
            else
            {
                yMaliyeGor = "";
            }

            if (maliyeKay == "True")
            {
                yMaliyeKay = "var";
            }
            else
            {
                yMaliyeKay = "";
            }
        }



        void kayitGuncelleme()
        {
            dtGVyGrv.Enabled = false;
            panelYgrvli.Enabled = false;

            yetkiDoldurma();

            if (sPoz == "Diğer")
            {
                sPoz = txtPozD.Text;
            }

            AnaForm ana = new AnaForm();
            string islem = "Görevli Güncelleme, Görevli ID : "+Kayitlar.sID;
            ana.LogKayit(islem);

            try
            {
                string guncelID = Kayitlar.sID;

                db.grvGuncelle(guncelID, Kayitlar.sAd, Kayitlar.sSoyad, sPoz, yKayGor,yPrjGor, yTopGor , yGorevGor , yUyeGor, yUyeKay, yGrvGor, yGrvKay, yRefGor , yRefKay , yProjeGor, yProjeD, yTumTopGor, yTopKay, yTumGorevGor, yGorevKay, yMaliyeGor, yMaliyeKay ,txtGrvKulAd.Text.Trim(), txtGrvSif.Text.Trim());
                MessageBox.Show("Güncelleme Başarılı Şekilde Yapıldı");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
            
            

        }

        void kayitEkleme()
        {
            yetkiDoldurma();

            if (sPoz == "Diğer")
            {
                sPoz = txtPozD.Text;
            }

            AnaForm ana = new AnaForm();
            string islem = "Yeni Görevli Kayıt, Görevli Ad - ID : "+sgAd+"-"+sgID;
            ana.LogKayit(islem);

            try
            {

                // aynı öğrenci numarasında kayıt yoksa
                if (db.grvKontrol(sgID) == true)
                {

                    db.grvKayit(sgID, sgAd, sgSoyad, sPoz, yKayGor, yPrjGor, yTopGor, yGorevGor, yUyeGor, yUyeKay, yGrvGor, yGrvKay, yRefGor, yRefKay,yProjeGor, yProjeD, yTumTopGor, yTopKay, yTumGorevGor, yGorevKay, txtGrvKulAd.Text.Trim(), txtGrvSif.Text.Trim());
                    MessageBox.Show("Kayıt Başarı ile Oluşturuldu");
                    temizle();

                }
                ////aynı öğrenci numarasında kayıt var ise
                else
                {
                    MessageBox.Show("Bu Kişi Daha önceden Kayıt olmuştur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }




        }

        void bilgiYazma()
        {

            try
            {

                // Bilgi önizlemesi doldurma------------------------------

                sgID = dtGVyGrv.CurrentRow.Cells["ID"].Value.ToString();
                sgAd = dtGVyGrv.CurrentRow.Cells["Isim"].Value.ToString();
                sgSoyad = dtGVyGrv.CurrentRow.Cells["Soyisim"].Value.ToString();
                sgBolum = dtGVyGrv.CurrentRow.Cells["Bolum"].Value.ToString();
                sgTel = dtGVyGrv.CurrentRow.Cells["Telefon"].Value.ToString();
                sgMail = dtGVyGrv.CurrentRow.Cells["Mail"].Value.ToString();
                sgOgNo = dtGVyGrv.CurrentRow.Cells["OgrenciNO"].Value.ToString();

                sgHava = dtGVyGrv.CurrentRow.Cells["Hava"].Value.ToString();
                sgKara = dtGVyGrv.CurrentRow.Cells["Kara"].Value.ToString();
                sgDeniz = dtGVyGrv.CurrentRow.Cells["Deniz"].Value.ToString();
                sgSiber = dtGVyGrv.CurrentRow.Cells["Siber"].Value.ToString();

                sgAciklama = dtGVyGrv.CurrentRow.Cells["Aciklama"].Value.ToString();

                if (sgHava == "var")
                {
                    thava = "✔";
                }

                if (sgKara == "var")
                {
                    tkara = "✔";
                }

                if (sgDeniz == "var")
                {
                    tdeniz = "✔";
                }

                if (sgSiber == "var")
                {
                    tsiber = "✔";
                }

                txtGrvBilgi.Text = " Ad: " + sgAd + "\n\n Soyad : " + sgSoyad + "\n\n Bölüm : " + sgBolum + "\n\n Telefon : " + sgTel + "\n\n Mail Adresi : " + sgMail + "\n\n Öğrenci Numarası : " + sgOgNo + "\n\n                         HAVA     KARA     DENİZ     SİBER \n\n İlgi Alanları :            " + thava + "        " + tkara + "         " + tdeniz + "         " + tsiber + "\n\n  Açıklama : " + sgAciklama;

            }
            catch (Exception hata)
            {

                if (hata.Message=="Nesne başvurusu bir nesnenin örneğine ayarlanmadı.")
                {
                    MessageBox.Show("Geçersiz Karakter Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(hata.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                txtGrvBul.Text = "";
            }





        }

        void temizle()
        {

            int toplam = cLyetki.Items.Count;

            txtGrvBul.Text = "";
            txtGrvKulAd.Text = "";
            txtGrvSif.Text = "";

            for (int i = 0; i < toplam; i++)
            {
                cLyetki.SetItemChecked(i, false);

            }

            txtPozD.Text = "";
            cbGrvPz.Text = "";

            txtGrvBilgi.Text = "";


        }
        private void cLyetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnYGrvapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrvKaydet_Click(object sender, EventArgs e)
        {


            try
            {


                // eğer boşluk yok ise
                if (txtGrvKulAd.Text.Trim() != "" && txtGrvSif.Text.Trim() != "")
                {

                    if (butondurum == 0)
                    {

                        kayitEkleme();
                        temizle();

                    }

                    if (butondurum == 1)
                    {
                        kayitGuncelleme();

                        this.Close();
                    }


                }

                else
                {
                    MessageBox.Show("Boşlukları Doldurunuz");
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }








        }
    }
}
