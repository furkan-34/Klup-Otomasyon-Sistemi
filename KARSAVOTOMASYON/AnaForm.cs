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
    public partial class AnaForm : Form
    {
        
        Label[] baslik = new Label[9];
        Label[] labels = new Label[9];
        Button[] buton = new Button[9];
        PictureBox[] pb = new PictureBox[9];

        public AnaForm()
        {
            InitializeComponent();
            // başlıklar etiketlendi
            baslik[0] = baslik1;
            baslik[1] = baslik2;
            baslik[2] = baslik3;
            baslik[3] = baslik4;
            baslik[4] = baslik5;
            baslik[5] = baslik6;
            baslik[6] = baslik7;
            baslik[7] = baslik8;
            baslik[8] = baslik9;


            // labeller etiketlendi
            labels[0] = gorev1;
            labels[1] = gorev2;
            labels[2] = gorev3;
            labels[3] = gorev4;
            labels[4] = gorev5;
            labels[5] = gorev6;
            labels[6] = gorev7;
            labels[7] = gorev8;
            labels[8] = gorev9;

            // butonlar etiketlendi
            buton[0] = buton1;
            buton[1] = buton2;
            buton[2] = buton3;
            buton[3] = buton4;
            buton[4] = buton5;
            buton[5] = buton6;
            buton[6] = buton7;
            buton[7] = buton8;
            buton[8] = buton9;
          
            
            // picturebox lar etiketlendi
            pb[0] = pB1;
            pb[1] = pB2;
            pb[2] = pB3;
            pb[3] = pB4;
            pb[4] = pB5;
            pb[5] = pB6;
            pb[6] = pB7;
            pb[7] = pB8;
            pb[8] = pB9;
        }

        // GENEL BOSLUK
        public static int grvID, sonLogID;
        public static string macAdres;
        public static string Ad, Soyad, Pozisyon, Bolum, Projeler, KatTop;
        public static string grvIP, grvSehir, grvSirket, grvEn, grvBoy;
        public static string kGor, tGor, pGor, gGor;
        public static int secilen;

        public static int toplamGorev;
        public static int topOkuDurum;
        public static string adres = "https://www.karsav.org/event/";
        public static string sADetkinlik;

        public static string duyuruUrl;

        public static int puan;
       


        public static string tarih, saat;

       Kayitlar ky = new Kayitlar();


        dbEngine db = new dbEngine();

        

        private void button1_Click(object sender, EventArgs e)
        {
            AnaForm ana = new AnaForm();
            string islem = "Kayıtlar Butonuna Basıldı";
            ana.LogKayit(islem);
            Kayitlar kayitlar = new Kayitlar();
            kayitlar.ShowDialog();
        }

        private void btnToplnti_Click(object sender, EventArgs e)
        {
            AnaForm ana = new AnaForm();
            string islem = "Toplantılar Butonuna Basıldı";
            ana.LogKayit(islem);
            toplantilar tp = new toplantilar();
            tp.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AnaForm ana = new AnaForm();
            string islem = "Görevler Butonuna Basıldı.";
            ana.LogKayit(islem);
            gorevler gr = new gorevler();
            gr.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 0;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void buton2_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 1;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 2;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void buton4_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 3;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dSaat.Format = DateTimePickerFormat.Custom;
            dSaat.CustomFormat = "HH:mm:ss tt";
            saat = DateTime.Now.ToString("HH:mm:ss");
            tarih = DateTime.Now.ToString("dd-MM-yyyy");

           
        }

        private void buton5_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 4;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void buton6_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 5;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void buton7_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 6;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void buton8_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 7;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void dtgvEtkinlikler_DoubleClick(object sender, EventArgs e)
        {
            adres = "https://www.karsav.org/event/";
            sADetkinlik = dtgvEtkinlikler.CurrentRow.Cells["post_title"].Value.ToString();


            int a = sADetkinlik.Split(' ').Length;
            a -= 1;


            //BOŞLUKLARI KULLANARAK AYIRMA İŞLEMİ VE - EKLEME İŞLEMİ YAPILIYOR
            for (int i = 0; i < a; i++)
            {
                //aşağıdaki kodlama ile de herbir değer elde ediliyor.
                adres += sADetkinlik.Split(' ')[i];
                adres += "-";
               

            }
            //SONUNCU KELİMEYİ ALIP ÖNÜNE / EKLEME VE I HARFLERİNİ İ YE DÖNÜŞTÜRME
            adres += sADetkinlik.Split(' ')[a];
            adres += "/";
            adres = adres.Replace('ı', 'i');

            etkinlikGoruntule ac = new etkinlikGoruntule();
            ac.Text=sADetkinlik;
            ac.ShowDialog();
        }

        private void buton9_Click(object sender, EventArgs e)
        {
            AnaForm.secilen = 8;
            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void dtgvDuyurular_DoubleClick(object sender, EventArgs e)
        {
            duyuruUrl = dtgvDuyurular.CurrentRow.Cells["URL"].Value.ToString();
            duyuruGoruntule ac = new duyuruGoruntule();
            ac.Text = dtgvDuyurular.CurrentRow.Cells["Title"].Value.ToString();
            ac.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AnaForm ana = new AnaForm();
            string islem = "Maliye Butonuna Basıldı";
            ana.LogKayit(islem);
            maliye ac = new maliye();
            ac.ShowDialog();
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
          secilen = Convert.ToInt32(listBoxGorevlerim.SelectedIndex.ToString());

            gorevGoruntule gorev = new gorevGoruntule();
            gorev.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("test");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaForm ana = new AnaForm();
            string islem = "Projeler Butonuna Basıldı.";
            ana.LogKayit(islem);
            projeler pr = new projeler();
            pr.ShowDialog();
        }

        private void btnCikisAna_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

            string islem = "Giriş Yapıldı";
            LogKayit(islem);

            TopDuyuru();
            
            GorevGoruntule();

            YetkiYazma();

            EtkinlikYaz();

            DuyuruYaz();

            // YETKİ KONTROLLERİ----------------------------------------------
            if (kGor=="var")
            {
                btnKayitlar.Enabled = true;
            }
            else
            {
                btnKayitlar.Enabled = false;
            }
            //-----------------
            if (tGor == "var")
            {
                btnToplnti.Enabled = true;
            }
            else
            {
                btnToplnti.Enabled = false;
            }
            //---------------------
            if (pGor == "var")
            {
                btnProjeler.Enabled = true;
            }
            else
            {
                btnProjeler.Enabled = false;
            }
            //-----------------------------------
            if (gGor == "var")
            {
                btnGorevler.Enabled = true;
            }
            else
            {
                btnGorevler.Enabled = false;
            }

            if (maliye.maliyeGo == "var")
            {
                btnMaliye.Enabled = true;
            }
            else
            {
                btnMaliye.Enabled = false;
            }


            //-----------------------------------
            lblAd.Text = Ad;
            lblSoyad.Text = Soyad;
            txtBolum.Text = Bolum;
            txtProjelerim.Text = Projeler;


            //split ile katılmayan her toplantı adı ayrıştırılarak list box a ekleniyor
            if (KatTop != null)
            {
                for (int i = 0; i < KatTop.Split('\n').Length - 1; i++)
                {
                    listBkatTop.Items.Add(KatTop.Split('\n')[i]);

                }
            }


            int eksilecekPuan = (listBkatTop.Items.Count * 20) + (Login.eksikGorevSayi * 10);
            int eklenecekPuan = (10 * (Login.toplamToplanti - listBkatTop.Items.Count)) + (5 * Login.yapilanGorevSayi);
            puan = 100 - eksilecekPuan + eklenecekPuan;

            if (puan < 20 || puan == 20)
            {
                MessageBox.Show("Puanınız Sıfır veya Sıfırdan Küçük Olması Durumunda KIRMIZI LİSTE'ye Yazılacaksınız!");
            }

            if (puan < 0 || puan == 0)
            {
                try
                {
                    if (db.kirmiziKontrol(grvID) == true)
                    {

                        db.kirmiziKayit(grvID, Ad, Soyad, puan.ToString());
                        MessageBox.Show("KIRMIZI LİSTEYE YAZILDINIZ!");


                    }
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }
                
            }

            DataTable dtKirmizi = new DataTable();
            dtKirmizi = db.kirmiziListele();
            dtgvKirmizi.DataSource = dtKirmizi;
            this.dtgvKirmizi.Columns["ID"].Visible = false;
            dtgvKirmizi.Columns["Isim"].HeaderText = "Ad";
            dtgvKirmizi.Columns["Soyisim"].HeaderText = "Soyad";
          


            lblPuan.Text = puan.ToString();

            tblYapGor.Text = Login.yapilanGorevSayi.ToString();
            tblGecGorev.Text = Login.eksikGorevSayi.ToString();
            tblKatildigimTop.Text = (Login.toplamToplanti - listBkatTop.Items.Count).ToString();
            tblKatilmayTop.Text = listBkatTop.Items.Count.ToString();


            tblGirisBilgi.Text = Ad + " " + Soyad + "  Yetkiniz : " + Pozisyon + ", Üye Numaranız = "+grvID;
            labelVersiyon.Text="Versiyon : " + Application.ProductVersion;
        }

        public void EtkinlikYaz()
        {
            DataTable dtetkinlikler = new DataTable();
            dtetkinlikler = db.etkinlikListele();
            dtgvEtkinlikler.DataSource = dtetkinlikler;
            this.dtgvEtkinlikler.Columns["ID"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_author"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_date"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_date"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_date_gmt"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_status"].Visible = false;
            this.dtgvEtkinlikler.Columns["ping_status"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_password"].Visible = false;
            this.dtgvEtkinlikler.Columns["to_ping"].Visible = false;
            this.dtgvEtkinlikler.Columns["pinged"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_modified"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_modified_gmt"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_content_filtered"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_parent"].Visible = false;
            this.dtgvEtkinlikler.Columns["menu_order"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_mime_type"].Visible = false;
            this.dtgvEtkinlikler.Columns["comment_count"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_content"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_excerpt"].Visible = false;
            this.dtgvEtkinlikler.Columns["comment_count"].Visible = false;
            this.dtgvEtkinlikler.Columns["comment_status"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_name"].Visible = false;
            this.dtgvEtkinlikler.Columns["guid"].Visible = false;
            this.dtgvEtkinlikler.Columns["post_type"].Visible = false;

            dtgvEtkinlikler.Columns["post_title"].HeaderText = "ETKİNLİK ADI";

            int uzunluk = dtetkinlikler.Rows.Count;
            uzunluk -= 1;
            dtetkinlikler.DefaultView.RowFilter = "post_type='tribe_events' AND post_status='publish'";

        }

        public void DuyuruYaz()
        {
            DataTable dtduyuru = new DataTable();
            dtduyuru = db.duyuruListele();
            dtgvDuyurular.DataSource = dtduyuru;
            this.dtgvDuyurular.Columns["ID"].Visible = false;
            this.dtgvDuyurular.Columns["Date"].Visible = false;
            this.dtgvDuyurular.Columns["Category"].Visible = false;
            this.dtgvDuyurular.Columns["URL"].Visible = false;
            this.dtgvDuyurular.Columns["Author"].Visible = false;
            dtduyuru.DefaultView.RowFilter = string.Format("Category LIKE '%{0}%'", "Duyurular");
            dtgvDuyurular.Columns["Title"].HeaderText = "DUYURU ADI";
        }



        public void GorevGoruntule()
        {
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    baslik[i].Visible = false;
                    labels[i].Visible = false;
                    buton[i].Visible = false;
                    pb[i].Visible = false;
                }


                toplamGorev = 0;
                listBoxGorevlerim.Items.Clear();
                DataTable dt = db.gorevleriListeleme(grvID.ToString());
                toplamGorev = dt.Rows.Count;


                if (toplamGorev < 9)
                {
                    for (int i = 0; i < toplamGorev; i++)
                    {
                        // kutucukların gözükmesi için
                        baslik[i].Visible = true;
                        labels[i].Visible = true;
                        buton[i].Visible = true;
                        pb[i].Visible = true;


                        string gAd = dt.Rows[i]["Isim"].ToString();
                        listBoxGorevlerim.Items.Add(gAd);

                        labels[i].Text = gAd;

                    }
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        // kutucukların gözükmesi için
                        baslik[i].Visible = true;
                        labels[i].Visible = true;
                        buton[i].Visible = true;
                        pb[i].Visible = true;

                        string gAd = dt.Rows[i]["Isim"].ToString();
                        labels[i].Text = gAd;
                    }

                    for (int i = 0; i < toplamGorev; i++)
                    {
                        string gAd = dt.Rows[i]["Isim"].ToString();
                        listBoxGorevlerim.Items.Add(gAd);

                    }
                }


            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                this.Close();
            }
        }

        public void TopDuyuru()
        {
            try
            {
                // Üyenin toplantı duyurularından okunmayan duyuruları gösterme
                DataTable dtTopD = db.topOkumaDurum(grvID.ToString());
                int toplam = dtTopD.Rows.Count;

                for (int i = 0; i < toplam; i++)
                {

                    int topDurum = Convert.ToInt32(dtTopD.Rows[i]["OkuDurum"]);
                    string topAd = dtTopD.Rows[i]["Isim"].ToString();
                    int topID = Convert.ToInt32(dtTopD.Rows[i]["ID"]);

                    if (topDurum == 0)
                    {
                        try
                        {
                            MessageBox.Show(topAd + " isimli toplantıya davetlisiniz !\nToplantı bilgileri için lütfen Toplantılar bölümünden ilgili toplantıyı seçiniz.");
                            db.topOkuDurumGuncelle(grvID, topID);
                        }
                        catch (Exception hata)
                        {

                            MessageBox.Show(hata.Message);
                        }

                    }


                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
           
        }

        public void YetkiYazma()
        {
           
                if (kGor == "var")
                {
                    listByetkilerim.Items.Add("Kayıt Görüntüleme");
                }

            if (pGor=="var")
            {
                listByetkilerim.Items.Add("Proje Görüntüleme");
            }

            if (projeler.prjGor == "var")
            {
                listByetkilerim.Items.Add("Tüm Projeleri Görüntüleme");
            }

            if (projeler.prjKay=="var")
            {
                listByetkilerim.Items.Add("Proje Kayıtlarını Düzenleme");
            }

            if (tGor=="var")
            {
                listByetkilerim.Items.Add("Toplantı Görüntüleme");
            }

            if (toplantilar.topGor=="var")
            {
                listByetkilerim.Items.Add("Tüm Toplantıları Görüntüleme");
            }

            if (toplantilar.topKay=="var")
            {
                listByetkilerim.Items.Add("Toplantı Kayıtlarını Düzenleme");
            }

            if (gGor=="var")
            {
                listByetkilerim.Items.Add("Görev Görüntüleme");
            }

            if (gorevler.gorevGo=="var")
            {
                listByetkilerim.Items.Add("Tüm Görevleri Görüntüleme");
            }

            if (gorevler.gorevKay=="var")
            {
                listByetkilerim.Items.Add("Görev Kayıtlarını Düzenleme");
            }

            if (Kayitlar.uyeGor=="var")
            {
                listByetkilerim.Items.Add("Üye Listesi Görüntüleme");
            }

            if (Kayitlar.uyeKay=="var")
            {
                listByetkilerim.Items.Add("Üye Kayıtlarını Düzenleme");
            }

            if (Kayitlar.grvGor=="var")
            {
                listByetkilerim.Items.Add("Görevli Listesi Görüntüleme");
            }

            if (Kayitlar.grvKay=="var")
            {
                listByetkilerim.Items.Add("Görevli Kayıtlarını Düzenleme");
            }

            if (Kayitlar.refGor=="var")
            {
                listByetkilerim.Items.Add("Referans Listesi Görüntüleme");
            }

            if (Kayitlar.refKay=="var")
            {
                listByetkilerim.Items.Add("Referans Kayıtları Düzenleme");
            }

            
        }

        public void LogKayit(string islem)
        {
            // log için son logID alındı
            DataTable dtLog = new DataTable();
            dtLog = db.sonLogIDoku();
            sonLogID = db.sonLogID;

            sonLogID += 1;
          
            db.logKayit(sonLogID, grvID.ToString(), Ad, Soyad, grvSehir, grvSirket, grvIP, macAdres, grvEn, grvBoy, islem, tarih, saat);
        }
    }
}
