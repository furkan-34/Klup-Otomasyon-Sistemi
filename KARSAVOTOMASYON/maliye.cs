using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace KARSAVOTOMASYON
{
    public partial class maliye : Form
    {
        public maliye()
        {
            InitializeComponent();
        }

        dbEngine db = new dbEngine();

        public MySqlConnection mySqlCon = new MySqlConnection("Server=89.252.183.112;Database=karsavor_sistemdb;Uid=karsavor_furkan;Pwd=Furkan.123;SslMode = None;Convert Zero Datetime=true;Character Set=utf8;");
        MySqlCommand command;
        MySqlCommand command2;
        MySqlDataAdapter da;

        public static string maliyeGo, maliyeKay;

        string adFoto;
        int id, toplamKasa;
       public static string sID, sGrvID, sGrvAd;
        string sonIDst;
        int sonID;
        string stutar, olusturan;
        int olusturanID;
        int tutar;
        string sSorAd, sSorID, sTur, sAciklama, sTutar, sMakbuz, sOlus, sOlusID;
        string sMsorAd, sMsorID, sMTur, sMaciklama, sMTutar, sMmakbuz, sMOlus, sMOlusID;

        byte[] img2;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *png; *.gif |*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if (lblSorumluYeni.Text != "" && comboTur.Text != "" && txtTutarYeni.Text != "" && txtAciklamaYeni.Text != "")
            {
                try
                {
                    RaporGir();

                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Boşlukları Doldurunuz!");
            }
        }

        private void dtgvMaliyeLog_DoubleClick(object sender, EventArgs e)
        {
            sID = dtgvMaliyeLog.CurrentRow.Cells["ID"].Value.ToString();
            maliyeLogGoruntule ml = new maliyeLogGoruntule();
            ml.ShowDialog();
        }

        private void btnUyeKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

            RaporGir();
          

        }

        private void RaporGir()
        {
            
           
            


            DataTable dt3 = new DataTable();
            dt3 = db.maliyeSonID();
            sonIDst = db.sonIDst;

            sonID = Convert.ToInt32(sonIDst);
            sonID += 1;

          
            if (comboTur.Text=="ÇIKTI")
            {
                stutar = "-" +txtTutarYeni.Text.Trim();
                tutar = Convert.ToInt32(stutar);
               
            }
            else
            {
                tutar = Convert.ToInt32(txtTutarYeni.Text.Trim());
            }
           
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            string insertQuery = "INSERT INTO karsavor_sistemdb.maliyeList(ID, SorumluKisi, SorumluID, Tur, Aciklama, Tutar, Makbuz, Olusturan, OlusturanID) VALUES (@id, @sorumlu, @sorumluid, @tur, @aciklama, @tutar, @makbuz, @olusturan, @olusturanid)";

            mySqlCon.Open();

            command = new MySqlCommand(insertQuery, mySqlCon);

            command.Parameters.Add("@id", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@sorumlu", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@sorumluid", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@tur", MySqlDbType.VarChar, 50);
            command.Parameters.Add("@aciklama", MySqlDbType.VarChar, 300);
            command.Parameters.Add("@tutar", MySqlDbType.VarChar, 100);
            command.Parameters.Add("@makbuz", MySqlDbType.LongBlob);
            command.Parameters.Add("@olusturan", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@olusturanid", MySqlDbType.UInt16, 255);

            command.Parameters["@id"].Value = sonID;
            command.Parameters["@sorumlu"].Value = sGrvAd;
            command.Parameters["@sorumluid"].Value = sGrvID;
            command.Parameters["@tur"].Value = comboTur.Text.Trim();
            command.Parameters["@aciklama"].Value = txtAciklamaYeni.Text.Trim();
            command.Parameters["@tutar"].Value = tutar;
            command.Parameters["@makbuz"].Value = img;
            command.Parameters["@olusturan"].Value =olusturan ;
            command.Parameters["@olusturanid"].Value = AnaForm.grvID;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Yeni Maliye Kaydı Eklendi.");
            }

            mySqlCon.Close();
            MaliyeListe();
        }

        private void resimGoster()
        {
            string selectQuery = "SELECT * FROM karsavor_sistemdb.maliyeList WHERE ID= '" + sID + "' ";
            command2 = new MySqlCommand(selectQuery, mySqlCon);
            da = new MySqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);

        
            byte[] img2 = (byte[])dt2.Rows[0][6];

            MemoryStream ms2 = new MemoryStream(img2);
            pictureBox1.Image = Image.FromStream(ms2);
            da.Dispose();
        }

        private void seciliResimCek()
        {
            string selectQuery = "SELECT * FROM karsavor_sistemdb.maliyeList WHERE ID= '" + sID + "' ";
            command2 = new MySqlCommand(selectQuery, mySqlCon);
            da = new MySqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);


            img2 = (byte[])dt2.Rows[0][6];
            
            da.Dispose();
        }

        private void maliye_Load(object sender, EventArgs e)
        {
            if (maliyeGo == "var")
            {
                try
                {
                    MaliyeListe();
                    MaliyeLogListe();

                    this.dtgvMaliye.Columns["SorumluID"].Visible = false;
                    this.dtgvMaliye.Columns["Aciklama"].Visible = false;
                    this.dtgvMaliye.Columns["Makbuz"].Visible = false;
                    this.dtgvMaliye.Columns["OlusturanID"].Visible = false;



                    this.dtgvMaliyeLog.Columns[0].Visible = false;
                    this.dtgvMaliyeLog.Columns[4].Visible = false;

                    for (int i = 5; i < 18; i++)
                    {
                        this.dtgvMaliyeLog.Columns[i].Visible = false;
                    }

                    this.dtgvMaliyeLog.Columns[10].Visible = true;
                    this.dtgvMaliyeLog.Columns[11].Visible = true;


                    dtgvMaliyeLog.Columns[1].HeaderText = "Rapor NO";
                    dtgvMaliyeLog.Columns[2].HeaderText = "Yeni Sorumlu Kişi";
                    dtgvMaliyeLog.Columns[3].HeaderText = "Eski Sorumlu Kişi";
                    dtgvMaliyeLog.Columns[10].HeaderText = "Yeni Tutar";
                    dtgvMaliyeLog.Columns[11].HeaderText = "Eski Tutar";



                    DataTable dt4 = db.grvListeleme();
                    dtgvUyeArama.DataSource = dt4;

                    this.dtgvUyeArama.Columns[0].Visible = false;
                    for (int i = 3; i < 22; i++)
                    {
                        this.dtgvUyeArama.Columns[i].Visible = false;
                    }



                    olusturan = AnaForm.Ad + " " + AnaForm.Soyad;
                    olusturanID = AnaForm.grvID;


                    this.dtgvUyeArama.Columns["KullaniciAd"].Visible = false;
                    this.dtgvUyeArama.Columns["Sifre"].Visible = false;
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }
            }
            else
            {
                dtgvMaliye.Enabled = false;
                dtgvMaliyeLog.Enabled = false;
                dtgvUyeArama.Enabled = false;
                btnSorumlu.Enabled = false;
            }

            if (maliyeKay=="var")
            {
                btnGozat.Enabled = true;
                btnYukle.Enabled = true;
                btnUyeDuzenle.Enabled = true;
            }
            else
            {
                btnUyeDuzenle.Enabled = false;
                btnGozat.Enabled = false;
                btnYukle.Enabled = false;
            }
            
        }

        

        private void Duzenle()
        {
             sID = dtgvMaliye.CurrentRow.Cells["ID"].Value.ToString();
            int seciliID = Convert.ToInt32(sID);

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] yeniimg = ms.ToArray();

            if (comboTur.Text == "ÇIKTI")
            {
                stutar = "-" + txtTutarYeni.Text.Trim();
                tutar = Convert.ToInt32(stutar);

            }
            else
            {
                tutar = Convert.ToInt32(txtTutarYeni.Text.Trim());
            }

            MySqlCommand command = new MySqlCommand("UPDATE maliyeList set ID=@id,SorumluKisi=@sorAd,SorumluID=@sorID,Tur=@tur,Aciklama=@aciklama,Tutar=@tutar,Makbuz=@makbuz,Olusturan=@olusturan,OlusturanID=@olusturanID WHERE ID=@id",mySqlCon);



            command.Parameters.Add("@id", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@sorAd", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@sorID", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@tur", MySqlDbType.VarChar, 50);
            command.Parameters.Add("@aciklama", MySqlDbType.VarChar, 300);
            command.Parameters.Add("@tutar", MySqlDbType.VarChar, 100);
            command.Parameters.Add("@makbuz", MySqlDbType.LongBlob);
            command.Parameters.Add("@olusturan", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@olusturanID", MySqlDbType.UInt16, 255);

            command.Parameters["@id"].Value = Convert.ToInt32(seciliID);
            command.Parameters["@sorAd"].Value = sGrvAd;
            command.Parameters["@sorID"].Value = sGrvID;
            command.Parameters["@tur"].Value = comboTur.Text.Trim();
            command.Parameters["@aciklama"].Value = txtAciklamaYeni.Text.Trim();
            command.Parameters["@tutar"].Value = tutar;
            command.Parameters["@makbuz"].Value = yeniimg;
            command.Parameters["@olusturan"].Value = olusturan;
            command.Parameters["@olusturanID"].Value = AnaForm.grvID;

           
            try
            {
                ExecMyQuery(command, "Güncellendi");
               
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
           
        }

        private void logYaz()
        {
            if (comboTur.Text == "ÇIKTI")
            {
                stutar = "-" + txtTutarYeni.Text.Trim();
                tutar = Convert.ToInt32(stutar);

            }
            else
            {
                tutar = Convert.ToInt32(txtTutarYeni.Text.Trim());
            }

            DataTable dt4 = new DataTable();
            dt4 = db.maliyeLogSonID();
            sonIDst = db.sonIDst;

            sonID = Convert.ToInt32(sonIDst);
            sonID += 1;

            seciliResimCek();

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            string insertQuery = "INSERT INTO karsavor_sistemdb.maliyeLogList(ID, raporID, SorumluKisi, eSorumluKisi, SorumluID, eSorumluID, Tur, eTur, Aciklama, eAciklama, Tutar, eTutar, Makbuz, eMakbuz, Olusturan, eOlusturan, OlusturanID, eOlusturanID) VALUES (@id, @raporid, @sorumlu, @esorumlu, @sorumluid, @esorumluid, @tur, @etur, @aciklama, @eaciklama, @tutar, @etutar, @makbuz, @emakbuz, @olusturan, @eolusturan, @olusturanid, @eolusturanid)";

            mySqlCon.Open();

            command = new MySqlCommand(insertQuery, mySqlCon);

            command.Parameters.Add("@id", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@raporid", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@sorumlu", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@esorumlu", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@sorumluid", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@esorumluid", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@tur", MySqlDbType.VarChar, 50);
            command.Parameters.Add("@etur", MySqlDbType.VarChar, 50);
            command.Parameters.Add("@aciklama", MySqlDbType.VarChar, 300);
            command.Parameters.Add("@eaciklama", MySqlDbType.VarChar, 300);
            command.Parameters.Add("@tutar", MySqlDbType.VarChar, 100);
            command.Parameters.Add("@etutar", MySqlDbType.VarChar, 100);
            command.Parameters.Add("@makbuz", MySqlDbType.LongBlob);
            command.Parameters.Add("@emakbuz", MySqlDbType.LongBlob);
            command.Parameters.Add("@olusturan", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@eolusturan", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@olusturanid", MySqlDbType.UInt16, 255);
            command.Parameters.Add("@eolusturanid", MySqlDbType.UInt16, 255);

            command.Parameters["@id"].Value = sonID;
            command.Parameters["@raporid"].Value = sID;
            command.Parameters["@sorumlu"].Value = sGrvAd;
            command.Parameters["@esorumlu"].Value = sMsorAd;
            command.Parameters["@sorumluid"].Value = sGrvID;
            command.Parameters["@esorumluid"].Value = sMsorID;
            command.Parameters["@tur"].Value = comboTur.Text.Trim();
            command.Parameters["@etur"].Value = sMTur;
            command.Parameters["@aciklama"].Value = txtAciklamaYeni.Text.Trim();
            command.Parameters["@eaciklama"].Value = sMaciklama;
            command.Parameters["@tutar"].Value = tutar;
            command.Parameters["@etutar"].Value = sMTutar;
            command.Parameters["@makbuz"].Value = img;
            command.Parameters["@emakbuz"].Value = img2;
            command.Parameters["@olusturan"].Value = olusturan;
            command.Parameters["@eolusturan"].Value = sMOlus;
            command.Parameters["@olusturanid"].Value = AnaForm.grvID;
            command.Parameters["@eolusturanid"].Value = sMOlusID;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Log Yazıldı");
            }

            mySqlCon.Close();
        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            try
            {
                mySqlCon.Open();
                if (mcomd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(myMsg);
                }
                else
                {
                    MessageBox.Show("Güncellenemedi");
                }
                mySqlCon.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
            
        }

        private void MaliyeListe()
        {
            toplamKasa = 0;
            DataTable dt = db.maliyeListele();
            dtgvMaliye.DataSource = dt;

            for (int i = 0; i < dtgvMaliye.Rows.Count; i++)
            {
                int a = Convert.ToInt32(dt.Rows[i]["Tutar"].ToString());
                toplamKasa += a ;
            }
            lblKasa.Text = toplamKasa.ToString();
        }

        private void MaliyeLogListe()
        {
            DataTable dt5 = db.maliyeLogListele();
            dtgvMaliyeLog.DataSource = dt5;
        
        }

        private void dtgvMaliye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgvUyeArama_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sGrvID = dtgvUyeArama.CurrentRow.Cells["ID"].Value.ToString();
            sGrvAd = dtgvUyeArama.CurrentRow.Cells["Isim"].Value.ToString() + " " + dtgvUyeArama.CurrentRow.Cells["Soyisim"].Value.ToString();

            
        }

        private void btnSorumlu_Click(object sender, EventArgs e)
        {
            lblSorumluYeni.Text = sGrvAd;
        }

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            if (lblSorumluYeni.Text!="" && comboTur.Text != "" && txtTutarYeni.Text != "" && txtAciklamaYeni.Text != "")
            {
                try
                {
                    logYaz();
                    Duzenle();
                    MaliyeListe();
                    MaliyeLogListe();
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz!");
            }
           
         
        }

        private void txtTutarYeni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvMaliye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sID = dtgvMaliye.CurrentRow.Cells["ID"].Value.ToString();
            lblSorumluAd.Text = dtgvMaliye.CurrentRow.Cells["SorumluKisi"].Value.ToString();
            lblOlusturan.Text = dtgvMaliye.CurrentRow.Cells["Olusturan"].Value.ToString();
            lblTur.Text = dtgvMaliye.CurrentRow.Cells["TUR"].Value.ToString();
            labelTutar.Text = dtgvMaliye.CurrentRow.Cells["Tutar"].Value.ToString();
            txtAciklama.Text = dtgvMaliye.CurrentRow.Cells["Aciklama"].Value.ToString();
            resimGoster();

            sMsorAd = dtgvMaliye.CurrentRow.Cells["SorumluKisi"].Value.ToString();
            sMsorID = dtgvMaliye.CurrentRow.Cells["SorumluID"].Value.ToString();
            sMTur = dtgvMaliye.CurrentRow.Cells["Tur"].Value.ToString();
            sMaciklama = dtgvMaliye.CurrentRow.Cells["Aciklama"].Value.ToString();
            sMTutar = dtgvMaliye.CurrentRow.Cells["Tutar"].Value.ToString();
            sMOlus = dtgvMaliye.CurrentRow.Cells["Olusturan"].Value.ToString();
            sMOlusID = dtgvMaliye.CurrentRow.Cells["OlusturanID"].Value.ToString();

        }

      

        private void dtgvMaliye_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}
