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
    public partial class yeniUye : Form
    {
        public yeniUye()
        {
            InitializeComponent();
        }

        dbEngine db = new dbEngine();
        string sonIdgelen;
        int sonID, butondurum; // butondurum 0 ise gelen istek yeni kayıt, 1 ise düzenleme modu

        string uyeHava, uyeKara, uyeDeniz, uyeSiber;
        string dHava,dKara,dDeniz,dSiber; // duzenleme icin gelen ilgi alanları
        

        private void uyeHavaC_CheckedChanged(object sender, EventArgs e)
        {
            if (uyeHavaC.Checked == true)
            {
                uyeHava = "var";
            }
            else
            {
                uyeHava = "";
            }
        }

        private void uyeDenizC_CheckedChanged(object sender, EventArgs e)
        {

            if (uyeDenizC.Checked == true)
            {
                uyeDeniz = "var";
            }
            else
            {
                uyeDeniz = "";
            }
        }

        private void uyeSiberC_CheckedChanged(object sender, EventArgs e)
        {
            if (uyeSiberC.Checked == true)
            {
                uyeSiber = "var";
            }
            else
            {
                uyeSiber = "";
            }
        }

        private void btnYUyeKapat_Click(object sender, EventArgs e)
        {
            butondurum = 0;
            Kayitlar ky = new Kayitlar();
            ky.btnUyeYenile.PerformClick();
            this.Close();
        }

        private void btnUyeTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void yUyeTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yUyeOgNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void yUyeOgNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yUyeAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void yUyeSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void yeniUye_Load(object sender, EventArgs e)
        {

            try
            {

                butondurum = Kayitlar.btnduzen;

                if (butondurum == 1)
                {
                    btnUyeKaydet.Text = "GÜNCELLE";
                    gelenDuzenleme();
                }
                if (butondurum == 0)
                {
                
                    btnUyeKaydet.Text = "KAYDET";
                }


           


               
                uyeHava = "";
                uyeKara = "";
                uyeDeniz = "";
                uyeSiber = "";

                DataTable dt = new DataTable();
                dt = db.uyeOkumaID();
                sonIdgelen = db.sonIDst;
                
                sonID = Convert.ToInt32(sonIdgelen);
                
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
            
        }

        private void btnUyeKaydet_Click(object sender, EventArgs e)
        {

            try
            {





                // eğer boşluk yok ise
                if (yUyeAd.Text.Trim() != "" && yUyeSoyad.Text.Trim() != "" && yUyeBolum.Text.Trim() != "" && yUyeTel.Text.Trim() != "" && yUyeOgNo.Text.Trim() != "" && yUyeMail1.Text.Trim() != "" && yUyeMail2.Text.Trim() != "")
                {

                    if (butondurum==0)
                    {
                        KayitEkleme();
                        temizle();
                        
                    }

                    if (butondurum==1)
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


        void gelenDuzenleme()
        {
         
            
            yUyeAd.Text = Kayitlar.sAd;
            yUyeSoyad.Text = Kayitlar.sSoyad;
            yUyeBolum.Text = Kayitlar.sBolum;
            yUyeTel.Text = Kayitlar.sTel;
            yUyeOgNo.Text = Kayitlar.sOgNo;
            yUyeMail1.Text = Kayitlar.sMail;
            yUyeAciklama.Text = Kayitlar.sAciklama;
            dHava = Kayitlar.sHava;
            dKara = Kayitlar.sKara;
            dDeniz = Kayitlar.sDeniz;
            dSiber = Kayitlar.sSiber;

           


            if (dHava == "var")
            {
                uyeHavaC.Checked = true;
            }

            if (dKara == "var")
            {
                uyeKaraC.Checked = true;
            }



            if (dDeniz == "var")
            {
                uyeDenizC.Checked = true;
            }

            if (dSiber == "var")
            {
                uyeSiberC.Checked = true;
            }
        }

        void kayitGuncelle()
        {
            try
            {
                string mail = yUyeMail1.Text.Trim() + yUyeMail2.Text.Trim();
                string guncelID = Kayitlar.sID;
                db.uyeGuncelle(guncelID, yUyeAd.Text.Trim(), yUyeSoyad.Text, yUyeBolum.Text, yUyeTel.Text, mail, yUyeOgNo.Text, uyeHava, uyeKara, uyeDeniz, uyeSiber, yUyeAciklama.Text);
                MessageBox.Show("Güncelleme Başarılı Şekilde Yapıldı");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

            AnaForm ana = new AnaForm();
            string islem = "Üye Güncelleme, " + yUyeAd.Text + "-" + Kayitlar.sID;
            ana.LogKayit(islem);
        }

        void KayitEkleme()
        {
            AnaForm ana = new AnaForm();
            string islem = "Üye Yeni Kayıt, " + yUyeAd.Text + "-" + sonIdgelen;
            ana.LogKayit(islem);

            try
            {
                // aynı öğrenci numarasında kayıt yoksa
                if (db.uyeKontrol(yUyeOgNo.Text) == true)
                {
                    sonID += 1;
                    sonIdgelen = sonID.ToString();
                    string mail = yUyeMail1.Text.Trim() + yUyeMail2.Text.Trim();
                    db.uyeKayit(sonIdgelen, yUyeAd.Text.Trim(), yUyeSoyad.Text, yUyeBolum.Text, yUyeTel.Text, mail, yUyeOgNo.Text, uyeHava, uyeKara, uyeDeniz, uyeSiber, yUyeAciklama.Text);
                    MessageBox.Show("Kayıt Başarı ile Oluşturuldu");
                    temizle();

                }
                //aynı öğrenci numarasında kayıt var ise
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

        void temizle()
        {
            yUyeAd.Text = "";
            yUyeSoyad.Text = "";
            yUyeBolum.Items.Clear();
            yUyeTel.Text = "";
            yUyeOgNo.Text = "";
            yUyeMail1.Text = "";
            yUyeMail2.Items.Clear();
            yUyeAciklama.Text = "";
            uyeHavaC.Checked = false;
            uyeKaraC.Checked = false;
            uyeDenizC.Checked = false;
            uyeSiberC.Checked = false;
        }

        private void uyeKaraC_CheckedChanged(object sender, EventArgs e)
        {
            if (uyeKaraC.Checked == true)
            {
                uyeKara = "var";
            }
            else
            {
                uyeKara = "";
            }
        }
    }
}
