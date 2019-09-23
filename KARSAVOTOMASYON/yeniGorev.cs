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
    public partial class yeniGorev : Form
    {
        public yeniGorev()
        {
            InitializeComponent();
        }


        // GENEL BOŞLUK

        dbEngine db = new dbEngine();

        string gorevliK;
        string sID, sAd, sSoyad, sOgNo;

        int sonID;
        string sonIdgelen;

        string gorevKategori;



        private void btnPrjKaydet_Click(object sender, EventArgs e)
        {
            kayitEkleme();
        }

      

        private void yeniGorev_Load(object sender, EventArgs e)
        {
            if (gorevler.gorevKay == "var")
            {
                cbGorevliArama.Enabled = true;
            }
            else
            {
                cbGorevliArama.Enabled = false;
            }


            txtGrvAra.Enabled = false;
            btnEkleGrvli.Enabled = false;  


            DataTable dt = new DataTable();
            dt = db.gorevOkumaID();
            sonIdgelen = db.sonIDst;

            sonID = Convert.ToInt32(sonIdgelen);
        }





        void kayitEkleme()
        {



            int listToplam = listBoxGorevlilerID.Items.Count;

            sonID += 1;
            sonIdgelen = sonID.ToString();


            string gorevID = sonIdgelen;



            string gorevAd = txtGrvAd.Text;
            
            string gorevIcr = txtGrvIcerik.Text;
            string gorevOlus = AnaForm.Ad + " " + AnaForm.Soyad;
            string gorevTarih = dtTarihGrv.Text + " " + dtSaat.Text;
            string gorevSonTarih = dtTarihSon.Text + " " + dtSaatSon.Text;
          



            for (int i = 0; i < listToplam; i++)
            {

                DataTable dt = db.gorevUyeOkuma(listBoxGorevlilerID.Items[i].ToString());

                string uID = dt.Rows[0]["ID"].ToString();
                string uAd = dt.Rows[0]["Isim"].ToString() + " " + dt.Rows[0]["Soyisim"].ToString();
                //  string uOgNo = dt.Rows[0]["OgrenciNO"].ToString();

                // listeden tek kişi çekildiği için iptal edildi kodlar

                //try
                //{
                //    db.gorevUyelerKayit(uID, uAd);
                //}
                //catch (Exception hata)
                //{

                //    MessageBox.Show(hata.Message);
                //    Application.Exit();
                //}

                AnaForm ana = new AnaForm();
                string islem = "Yeni Görev, Görev ID : " + gorevID+ " Üye ID : "+uID;
                ana.LogKayit(islem);

                try
            {
                db.gorevKayit(gorevID, gorevAd, gorevKategori, gorevIcr, uAd, gorevOlus, gorevSonTarih, uID,  gorevTarih);
                MessageBox.Show("Kayıt Başarı ile Tamamlandı.");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                Application.Exit();
            }
            }
        }

        private void cbGorevliKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void txtGrvAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtGorevli = db.uyeListeleme();
                dtgvGrvUye.DataSource = dtGorevli;



                if (gorevliK == "Ad")
                {
                   
                    dtGorevli.DefaultView.RowFilter = string.Format("Isim LIKE '%{0}%'", txtGrvAra.Text);
                    dtgvGrvUye.DataSource = dtGorevli;
                }

                if (gorevliK == "Soyad")
                {
                    dtGorevli.DefaultView.RowFilter = string.Format("Soyisim LIKE '%{0}%'", txtGrvAra.Text);
                    dtgvGrvUye.DataSource = dtGorevli;
                }

                if (gorevliK == "OgNo")
                {
                    dtGorevli.DefaultView.RowFilter = string.Format("OgrenciNO LIKE '{0}%'", txtGrvAra.Text);
                    dtgvGrvUye.DataSource = dtGorevli;
                }



                this.dtgvGrvUye.Columns["Bolum"].Visible = false;
                this.dtgvGrvUye.Columns["Telefon"].Visible = false;
                this.dtgvGrvUye.Columns["Mail"].Visible = false;
                this.dtgvGrvUye.Columns["Hava"].Visible = false;
                this.dtgvGrvUye.Columns["Kara"].Visible = false;
                this.dtgvGrvUye.Columns["Deniz"].Visible = false;
                this.dtgvGrvUye.Columns["Siber"].Visible = false;
                this.dtgvGrvUye.Columns["Aciklama"].Visible = false;
                this.dtgvGrvUye.Columns["ID"].Visible = false;
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

        private void dtgvGrvUye_SelectionChanged(object sender, EventArgs e)
        {
            secimDoldur();
        }

        private void btnSilGrvli_Click(object sender, EventArgs e)
        {
            try
            {
                int deger = listBoxGorevliler.SelectedIndex;
                listBoxGorevliler.Items.RemoveAt(deger);
                listBoxGorevlilerID.Items.RemoveAt(deger);

                if (listBoxGorevliler.Items.Count==0)
                {
                    btnEkleGrvli.Enabled = true;
                }
            }
            catch (Exception hata)
            {

                if (hata.Message== "InvalidArgument='-1' değeri 'index' için geçerli değil.")
                {

                }

            }


            
        }

        private void btnGrvKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGorevKate_SelectedIndexChanged(object sender, EventArgs e)
        {
            gorevKategori = cbGorevKate.SelectedItem.ToString();
           
        }

        private void cbGorevliArama_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGrvAra.Text = "";
            txtGrvAra.Enabled = true;
            btnEkleGrvli.Enabled = true;



            if (cbGorevliArama.SelectedItem.ToString() == "Ad")
            {
                gorevliK = "Ad";
            }


            if (cbGorevliArama.SelectedItem.ToString() == "Soyad")
            {
                gorevliK = "Soyad";
            }


            if (cbGorevliArama.SelectedItem.ToString() == "Öğrenci Numarası")
            {
                gorevliK = "OgNo";
            }
        }

        private void btnEkleGrvli_Click(object sender, EventArgs e)
        {
            int dur = 0;

            int listToplam = listBoxGorevliler.Items.Count;

            for (int i = 0; i < listToplam; i++)
            {
                string okuitem = listBoxGorevliler.Items[i].ToString();

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

                try
                {
                    btnEkleGrvli.Enabled = false; // ikinci kayıtı önlemek için

                    listBoxGorevliler.Items.Add(sAd + " " + sSoyad);

                    listBoxGorevlilerID.Items.Add(sID); // eklenen kişilerin id leri buraya eklenir


                   
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }


            }
        }


        void secimDoldur()
        {
            try
            {

                sID = dtgvGrvUye.CurrentRow.Cells["ID"].Value.ToString();
                sAd = dtgvGrvUye.CurrentRow.Cells["Isim"].Value.ToString();
                sSoyad = dtgvGrvUye.CurrentRow.Cells["Soyisim"].Value.ToString();
                sOgNo = dtgvGrvUye.CurrentRow.Cells["OgrenciNO"].Value.ToString();

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
