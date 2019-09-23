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
    public partial class yeniToplanti : Form
    {
        public yeniToplanti()
        {
            InitializeComponent();
        }

        // GENEL BOŞLUK

        dbEngine db = new dbEngine();

        string tID, tAd, tKonu, sIcerik, tDavet, tOlus, tTarih, tSaat;
        string davetK;
        string secilen;
        string gelen;
        string listAd;
        string sID, sAd, sSoyad, sOgNo;

        string sonIdgelen, sonIDList;
        int sonID, sonIDListInt;
        int a, dur;
        private void btnEkleDavet_Click(object sender, EventArgs e)
        {
            int dur = 0;

            int listToplam = listBtopDavet.Items.Count;

            for (int i = 0; i < listToplam; i++)
            {
                string okuitem = listBtopDavet.Items[i].ToString();

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

                listBtopDavet.Items.Add(sAd + " " + sSoyad);

                listeTopDvtID.Items.Add(sID); // eklenen kişilerin id leri buraya eklenir
            }
        }

        private void btnListKayit_Click(object sender, EventArgs e)
        {
            if (txtListAd.Text != "")
            {
                listeEkleme();
            }
            else
            {
                MessageBox.Show("Lütfen Liste Adı Giriniz!");
            }
        }

        private void cbTopUyeArama_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTopDvtAra.Text = "";
            txtTopDvtAra.Enabled = true;



            if (cbTopUyeArama.SelectedItem.ToString() == "Ad")
            {
                davetK = "Ad";
            }


            if (cbTopUyeArama.SelectedItem.ToString() == "Soyad")
            {
                davetK = "Soyad";
            }


            if (cbTopUyeArama.SelectedItem.ToString() == "Öğrenci Numarası")
            {
                davetK = "OgNo";
            }
        }

        private void btnListSil_Click(object sender, EventArgs e)
        {
            

            try
            {
                db.topDavetListSil(secilen);
                MessageBox.Show("Liste Silindi!");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cbList.SelectedItem.ToString();
            btnListSil.Enabled = true;

            try
            {
                DataTable dtListeYaz = db.topDavetListeYaz(secilen);
                int toplamsayi = dtListeYaz.Rows.Count;

                for (int i = 0; i < toplamsayi; i++)
                {
                    listBtopDavet.Items.Add(dtListeYaz.Rows[i]["UyeAd"].ToString());
                    listeTopDvtID.Items.Add(dtListeYaz.Rows[i]["UyeID"].ToString());
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

            
        }

        private void cbList_Click(object sender, EventArgs e)
        {
            listAd = cbList.SelectedIndex.ToString();
            listeOku();
        }

        private void btnSilDavet_Click(object sender, EventArgs e)
        {
            int deger = listBtopDavet.SelectedIndex;
            listBtopDavet.Items.RemoveAt(deger);
            listeTopDvtID.Items.RemoveAt(deger);




        }

        private void btnTopKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvYtopDavetli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvYtopDavetli_SelectionChanged(object sender, EventArgs e)
        {
            secimDoldur();
        }

        private void cbTopAra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtYprjUyeAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtYtop = db.uyeListeleme();
                dtgvYtopDavetli.DataSource = dtYtop;



                if (davetK == "Ad")
                {
                    dtYtop.DefaultView.RowFilter = string.Format("Isim LIKE '%{0}%'", txtTopDvtAra.Text);
                }

                if (davetK == "Soyad")
                {
                    dtYtop.DefaultView.RowFilter = string.Format("Soyisim LIKE '%{0}%'", txtTopDvtAra.Text);
                }

                if (davetK == "OgNo")
                {
                    dtYtop.DefaultView.RowFilter = string.Format("OgrenciNO LIKE '%{0}%'", txtTopDvtAra.Text);
                }



                this.dtgvYtopDavetli.Columns["Bolum"].Visible = false;
                this.dtgvYtopDavetli.Columns["Telefon"].Visible = false;
                this.dtgvYtopDavetli.Columns["Mail"].Visible = false;
                this.dtgvYtopDavetli.Columns["Hava"].Visible = false;
                this.dtgvYtopDavetli.Columns["Kara"].Visible = false;
                this.dtgvYtopDavetli.Columns["Deniz"].Visible = false;
                this.dtgvYtopDavetli.Columns["Siber"].Visible = false;
                this.dtgvYtopDavetli.Columns["Aciklama"].Visible = false;
                this.dtgvYtopDavetli.Columns["ID"].Visible = false;
            }
            catch (Exception hata)
            {

                if (hata.Message == "Nesne başvurusu bir nesnenin örneğine ayarlanmadı.")
                {

                }
                else
                {
                    MessageBox.Show(hata.Message);
                    Application.Exit();
                }
            }
        }

        private void btnTopKaydet_Click(object sender, EventArgs e)
        {

            if (txtTopAd.Text != "" && txtTopIcerik.Text != "" && txtTopKon.Text != "" && listBtopDavet.Items.Count != 0)
            {
                try
                {
                    kayitEkleme();
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Boşlukları Doldurunuz.");
            }



        }



        private void yeniToplanti_Load(object sender, EventArgs e)
        {

            if (toplantilar.topKay=="var")
            {
                cbTopUyeArama.Enabled = true;
            }
            else
            {
                cbTopUyeArama.Enabled = false;
            }


            txtTopDvtAra.Enabled = false;
            btnListSil.Enabled = false;

            try
            {
                DataTable dt = new DataTable();
                dt = db.topOkumaID();
                sonIdgelen = db.sonIDst;

                sonID = Convert.ToInt32(sonIdgelen);
            }
            catch (Exception hata)
            {
                if (hata.Message == "0 konumunda satır yok.")
                {

                }
                else
                {
                    MessageBox.Show(hata.Message);
                }

            }

        }


        void kayitEkleme()
        {



            int listToplam = listBtopDavet.Items.Count;

            sonID += 1;
            sonIdgelen = sonID.ToString();


            string topID = sonIdgelen;

            string davetToplam = "";

            string topAd = txtTopAd.Text;
            string topKonu = txtTopKon.Text;
            string topIcr = txtTopIcerik.Text;
            string topOlus = AnaForm.Ad + " " + AnaForm.Soyad;

            for (int i = 0; i < listToplam; i++)
            {
                davetToplam += listBtopDavet.Items[i].ToString() + "\n - ";

                DataTable dt = db.topUyeOkuma(listeTopDvtID.Items[i].ToString());

                string uID = dt.Rows[0]["ID"].ToString();
                string uAd = dt.Rows[0]["Isim"].ToString();
                string uSoyad = dt.Rows[0]["Soyisim"].ToString();
                int okuDurum = 0;

                try
                {
                    db.topUyelerKayit(uID, uAd, uSoyad, topID, topAd, topKonu, topIcr, topOlus, dtTarih.Text, dtSaat.Text, okuDurum);
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                    Application.Exit();
                }

            }

            try
            {
                db.topKayit(topID, topAd, topKonu, topIcr, davetToplam, topOlus, dtTarih.Text, dtSaat.Text);
                MessageBox.Show("Kayıt Başarı ile Tamamlandı.");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                Application.Exit();
            }

            AnaForm ana = new AnaForm();
            string islem = "Toplantı Yeni Kayıt, " + topAd + "-" + topID;
            ana.LogKayit(islem);
        }

        void listeEkleme()
        {
            int listToplam = listBtopDavet.Items.Count;

            try
            {
                if (a == 0)
                {
                    DataTable dtList = new DataTable();
                    dtList = db.topDavetListOkumaID();
                    sonIDList = db.sonIDstList;
                }


                sonIDListInt = Convert.ToInt32(sonIDList);
                sonIDListInt += 1;
                sonIDList = sonIDListInt.ToString();

                for (int i = 0; i < listToplam; i++)
                {

                    DataTable dt = db.topUyeOkuma(listeTopDvtID.Items[i].ToString());

                    string uID = dt.Rows[0]["ID"].ToString();
                    string uAd = dt.Rows[0]["Isim"].ToString() + " " + dt.Rows[0]["Soyisim"].ToString();



                    db.topDavetListeKayit(sonIDList, uAd, uID, txtListAd.Text);
                }

                MessageBox.Show("Liste Başarı İle Kayıt Edildi!");
            }
            catch (Exception hata)
            {

                if (hata.Message == "0 konumunda satır yok.")
                {
                    sonIDList = "0";
                    a = 1;
                    listeEkleme();
                }
                else
                {
                    MessageBox.Show(hata.Message);
                }

            }


        }

        void listeOku()
        {
            DataTable dtList = db.topDavetListele();


            int toplamList = dtList.Rows.Count;

            for (int i = 0; i < toplamList; i++)
            {
                gelen = dtList.Rows[i]["ListeAd"].ToString();

            // liste adı listede var ise tekrar yazdırmamak için
            int toplam = cbList.Items.Count;
                if (toplam != 0)
                {
                    dur = 0;
                    for (int z = 0; z < toplam; z++)
                    {
                        string b = cbList.Items[z].ToString();
                        
                        if (gelen == b)
                        {
                            dur = 1;
                        }
                    }

                    if (dur == 0)
                    {
                        cbList.Items.Add(gelen);
                    }
                }
                else
                {
                    cbList.Items.Add(gelen);
                }
                
            }
                
        
        }

                
        
    
            
    

        
    
        

        void secimDoldur()
        {
            try
            {

                sID = dtgvYtopDavetli.CurrentRow.Cells["ID"].Value.ToString();
                sAd = dtgvYtopDavetli.CurrentRow.Cells["Isim"].Value.ToString();
                sSoyad = dtgvYtopDavetli.CurrentRow.Cells["Soyisim"].Value.ToString();
                sOgNo = dtgvYtopDavetli.CurrentRow.Cells["OgrenciNO"].Value.ToString();

            }
            catch (Exception hata)
            {

                if (hata.Message == "Nesne başvurusu bir nesnenin örneğine ayarlanmadı.")
                {

                }
                else
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

       
    }
}
