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
    public partial class gorevler : Form
    {
        public gorevler()
        {
            InitializeComponent();
        }

        // GENEL BOŞLUK

        dbEngine db = new dbEngine();

        DataTable dtGorevY = new DataTable();
        DataTable dtGorevE = new DataTable();

        string sYID, sYUAD, sYGAD;

        string sgAd, sgKat, sgAdSo, sgTar, sgStar, sgVeren, sgIcer ,sgRapor;

        public static string gorevGo, gorevKay;

        private void gorevler_Load(object sender, EventArgs e)
        {
         


            try
            {
                if (gorevGo=="var")
            {
                dtGorevY = db.yeniGorevListeleme();
                dtGorevE = db.gecmisGorevListeleme();

                dtgvYeniGorevler.DataSource = dtGorevY;
                dtgvGecmisGorevler.DataSource = dtGorevE;
                }
                else
                {
                    DataTable dt = db.gorevleriListeleme(AnaForm.grvID.ToString());
                    DataTable dt2 = db.eskiGorevleriListeleme(AnaForm.grvID.ToString());
                    dtgvYeniGorevler.DataSource = dt;
                    dtgvGecmisGorevler.DataSource = dt2;

                }

                if (gorevKay=="var")
                {
                    btnGrvSil.Enabled = true;
                    btnGrvYeni.Enabled = true;
                    
                }
                else
                {
                    btnGrvSil.Enabled = false;
                    btnGrvYeni.Enabled = false;
                }


                this.dtgvYeniGorevler.Columns["ID"].Visible = false;
                this.dtgvYeniGorevler.Columns["Kimden"].Visible = false;
                this.dtgvYeniGorevler.Columns["GorevliID"].Visible = false;
                this.dtgvYeniGorevler.Columns["Icerik"].Visible = false;
                this.dtgvYeniGorevler.Columns["SonTarih"].Visible = false;
                this.dtgvYeniGorevler.Columns["VerildigiTarih"].Visible = false;

                dtgvYeniGorevler.Columns[1].HeaderText = "Görev Adı";
                dtgvYeniGorevler.Columns[2].HeaderText = "Kategorisi";
                dtgvYeniGorevler.Columns[4].HeaderText = "Görevli Adı Soyadı";
             
               
             //-----------------------------------------------------------------------
                this.dtgvGecmisGorevler.Columns["ID"].Visible = false;
            
                this.dtgvGecmisGorevler.Columns["GorevliID"].Visible = false;
                this.dtgvGecmisGorevler.Columns["Kategori"].Visible = false;
                this.dtgvGecmisGorevler.Columns["Icerik"].Visible = false;
                this.dtgvGecmisGorevler.Columns["SonTarih"].Visible = false;
                this.dtgvGecmisGorevler.Columns["VerildigiTarih"].Visible = false;
                this.dtgvGecmisGorevler.Columns["Rapor"].Visible = false;

                dtgvGecmisGorevler.Columns[1].HeaderText = "Görev Adı";
                dtgvGecmisGorevler.Columns[4].HeaderText = "Görevli Ad Soyad";
                dtgvGecmisGorevler.Columns[5].HeaderText = "Görevi Veren";
             

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                Application.Exit();
            }
           
        }

        private void btnGrvYeni_Click(object sender, EventArgs e)
        {
            yeniGorev yg = new yeniGorev();
            yg.ShowDialog();
        }

        private void btnGrvYenile_Click(object sender, EventArgs e)
        {
            try
            {
                if (gorevGo == "var")
                {
                    dtGorevY = db.yeniGorevListeleme();
                    dtgvYeniGorevler.DataSource = dtGorevY;

                    
                }
                else
                {
                    DataTable dt = db.gorevleriListeleme(AnaForm.grvID.ToString());
                    dtgvYeniGorevler.DataSource = dt;

                }

                this.dtgvYeniGorevler.Columns["ID"].Visible = false;
                this.dtgvYeniGorevler.Columns["GorevliAdSoyad"].Visible = false;
                this.dtgvYeniGorevler.Columns["GorevliID"].Visible = false;

                dtgvYeniGorevler.Columns[1].HeaderText = "Görev Adı";
                dtgvYeniGorevler.Columns[2].HeaderText = "Kategorisi";
                dtgvYeniGorevler.Columns[3].HeaderText = "Görev İçeriği";
                dtgvYeniGorevler.Columns[5].HeaderText = "Görevi Veren";
                dtgvYeniGorevler.Columns[6].HeaderText = "Görevin Son Tarihi";
                dtgvYeniGorevler.Columns[8].HeaderText = "Görevin Verildiği Tarih";
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                Application.Exit();
            }
            
        }

        private void btnGrvSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    db.gorevSil(sYID);
                  
                    btnGrvYenile.PerformClick();

                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }

                AnaForm ana = new AnaForm();
                string islem = "Görev Silme, " + sYUAD + "-" + sYGAD;
                ana.LogKayit(islem);
            }
        }

        private void dtgvYeniGorevler_SelectionChanged(object sender, EventArgs e)
        {
          sYID = dtgvYeniGorevler.CurrentRow.Cells["ID"].Value.ToString();
            sYUAD = dtgvYeniGorevler.CurrentRow.Cells["GorevliAdSoyad"].Value.ToString();
            sYGAD = dtgvYeniGorevler.CurrentRow.Cells["Isim"].Value.ToString();

            secimidoldurYeni();

        }

        private void dtgvGecmisGorevler_SelectionChanged(object sender, EventArgs e)
        {
            secimidoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (gorevGo == "var")
            {

                dtGorevE = db.gecmisGorevListeleme();
                dtgvGecmisGorevler.DataSource = dtGorevE;
            }
            else
            {
                DataTable dt2 = db.eskiGorevleriListeleme(AnaForm.grvID.ToString());
                dtgvGecmisGorevler.DataSource = dt2;

            }
        }

        private void secimidoldur()
        {
            string sgAd, sgKat, sgAdSo, sgTar, sgStar, sgVeren, sgRapor;

            sgAd = dtgvGecmisGorevler.CurrentRow.Cells["Isim"].Value.ToString();
            sgKat = dtgvGecmisGorevler.CurrentRow.Cells["Kategori"].Value.ToString();
            sgAdSo = dtgvGecmisGorevler.CurrentRow.Cells["GorevliAdSoyad"].Value.ToString();
            sgTar = dtgvGecmisGorevler.CurrentRow.Cells["VerildigiTarih"].Value.ToString();
            sgStar = dtgvGecmisGorevler.CurrentRow.Cells["SonTarih"].Value.ToString();
            sgVeren = dtgvGecmisGorevler.CurrentRow.Cells["Kimden"].Value.ToString();
            sgIcer = dtgvGecmisGorevler.CurrentRow.Cells["Icerik"].Value.ToString();
            sgRapor = dtgvGecmisGorevler.CurrentRow.Cells["Rapor"].Value.ToString();

            txtGorAd.Text = sgAd;
            txtGorAdSoy.Text = sgAdSo;
            txtGorIcer.Text = sgIcer;
            txtGorKat.Text = sgKat;
            txtGorRapor.Text = sgRapor;
            txtGorSonTar.Text = sgStar;
            txtGorTarih.Text = sgTar;
            lblGorVeren.Text = sgVeren;

           
        }

        void secimidoldurYeni()
        {
            // yeni görev önizlemesi için

            txtYgorAd.Text = dtgvYeniGorevler.CurrentRow.Cells["Isim"].Value.ToString();
            txtYgorKat.Text = dtgvYeniGorevler.CurrentRow.Cells["Kategori"].Value.ToString();
            txtYgorAdS.Text = dtgvYeniGorevler.CurrentRow.Cells["GorevliAdSoyad"].Value.ToString();
            txtYgorVerTar.Text = dtgvYeniGorevler.CurrentRow.Cells["VerildigiTarih"].Value.ToString();
            txtYgorVerStar.Text = dtgvYeniGorevler.CurrentRow.Cells["SonTarih"].Value.ToString();
            txtYgorIcerik.Text = dtgvYeniGorevler.CurrentRow.Cells["Icerik"].Value.ToString();

            lblYgorVeren.Text = dtgvYeniGorevler.CurrentRow.Cells["Kimden"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrvKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
