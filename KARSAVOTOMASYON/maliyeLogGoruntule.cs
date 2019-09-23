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
    public partial class maliyeLogGoruntule : Form
    {
        public maliyeLogGoruntule()
        {
            InitializeComponent();
        }

        string seciliID;

        dbEngine db = new dbEngine();

        public MySqlConnection mySqlCon = new MySqlConnection("Server=89.252.183.112;Database=karsavor_sistemdb;Uid=karsavor_furkan;Pwd=Furkan.123;SslMode = None;Convert Zero Datetime=true;Character Set=utf8;");
        MySqlCommand command;
        MySqlCommand command2;
        MySqlDataAdapter da;

        byte[] yeniimg;
        byte[] eskiimg;

        private void maliyeLogGoruntule_Load(object sender, EventArgs e)
        {
            seciliID = maliye.sID;
            mySqlCon.Open();
            string selectQuery = "SELECT * FROM karsavor_sistemdb.maliyeLogList WHERE ID= '" + seciliID + "' ";
            command2 = new MySqlCommand(selectQuery, mySqlCon);
            da = new MySqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
          
            yeniimg = (byte[])dt2.Rows[0][13];
            MemoryStream ms = new MemoryStream(yeniimg);
            ePic.Image = Image.FromStream(ms);

            eskiimg = (byte[])dt2.Rows[0][12];
            MemoryStream ms2 = new MemoryStream(eskiimg);
            yPic.Image = Image.FromStream(ms2);
            da.Dispose();

            lblYsor.Text = dt2.Rows[0]["SorumluKisi"].ToString();
            lbleSor.Text = dt2.Rows[0]["eSorumluKisi"].ToString();
            lblyTur.Text = dt2.Rows[0]["Tur"].ToString();
            lbleTur.Text = dt2.Rows[0]["eTur"].ToString();
            txtYaciklama.Text = dt2.Rows[0]["Aciklama"].ToString();
            txtEaciklama.Text = dt2.Rows[0]["eAciklama"].ToString();
            lblyTutar.Text = dt2.Rows[0]["Tutar"].ToString();
            lbleTutar.Text = dt2.Rows[0]["eTutar"].ToString();
            lblyOlus.Text = dt2.Rows[0]["Olusturan"].ToString();
            lbleOlus.Text = dt2.Rows[0]["eOlusturan"].ToString();
            mySqlCon.Close();

        }
    }
}
