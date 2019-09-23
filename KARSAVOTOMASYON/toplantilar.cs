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
    public partial class toplantilar : Form
    {
        public toplantilar()
        {
            InitializeComponent();
        }

        // GENEL BOŞLUK

        dbEngine db = new dbEngine();
        DataTable dtTop = new DataTable();

        string sID, sAd, sKonu, sIcerik, sKarar, sOlus, sTarih, sSaat;
        

        public static string topGor, topKay;

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {

            topDuzenle();
            btnTopYenile.PerformClick();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            listeKatilmayanlar.Items.Clear();
            listeTopKatilmayan.Items.Clear();
            int dur = 0;
            int listToplam;
            int toplam = cLTopDavet.Items.Count;

            for (int i = 0; i < toplam; i++)
            {
                string durum = cLTopDavet.GetItemChecked(i).ToString();


                if (durum == "True")
                {

                     dur = 0;

                    listToplam = listeKatilmayanlar.Items.Count;

                    for (int a = 0; a < listToplam; a++)
                    {
                        string okuitem = listeKatilmayanlar.Items[a].ToString();
                        if (okuitem == cLTopDavet.Items[i].ToString())
                        {
                            dur = 1;
                            
                        }


                    }
                    // ÜYE ZATEN LİSTEDE BULUNMAKTA UYARISI ALGORİTMİK OLARAK DEVRE DIŞI, HER SEÇİMDE LİSTELER TEMİZLENDİĞİ İÇİN GEREK DUYULMUYOR
                    if (dur == 1)
                    {
                        MessageBox.Show("Üye Zaten Listede Bulunmakta!");
                    }
                    else
                    {
                        listeKatilmayanlar.Items.Add(cLTopDavet.Items[i].ToString());

                        listeTopKatilmayan.Items.Add(listGelenDavetID.Items[i]);
                    }


                }


            }
        }

        private void dtgvToplanti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSilTopYok_Click(object sender, EventArgs e)
        {
            int deger = listeKatilmayanlar.SelectedIndex;
            listeKatilmayanlar.Items.RemoveAt(deger);
            listeTopKatilmayan.Items.RemoveAt(deger);
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    db.topSil(sID);
                    db.topUyeleriSil(sID);
                    btnTopYenile.PerformClick();

                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }

                AnaForm ana = new AnaForm();
                string islem = "Toplantı Silme, " + sAd + "-" + sID;
                ana.LogKayit(islem);
            }


        }

        private void btnUyeKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cLTopDavet_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void toplantilar_Load(object sender, EventArgs e)
        {
                try
                {

                if (topGor == "var")
                {
                    dtTop = db.topListeleme();

                    dtgvToplanti.DataSource = dtTop;

                    this.dtgvToplanti.Columns["ID"].Visible = false;
                    this.dtgvToplanti.Columns["Icerik"].Visible = false;
                    this.dtgvToplanti.Columns["Kararlar"].Visible = false;
                    this.dtgvToplanti.Columns["Davetliler"].Visible = false;
                    this.dtgvToplanti.Columns["Olusturan"].Visible = false;
                    this.dtgvToplanti.Columns["Tarih"].Visible = false;
                    this.dtgvToplanti.Columns["Saat"].Visible = false;

                    dtgvToplanti.Columns[1].HeaderText = "Toplantı Adı";
                    dtgvToplanti.Columns[2].HeaderText = "Konusu";

                }

                else
                {

                    btnTopYenile.Enabled = false;
                    DataTable dtTopUye = db.topEksikUyeBilgi(AnaForm.grvID);
                    dtgvToplanti.DataSource = dtTopUye;

                    this.dtgvToplanti.Columns["UyeID"].Visible = false;
                    this.dtgvToplanti.Columns["UyeIsim"].Visible = false;
                    this.dtgvToplanti.Columns["UyeSoyisim"].Visible = false;
                    this.dtgvToplanti.Columns["ID"].Visible = false;
                    this.dtgvToplanti.Columns["Icerik"].Visible = false;
                    this.dtgvToplanti.Columns["Kararlar"].Visible = false;
                    this.dtgvToplanti.Columns["Olusturan"].Visible = false;
                    this.dtgvToplanti.Columns["Tarih"].Visible = false;
                    this.dtgvToplanti.Columns["Saat"].Visible = false;
                    this.dtgvToplanti.Columns["OkuDurum"].Visible = false;


                    dtgvToplanti.Columns[5].HeaderText = "Toplantı Adı";
                    dtgvToplanti.Columns[6].HeaderText = "Konusu";
                    dtgvToplanti.Columns[3].HeaderText = "Katılmama Durumu";
                   


                }

               
            }

            catch (Exception hata)
            {
                if (hata.Message=="Nesne başvurusu bir nesnenin örneğine ayarlanmadı.")
                {

                }
                else
                {
                    MessageBox.Show(hata.Message);
                }
               
            }



            if (topKay == "var")
            {
                btnTopSil.Enabled = true;
                btnTopDuzenle.Enabled = true;
                btnTopYeni.Enabled = true;
            }
            else
            {
                btnTopSil.Enabled = false;
                btnTopDuzenle.Enabled = false;
                btnTopYeni.Enabled = false;
            }

           
        }

        private void btnUyeYenile_Click(object sender, EventArgs e)
        {
            dtTop = db.topListeleme();

            dtgvToplanti.DataSource = dtTop;

            this.dtgvToplanti.Columns["ID"].Visible = false;
            this.dtgvToplanti.Columns["Icerik"].Visible = false;
            this.dtgvToplanti.Columns["Kararlar"].Visible = false;
            this.dtgvToplanti.Columns["Davetliler"].Visible = false;
            this.dtgvToplanti.Columns["Olusturan"].Visible = false;
            this.dtgvToplanti.Columns["Tarih"].Visible = false;
            this.dtgvToplanti.Columns["Saat"].Visible = false;

            dtgvToplanti.Columns[1].HeaderText = "Toplantı Adı";
            dtgvToplanti.Columns[2].HeaderText = "Konusu";


        }

        private void btnUyeYeni_Click(object sender, EventArgs e)
        {
            yeniToplanti yt = new yeniToplanti();
            yt.ShowDialog();
        }

        private void dtgvToplanti_SelectionChanged(object sender, EventArgs e)
        {
            secimiDoldur();
        }

        void secimiDoldur()
        {
            try
            {
                listeTopKatilmayan.Items.Clear();
                listGelenDavetID.Items.Clear();
                listeKatilmayanlar.Items.Clear();

                sID = dtgvToplanti.CurrentRow.Cells["ID"].Value.ToString();
                sAd = dtgvToplanti.CurrentRow.Cells["Isim"].Value.ToString();
                sKonu = dtgvToplanti.CurrentRow.Cells["Konu"].Value.ToString();
                sIcerik = dtgvToplanti.CurrentRow.Cells["Icerik"].Value.ToString();
                sKarar = dtgvToplanti.CurrentRow.Cells["Kararlar"].Value.ToString();
                sOlus = dtgvToplanti.CurrentRow.Cells["Olusturan"].Value.ToString();
                sTarih = dtgvToplanti.CurrentRow.Cells["Tarih"].Value.ToString();
                sSaat = dtgvToplanti.CurrentRow.Cells["Saat"].Value.ToString();

                txtTopAd.Text = sAd;
                txtTopKonu.Text = sKonu;
                txtTopİcerik.Text = sIcerik;
                txtTopAlKarar.Text = sKarar;
                lblTopOlus.Text = sOlus;
                txtTopTar.Text = sTarih;
                txtTopSaat.Text= sSaat;

                // toplantı id e göre üye listesini çek
                DataTable dtTopUye = db.topDznUyeler(sID);

                cLTopDavet.Items.Clear();
                listGelenDavetID.Items.Clear();


                // toplam satır sayısı kadar sorgulama yaparak üye ad soyad çek
                int toplamUye = dtTopUye.Rows.Count;
                    for (int i = 0; i < toplamUye; i++)
                    {
                    cLTopDavet.Items.Insert(i, dtTopUye.Rows[i]["UyeIsim"].ToString() + " " + dtTopUye.Rows[i]["UyeSoyisim"].ToString());

                    listGelenDavetID.Items.Add(dtTopUye.Rows[i]["UyeID"].ToString());

                    // ÜYE YOKLAMA LİSTESİNİ TOPLANTI ÜYE LİST DEN KATILMAMA BÖLÜMÜNDEN ÇEKİP YAZIYORUM

                    string yoklama = dtTopUye.Rows[i]["Katilmama"].ToString();


                    if (yoklama=="VAR")
                    {
                        listeKatilmayanlar.Items.Add(dtTopUye.Rows[i]["UyeIsim"].ToString() + " " + dtTopUye.Rows[i]["UyeSoyisim"].ToString());
                        listeTopKatilmayan.Items.Add(dtTopUye.Rows[i]["UyeID"].ToString());
                    }
                       }



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

        void topDuzenle()
        {



            try
            {
                db.topYoklamaTemizle(sID);


                int listToplam = listeTopKatilmayan.Items.Count;

                for (int i = 0; i < listToplam; i++)
                {
                    db.topGuncelleUyeler(listeTopKatilmayan.Items[i].ToString(), sID);
                }

               

                db.topGuncelle(sID, txtTopAd.Text.Trim(), txtTopKonu.Text.Trim(), txtTopİcerik.Text.Trim(), txtTopAlKarar.Text.Trim(), txtTopTar.Text.Trim(), txtTopSaat.Text.Trim());
                db.topGuncelleUye(sID, txtTopAd.Text.Trim(), txtTopKonu.Text.Trim(), txtTopİcerik.Text.Trim(), txtTopAlKarar.Text.Trim(), txtTopTar.Text.Trim(), txtTopSaat.Text.Trim());
                MessageBox.Show("Güncelleme Başarı ile Tamamlandı.");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                Application.Exit();
            }

            AnaForm ana = new AnaForm();
            string islem = "Toplantı Düzenleme, " + txtTopAd.Text + "-" + sID;
            ana.LogKayit(islem);
        }



    }


    
}
