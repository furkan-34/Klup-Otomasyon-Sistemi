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
    public partial class yeniProje : Form
    {
        public yeniProje()
        {
            InitializeComponent();
        }

        // GENEL BOŞLUK

        string sID, sAd, sSoyad, sOgNo;
        string sonIdgelen, dID; // dID = düzenlenen projenin ID si
        int sonID;
        int butondurum;

        dbEngine db = new dbEngine();

        private void txtPrjAdminAd_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPrjAdminAra_Click(object sender, EventArgs e)
        {

        }

        private void txtPrjAdminAra_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrjAdminAra.Text = "";
        }

        private void txtPrjAdminAra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dur = 0;

            int listToplam = listByPrjUyeler.Items.Count;

            for (int i = 0; i < listToplam; i++)
            {
                string okuitem = listByPrjUyeler.Items[i].ToString();

                if (okuitem == sAd + " " + sSoyad)
                {
                    dur = 1;
                }
               
                

            }

            if (dur == 1)
            {
                MessageBox.Show("Seçili Üye Listede Bulunmakta!");
            }
            else
            {

                listByPrjUyeler.Items.Add(sAd + " " + sSoyad);

                listeSecID.Items.Add(sID); // eklenen kişilerin id leri buraya eklenir
            }

        }

        private void yeniProje_Click(object sender, EventArgs e)
        {
          
        }

        // ONEMLI KISIM-----------------------------------------------------------

        private void dtgvYprjUyeler_SelectionChanged(object sender, EventArgs e)
        {
            secimDoldur();
        }


        // listbox a boş kayıt eklenebiliyor engellenmeli -----------------------
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int deger = listByPrjUyeler.SelectedIndex;
            listByPrjUyeler.Items.RemoveAt(deger);
            listeSecID.Items.RemoveAt(deger);

        }

        private void btnGrvKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                // eğer boşluk yok ise
                if (txtPrjAd.Text.Trim() != "" && txtPrjAdminAd.Text.Trim() != "" && txtPrjAciklama.Text.Trim() != "" && listByPrjUyeler.Items.Count != 0)
                {

                    if (butondurum == 0)
                    {
                        kayitEkleme();
                        temizle();

                    }

                    if (butondurum == 1)
                    {
                        kayitGuncelle();

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

        private void txtYprjUyeAra_TextChanged(object sender, EventArgs e)
        {
            



            try
            {
                DataTable dtYprj = db.uyeListeleme();
                dtgvYprjUyeler.DataSource = dtYprj;

                dtYprj.DefaultView.RowFilter = string.Format("OgrenciNO LIKE '{0}%'", txtYprjUyeAra.Text);

                this.dtgvYprjUyeler.Columns["Bolum"].Visible = false;
                this.dtgvYprjUyeler.Columns["Telefon"].Visible = false;
                this.dtgvYprjUyeler.Columns["Mail"].Visible = false;
                this.dtgvYprjUyeler.Columns["Hava"].Visible = false;
                this.dtgvYprjUyeler.Columns["Kara"].Visible = false;
                this.dtgvYprjUyeler.Columns["Deniz"].Visible = false;
                this.dtgvYprjUyeler.Columns["Siber"].Visible = false;
                this.dtgvYprjUyeler.Columns["Aciklama"].Visible = false;
                this.dtgvYprjUyeler.Columns["ID"].Visible = false;
            }
            catch (Exception hata)
            {

                if (hata.Message=="Nesne başvurusu bir nesnenin örneğine ayarlanmadı.")
                {

                }
                else
	              {
                    MessageBox.Show(hata.Message);
                    Application.Exit();
                }
            }
                

            }

        private void yeniProje_Load(object sender, EventArgs e)
        {

            if (projeler.prjKay=="var")
            {
                txtYprjUyeAra.Enabled = true;
            }
            else
            {
                txtYprjUyeAra.Enabled = false;
            }


            butondurum = projeler.btnPrjduzen;

            try
            {

                if (butondurum == 1)
                {
                    btnPrjKaydet.Text = "GÜNCELLE";
                    gelenDuzenleme();
                }
                if (butondurum == 0)
                {

                    btnPrjKaydet.Text = "KAYDET";


                    DataTable dt = new DataTable();
                    dt = db.prjOkumaID();
                    sonIdgelen = db.sonIDst;

                    sonID = Convert.ToInt32(sonIdgelen);

                }


            }
            catch (Exception hata)
            {
                if (hata.Message=="0 konumunda satır yok.")
                {

                }
                else
                {
                    MessageBox.Show(hata.Message);
                }
              
                
            }
            
        }

        private void btnGrvTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnYGrvapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADMİN ADI ARAMA BUTONU -----------------------------------------

        private void btnPrjAdmnAra_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = db.prjAdminOkuma(txtPrjAdminAra.Text.Trim());
                txtPrjAdminAd.Text = dt.Rows[0]["Isim"].ToString() + " " + dt.Rows[0]["Soyisim"].ToString();
            }
            catch (Exception hata)
            {
                if (hata.Message == "0 konumunda satır yok.")
                {
                    MessageBox.Show("Aranılan kişi bulunamadı.");
                }
                else
                {

                    MessageBox.Show(hata.Message);
                    Application.Exit();
                }

            }
            
        }

        private void txtPrjAdminAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYprjUyeAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYprjUyeAra_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        void kayitEkleme()
        {
            int listToplam = listByPrjUyeler.Items.Count;

            sonID += 1;
            sonIdgelen = sonID.ToString();


            string prjID = sonIdgelen;

            string uyeToplam = "";

            string prjAd = txtPrjAd.Text;
            string prjAdmin = txtPrjAdminAd.Text;
            string prjAcik = txtPrjAciklama.Text;

            for (int i = 0; i < listToplam; i++)
            {
                uyeToplam += listByPrjUyeler.Items[i].ToString() + "\n - ";

                DataTable dt = db.prjUyeOkuma(listeSecID.Items[i].ToString());

                string uID = dt.Rows[0]["ID"].ToString();
                string uAd = dt.Rows[0]["Isim"].ToString();
                string uSoyad = dt.Rows[0]["Soyisim"].ToString();
                string uOgNo = dt.Rows[0]["OgrenciNO"].ToString();

                try
                {
                    db.prjUyelerKayit(uID, uAd, uSoyad, uOgNo, prjAd, prjID, prjAdmin, prjAcik, uyeToplam);
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                    Application.Exit();
                }

            }

            AnaForm ana = new AnaForm();
            string islem = "Proje Yeni Kayıt, " +prjAd+"-"+prjID;
            ana.LogKayit(islem);

            try
            {
                db.prjKayit(prjID, prjAd, prjAcik, uyeToplam, prjAdmin);
                MessageBox.Show("Kayıt Başarı ile Tamamlandı.");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                Application.Exit();
            }
        }

        void kayitGuncelle()
        {
            //  db.uyeGuncelle(guncelID, yUyeAd.Text.Trim(), yUyeSoyad.Text, yUyeBolum.Text, yUyeTel.Text, mail, yUyeOgNo.Text, uyeHava, uyeKara, uyeDeniz, uyeSiber, yUyeAciklama.Text);


            int listToplam = listByPrjUyeler.Items.Count;


            string prjID = dID;

            string uyeToplam = "";

            string prjAd = txtPrjAd.Text;
            string prjAdmin = txtPrjAdminAd.Text;
            string prjAcik = txtPrjAciklama.Text;

            // TOPLAM ÜYE LİSTESİ DOLDURMA VE ÜYE BİLGİLERİNİ YAZMA

            for (int i = 0; i < listToplam; i++)
            {
                uyeToplam += listByPrjUyeler.Items[i].ToString() + "\n - ";

                DataTable dt = db.prjUyeOkuma(listeSecID.Items[i].ToString());

                string uID = dt.Rows[0]["ID"].ToString();
                string uAd = dt.Rows[0]["Isim"].ToString();
                string uSoyad = dt.Rows[0]["Soyisim"].ToString();
                string uOgNo = dt.Rows[0]["OgrenciNO"].ToString();

                try
                {     // üyeleri güncelleme
                    db.prjGuncelleUyeler(uID, uAd, uSoyad, uOgNo, prjAd, prjID, prjAdmin, prjAcik, uyeToplam);

                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                    Application.Exit();
                }

            }

            AnaForm ana = new AnaForm();
            string islem = "Proje Güncelleme, Proje Ad-ID :"+prjAd+"-"+prjID;
            ana.LogKayit(islem);

            try
            {
                db.prjGuncelle(prjID, prjAd, prjAcik, uyeToplam, prjAdmin);
                MessageBox.Show("Güncelleme Başarı ile Tamamlandı.");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                Application.Exit();
            }

        }

        private void txtPrjAdminAd_TextChanged(object sender, EventArgs e)
        {

        }

        void temizle()
        {
            txtPrjAd.Text = "";
            txtPrjAdminAd.Text = "";
            txtPrjAdminAra.Text = "";
            txtYprjUyeAra.Text = "";
            txtPrjAciklama.Text = "";
            listByPrjUyeler.Items.Clear();
            listeSecID.Items.Clear();
        }

        void secimDoldur()
        {
            try
            {

                sID = dtgvYprjUyeler.CurrentRow.Cells["ID"].Value.ToString();
                sAd = dtgvYprjUyeler.CurrentRow.Cells["Isim"].Value.ToString();
                sSoyad = dtgvYprjUyeler.CurrentRow.Cells["Soyisim"].Value.ToString();
                sOgNo = dtgvYprjUyeler.CurrentRow.Cells["OgrenciNO"].Value.ToString();

            }
            catch (Exception hata)
            {

                if (hata.Message== "Nesne başvurusu bir nesnenin örneğine ayarlanmadı.")
                {

                }
                else
                {
                    MessageBox.Show(hata.Message);
                }
            }

           
        }

        void gelenDuzenleme()
        {

            dID = projeler.prjID;

            txtPrjAd.Text = projeler.prjAd;
            txtPrjAciklama.Text = projeler.prjAck;
            txtPrjAdminAd.Text = projeler.prjAdmin;

            // prje id e göre üye listesini çek
            DataTable dtUye = db.prjDznUyeler(projeler.prjID);
           // toplam satır sayısı kadar sorgulama yaparak üye ad soyad çek
           
            int toplamUye = dtUye.Rows.Count;
            for (int i = 0; i < toplamUye; i++)
            {
              listByPrjUyeler.Items.Add(dtUye.Rows[i]["Isim"].ToString() + " " + dtUye.Rows[i]["Soyisim"].ToString());

                listeSecID.Items.Add(dtUye.Rows[i]["ID"].ToString());
            }


        }

    }
}
