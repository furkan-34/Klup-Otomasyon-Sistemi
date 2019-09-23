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
    public partial class projeler : Form
    {
        public projeler()
        {
            InitializeComponent();
        }


        // GENEL BOŞLUK

        dbEngine db = new dbEngine();
        DataTable dtPrj = new DataTable();
        DataTable dtPrjUye = new DataTable();

        public static int btnPrjduzen = 0;
        string sID;
        string sAd;
        string prjYetki;

        public static string prjID, prjAd, prjAck, prjUyeler, prjAdmin;
        public static string prjGor, prjKay;
       

        private void btnPrjYeni_Click(object sender, EventArgs e)
        {
           
        }

        private void projeler_Load(object sender, EventArgs e)
        {

           


            if (prjGor=="var")
            {
                dtgvProjeler.Visible = true;
                dtgvPrjUyeList.Visible = true;
            }
            else
            {
                dtgvProjeler.Visible = true;
                dtgvPrjUyeList.Visible = false;
                btnPrjYenile.Enabled = false;
                btnPrjUyeYenile.Enabled = false;
                prjYetki = "yok";

            }

            if (prjKay == "var")
            {
                btnPrjSil.Enabled = true;
                btnPrjDuzenle.Enabled = true;
                btnPrjYeni.Enabled = true;
            }
            else
            {
                btnPrjSil.Enabled = false;
                btnPrjDuzenle.Enabled = false;
                btnPrjYeni.Enabled = false;
            }

            try
            {
                if (prjYetki=="yok")
                {
                    dtPrj = db.projelerimListele(AnaForm.grvID.ToString());
                    dtPrjUye = db.prjUyeListeleme();

                    dtgvProjeler.DataSource = dtPrj;
                    dtgvPrjUyeList.DataSource = dtPrjUye;

                    this.dtgvProjeler.Columns["ID"].Visible = false;
                    this.dtgvProjeler.Columns["Isim"].Visible = false;
                    this.dtgvProjeler.Columns["Soyisim"].Visible = false;
                    this.dtgvProjeler.Columns["OgrenciNO"].Visible = false;
                    this.dtgvProjeler.Columns["ProjeID"].Visible = false;
                    this.dtgvProjeler.Columns["ID"].Visible = false;

                    this.dtgvProjeler.Columns["Aciklama"].Visible = false;
                    this.dtgvProjeler.Columns["Uyeler"].Visible = false;

                    dtgvProjeler.Columns[4].HeaderText = "Proje Adı";
                    dtgvProjeler.Columns[6].HeaderText = "Proje  Yöneticisi";


                }
                else
                {
                    dtPrj = db.prjListeleme();
                    dtPrjUye = db.prjUyeListeleme();

                    dtgvProjeler.DataSource = dtPrj;
                    dtgvPrjUyeList.DataSource = dtPrjUye;
                }
          

                this.dtgvProjeler.Columns["ID"].Visible = false;
                this.dtgvProjeler.Columns["Aciklama"].Visible = false;
                this.dtgvProjeler.Columns["Uyeler"].Visible = false;

                this.dtgvPrjUyeList.Columns["ID"].Visible = false;
                this.dtgvPrjUyeList.Columns["OgrenciNO"].Visible = false;
                this.dtgvPrjUyeList.Columns["ProjeID"].Visible = false;
                this.dtgvPrjUyeList.Columns["Aciklama"].Visible = false;
                this.dtgvPrjUyeList.Columns["Uyeler"].Visible = false;



                dtgvProjeler.Columns[1].HeaderText = "Proje Adı";
                dtgvProjeler.Columns[4].HeaderText = "Proje  Yöneticisi";

                dtgvPrjUyeList.Columns[1].HeaderText = "İsim";
                dtgvPrjUyeList.Columns[2].HeaderText = "Soyisim";
                dtgvPrjUyeList.Columns[4].HeaderText = "Proje Adı";
                dtgvPrjUyeList.Columns[6].HeaderText = "Proje Yöneticisi";

               


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

        private void btnPrjKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrjYenile_Click(object sender, EventArgs e)
        {

        }

        private void btnPrjSil_Click(object sender, EventArgs e)
        {
            prjSil();
        }


        void prjSil()
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    sID = dtgvProjeler.CurrentRow.Cells["ID"].Value.ToString();


                    db.prjSil(sID);
                    db.prjUyeListesindenSil(sID);
                    btnPrjYenile.PerformClick();

                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }

                AnaForm ana = new AnaForm();
                string islem = "Proje Silme, " + sAd + "-" + sID;
                ana.LogKayit(islem);
            }
        }

        void yenilePrj()
        {
            try
            {
                dtgvProjeler.DataSource = db.prjListeleme();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        void yenilePrjU()
        {
            try
            {
                dtgvPrjUyeList.DataSource = db.prjUyeListeleme();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void btnPrjKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrjUyelerKpt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvProjeler_SelectionChanged(object sender, EventArgs e)
        {
            secimiDoldur();
        }

        void secimiDoldur()
        {
            try
            {
                lblPrjAd.Text = "";
                txtPrjAcik.Text = "";
                lblPrjAdmin.Text = "";
                txtPrjUye.Text = "";

                

                lblPrjAd.Text = dtgvProjeler.CurrentRow.Cells["ProjeAd"].Value.ToString();
                lblPrjAdmin.Text = dtgvProjeler.CurrentRow.Cells["ProjeAdmin"].Value.ToString();
                txtPrjAcik.Text = dtgvProjeler.CurrentRow.Cells["Aciklama"].Value.ToString();
                txtPrjUye.Text = dtgvProjeler.CurrentRow.Cells["Uyeler"].Value.ToString();
                


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




        void prjDuzenle()
        {
            prjID = dtgvProjeler.CurrentRow.Cells["ID"].Value.ToString();
            prjAd = dtgvProjeler.CurrentRow.Cells["ProjeAd"].Value.ToString();
            prjAck = dtgvProjeler.CurrentRow.Cells["Aciklama"].Value.ToString();
            prjUyeler = dtgvProjeler.CurrentRow.Cells["Uyeler"].Value.ToString();
            prjAdmin = dtgvProjeler.CurrentRow.Cells["ProjeAdmin"].Value.ToString();




            btnPrjduzen = 1;


            yeniProje dznPrj = new yeniProje();
            dznPrj.ShowDialog();

        }

        private void btnPrjYenile_Click_1(object sender, EventArgs e)
        {
            yenilePrj();
        }

        private void btnPrjUyeYenile_Click(object sender, EventArgs e)
        {
            yenilePrjU();
        }

        private void btnPrjYeni_Click_1(object sender, EventArgs e)
        {
            yeniProje yp = new yeniProje();
            yp.ShowDialog();

           btnPrjduzen = 0;
    }

        private void btnPrjDuzenle_Click(object sender, EventArgs e)
        {
            prjDuzenle();
        }
    }
}
