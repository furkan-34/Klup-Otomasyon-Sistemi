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
    public partial class gorevGoruntule : Form
    {
        public gorevGoruntule()
        {
            InitializeComponent();
        }

        dbEngine db = new dbEngine();
        AnaForm af = new AnaForm();
        Login lg = new Login();

        string gorevID;
        string gBaslik;
        string gkategori;
        string gAciklama;
        string gorevliAd;
        string gVeren;
        string gSonTarih;
        string gorevliID;
        string gVerilTarih; 

        private void gorevGoruntule_Load(object sender, EventArgs e)
        {
            
            grvBaslik.Enabled = false;
            grvVeren.Enabled = false;
           

            DataTable dt = db.gorevleriListeleme(AnaForm.grvID.ToString());

             gorevID = dt.Rows[AnaForm.secilen]["ID"].ToString();
             gBaslik = dt.Rows[AnaForm.secilen]["Isim"].ToString();
             gkategori = dt.Rows[AnaForm.secilen]["Kategori"].ToString();
             gAciklama = dt.Rows[AnaForm.secilen]["Icerik"].ToString();
             gorevliAd = AnaForm.Ad + " " + AnaForm.Soyad;
             gVeren = dt.Rows[AnaForm.secilen]["Kimden"].ToString();
             gSonTarih = dt.Rows[AnaForm.secilen]["SonTarih"].ToString();
             gorevliID = AnaForm.grvID.ToString();
             gVerilTarih = dt.Rows[AnaForm.secilen]["VerildigiTarih"].ToString();
   
            grvBaslik.Text = gBaslik;
            grvAciklama.Text = gAciklama;
            grvVeren.Text = gVeren;
        }

        private void btnGGKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rapor = grvRapor.Text;

            DataTable dt = new DataTable();
            dt = db.gorevOkumagecmisID();
           string  sonIdgelen = db.sonIDst;

           int sonID = Convert.ToInt32(sonIdgelen);
            sonID += 1;
            sonIdgelen = sonID.ToString();

            DateTime tarih = DateTime.Now.Date;
           string yeniTarih = tarih.ToString().TrimEnd('0', ':');

            if (rapor != "")
            {

           

            try
            {    
                db.gecmisGorevKayit(sonIdgelen, gBaslik, gkategori, gAciklama, gorevliAd, gVeren, gSonTarih, gorevliID, gVerilTarih, yeniTarih, rapor);
                MessageBox.Show("Görev Raporu Başarı İle Oluşturuldu !");
                db.gorevSil(gorevID);
                af.Close();
                lg.AnaFormAc();
                this.Close();
              
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                this.Close();
            }

            }
            else
            {
                MessageBox.Show("Boşlukları Doldurunuz!");
            }
        }
    }
}
