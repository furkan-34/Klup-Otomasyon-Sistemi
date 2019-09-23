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
    public partial class yeniReferans : Form
    {
        public yeniReferans()
        {
            InitializeComponent();
        }

        // GENEL BOŞLUK

        dbEngine db = new dbEngine();
        string sonIdgelen;
        int sonID;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRfrKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        void KayitEkleme() {

            sonID += 1;
            sonIdgelen = sonID.ToString();

            try
            {
                db.rfrKayit(sonIdgelen, txtRfrAd.Text.Trim(), txtRfrSoyad.Text.Trim(), txtRfrKurum.Text.Trim(), txtRfrIs.Text.Trim(), txtRfrTel.Text.Trim(), txtRfrMail.Text.Trim(), txtRfrAciklama.Text.Trim(), txtRfrKisi.Text.Trim());

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

            AnaForm ana = new AnaForm();
            string islem = "Referans Yeni Kayıt, "+txtRfrAd.Text+"-"+sonIdgelen;
            ana.LogKayit(islem);

            MessageBox.Show("Kayıt Başarı ile Oluşturuldu");
            temizle();

        }

        void temizle()
        {

            txtRfrAd.Text = "";
            txtRfrSoyad.Text = "";
            txtRfrKurum.Text = "";
            txtRfrIs.Text = "";
            txtRfrAciklama.Text = "";
            txtRfrMail.Text = "";
            txtRfrTel.Text = "";
            txtRfrKisi.Text = "";


        }

        private void btnRfrTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnRfrKaydet_Click(object sender, EventArgs e)
        {
            try
            {


                // eğer boşluk yok ise
                if (txtRfrAd.Text.Trim() != "" && txtRfrSoyad.Text.Trim() != "" && txtRfrKurum.Text.Trim() != "" && txtRfrIs.Text.Trim() != "" && txtRfrTel.Text.Trim() != "" && txtRfrMail.Text.Trim() != "" && txtRfrKisi.Text.Trim() != "")
                {
                  
                        KayitEkleme();
                        temizle();
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

        private void yeniReferans_Load(object sender, EventArgs e)
        {


            try
            {
                // son id alma yeri --------------------

                DataTable dt = new DataTable();
                dt = db.rfrOkumaID();
                sonIdgelen = db.sonIDst;
                sonID = Convert.ToInt32(sonIdgelen);

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }



        }
    }
}
