using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Xml;
using System.Management;

namespace KARSAVOTOMASYON
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        public static int toplamToplanti;
        public static int eksikGorev;
        public static int eksikGorevSayi;
        public static int yapilanGorevSayi;

        string verilenT, yapilanT;

        AnaForm ac = new AnaForm();

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //  tam yetkili kalıcı hesap
            if (txtKul.Text=="admin" && txtSifre.Text=="123")
            {
                AnaForm.kGor = "var";
                AnaForm.pGor = "var";
                AnaForm.tGor = "var";
                AnaForm.gGor = "var";

                Kayitlar.uyeGor = "var";
                Kayitlar.uyeKay = "var";
                Kayitlar.grvGor = "var";
                Kayitlar.grvKay = "var";
                Kayitlar.refGor = "var";
                Kayitlar.refKay = "var";

                projeler.prjGor = "var";
                projeler.prjKay = "var";

                toplantilar.topGor = "var";
                toplantilar.topKay = "var";

                gorevler.gorevGo = "var";
                gorevler.gorevKay = "var";


                Kayitlar ky = new Kayitlar();
                ac.ShowDialog();
            }

            try
            {
                
                dbEngine db = new dbEngine();
                DataTable dt = db.GirisYap(txtKul.Text.Trim(), txtSifre.Text.Trim());


                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız");
                }
                else
                {
                    
                    this.Hide();
                    // GİRİŞ BİLGİLERİ DOLDURMA --------------------------
                    
                    AnaForm.grvID = Convert.ToInt32(dt.Rows[0]["ID"]);
                    int uyeID = AnaForm.grvID;
                    AnaForm.Ad = dt.Rows[0]["Isim"].ToString();
                    AnaForm.Soyad = dt.Rows[0]["Soyisim"].ToString();
                    AnaForm.Pozisyon = dt.Rows[0]["Pozisyon"].ToString();

                    
                    // üye listesinden üyenin bölümünü alma
                    DataTable dtUB = db.uyeBilgi(uyeID);
                    AnaForm.Bolum = dtUB.Rows[0]["Bolum"].ToString();
               
                    // üyenin içinde olduğu proje isimlerini alma
                    DataTable dtpUB = db.prjUyeBilgi(uyeID);
                    
                    int toplamProje = dtpUB.Rows.Count;
                    for (int i = 0; i < toplamProje; i++)
                    {
                        AnaForm.Projeler += dtpUB.Rows[i]["ProjeAd"].ToString() + "\n";
                    }
                   
                    // Üyenin katılmadığı toplantıları topUyeList den alma
                    DataTable dtTopU = db.topEksikUyeBilgi(uyeID);
                     toplamToplanti = dtTopU.Rows.Count;
                    
                    

                    for (int i = 0; i < toplamToplanti; i++)
                    {
                        
                        string durum = dtTopU.Rows[i]["Katilmama"].ToString();
                       
                        if (durum == "VAR")
                        {

                           
                            AnaForm.KatTop += dtTopU.Rows[i]["Isim"].ToString() + "\n";
                            
                        }


                    }



                    // Üyenin zamanında yapmadığı görev sayısını belirleme
                    DataTable dtGorev = db.eskiGorevleriListeleme(uyeID.ToString());
                    eksikGorev = dtGorev.Rows.Count;



                    for (int i = 0; i < eksikGorev; i++)
                    {

                         verilenT = dtGorev.Rows[i]["SonTarih"].ToString();

                         yapilanT = dtGorev.Rows[i]["YapildigiTarih"].ToString();

                        // verilenT = verilen son görev tarihi, değişkenin içinden sadece tarih bilgisini split ile alıyorum
                        if (yapilanT != null)
                        {
                            for (int a = 0; a < verilenT.Split(' ').Length; a++)
                            {
                                verilenT = verilenT.Split(' ')[a];

                            }

                            TimeSpan ts = Convert.ToDateTime(verilenT) - Convert.ToDateTime(yapilanT);

                            if (ts.TotalDays < 0)
                            {

                                eksikGorevSayi++;


                            }
                            else
                            {
                                yapilanGorevSayi++;
                            }
                        }
                        
                       

                    }
                    

                    

                    AnaForm.kGor = dt.Rows[0]["KayitGo"].ToString();
                    AnaForm.pGor = dt.Rows[0]["ProjeGo"].ToString();
                    AnaForm.tGor = dt.Rows[0]["TopGo"].ToString();
                    AnaForm.gGor = dt.Rows[0]["GorevGo"].ToString();

                    Kayitlar.uyeGor = dt.Rows[0]["UyeGo"].ToString();
                    Kayitlar.uyeKay = dt.Rows[0]["UyeKay"].ToString();
                    Kayitlar.grvGor = dt.Rows[0]["GrvGo"].ToString();
                    Kayitlar.grvKay = dt.Rows[0]["GrvKay"].ToString();
                    Kayitlar.refGor = dt.Rows[0]["RefGo"].ToString();
                    Kayitlar.refKay = dt.Rows[0]["RefKay"].ToString();

                    projeler.prjGor = dt.Rows[0]["TumProjeGor"].ToString();
                    projeler.prjKay = dt.Rows[0]["ProjeKay"].ToString();

                    toplantilar.topGor = dt.Rows[0]["TumTopGor"].ToString();
                    toplantilar.topKay = dt.Rows[0]["TopKay"].ToString();

                    gorevler.gorevGo = dt.Rows[0]["TumGorevGor"].ToString();
                    gorevler.gorevKay = dt.Rows[0]["GorevKay"].ToString();

                    maliye.maliyeGo = dt.Rows[0]["maliyeGo"].ToString();
                    maliye.maliyeKay = dt.Rows[0]["maliyeKay"].ToString();



                    Kayitlar ky = new Kayitlar();
                    ac.ShowDialog();
                    
                   
                }

            }
            catch (Exception hata)
            {
               
                    MessageBox.Show(hata.Message);
               
                
                Application.Exit();

            }

        }

        public void AnaFormAc()
        {
            
            ac.ShowDialog();
        }

        public void CheckForUpdates()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("versiyonun yazdığı txt dosyası dropbox linki sonu dl=0 ile");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream());
            string newestversion = sr.ReadToEnd();
            string currentversion = Application.ProductVersion;
            if (newestversion.Contains(currentversion))
            {

                txtKul.Enabled = true;
                txtSifre.Enabled = true;
                btnGiris.Enabled = true;

            }
            else
            {
                MessageBox.Show("Güncelleme Var, Lütfen Yeni Güncellemeyi İndiriniz!\n(Yeni Güncellemeyi Kayıt Etmeniz Önerilir)");
                WebBrowser1.Navigate("son versiyon exe dosyasası dropbox linki sonu dl=1 ile");


            }

        }

        

        private string MAC()
        {
            ManagementClass manager = new ManagementClass("Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject obj in manager.GetInstances())
            {
                if ((bool)obj["IPEnabled"])
                {
                    return obj["MacAddress"].ToString();
                }
            }
            return String.Empty;
        }



        public void yerbul()
        {

            XmlTextReader okuyucum = new XmlTextReader("http://www.ip-api.com/xml");
            while (okuyucum.Read())
            {
                if (okuyucum.NodeType==XmlNodeType.Element)
                {

                   
                    if (okuyucum.Name == "city")
                    {
                        okuyucum.Read();
                        AnaForm.grvSehir = okuyucum.Value.ToString();
                    }

                    if (okuyucum.Name == "org")
                    {
                        okuyucum.Read();
                        AnaForm.grvSirket = okuyucum.Value.ToString();
                    }

                    if (okuyucum.Name == "query")
                    {
                        okuyucum.Read();
                        AnaForm.grvIP = okuyucum.Value.ToString();
                    }

                    if (okuyucum.Name == "lat")
                    {
                        okuyucum.Read();
                        AnaForm.grvEn = okuyucum.Value.ToString();
                    }

                    if (okuyucum.Name == "lon")
                    {
                        okuyucum.Read();
                        AnaForm.grvBoy = okuyucum.Value.ToString();
                    }
                }
            }

            okuyucum.Close();

        }



        private void Login_Load(object sender, EventArgs e)
        {
            AnaForm af = new AnaForm();
            af.timer1.Enabled = true;
            af.timer1.Start();

            AnaForm.macAdres = MAC();            
            yerbul();
          
            txtKul.Enabled = false;
            txtSifre.Enabled = false;
            btnGiris.Enabled = false;
            CheckForUpdates();
           

        }
    }
}
