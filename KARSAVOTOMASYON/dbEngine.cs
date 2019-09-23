using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;





namespace KARSAVOTOMASYON
{
    class dbEngine
    {
        public string Yol()
        {
            return "Server=tcp:**********.database.windows.net,1433;Initial Catalog=sistemdb;Persist Security Info=False;User ID=**********;Password=*****;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }


       public    string sonIDst, sonIDstList;
        public int sonLogID;

        public void baglan()
        {
            try
            {
                if (mySqlCon.State == ConnectionState.Closed)
                {
                    mySqlCon.Open();
                    sqlcon.Open();
                }

                else
                {
                    mySqlCon.Close();
                    mySqlCon.Open();

                    sqlcon.Close();
                    sqlcon.Open();

                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                Application.Exit();
            }
        }

   

        public MySqlConnection sqlcon = new MySqlConnection("Server=******;Database=karsavor_sistemdb;Uid=****;Pwd=*****;SslMode = None;Convert Zero Datetime=true;Charset=utf8");



        public void mySqlbaglan()
        {
            try
            {

                if (mySqlCon.State == ConnectionState.Closed) // tanımın durumunu kontrol ediyoruz bağlı mı değil mi
                {
                    mySqlCon.Open();
                }
                else
                {
                    mySqlCon.Close();
                    mySqlCon.Open();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

         public MySqlConnection mySqlCon = new MySqlConnection("Server=*****;Database=karsavor_sistemdb;Uid=*****;Pwd=*********;SslMode = None;Convert Zero Datetime=true;Charset=utf8");

        public void mySqlbaglan2()
        {
            try
            {

                if (mySqlCon2.State == ConnectionState.Closed) // tanımın durumunu kontrol ediyoruz bağlı mı değil mi
                {
                    mySqlCon2.Open();
                }
                else
                {
                    mySqlCon2.Close();
                    mySqlCon2.Open();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        // sol kısımdaki etkinklik ve haberler için bağlandığım wordpress veritabanı. iptal edebilir veya değiştirebilirsiniz
        public MySqlConnection mySqlCon2 = new MySqlConnection("Server=*****2;Database=karsavor_wp442;Uid=*****;Pwd=****;SslMode = None;Convert Zero Datetime=true;");
        //------------------------------------------------------------------------------------------------------------------



        public DataTable etkinlikListele()
        {

            mySqlbaglan2();

            string sql = "SELECT * FROM wprp_posts order by ID DESC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon2);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;


        }

        public DataTable duyuruListele()
        {

            mySqlbaglan2();

            string sql = "SELECT p.ID,DATE(p.post_date) Date,u.display_name Author,p.post_title Title,GROUP_CONCAT(t.name) Category,CONCAT('https://www.karsav.org/blog/', p.post_name) URL FROM wprp_posts p LEFT JOIN wprp_users u ON p.post_author = u.ID LEFT JOIN wprp_term_relationships rel ON rel.object_id = p.ID LEFT JOIN wprp_term_taxonomy tax ON(tax.term_taxonomy_id = rel.term_taxonomy_id AND tax.taxonomy = 'category') LEFT JOIN wprp_terms t ON(t.term_id = tax.term_id AND t.name != 'uncategorized') WHERE p.post_status = 'publish' and p.post_type = 'post' GROUP BY p.ID ORDER BY ID DESC; ";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon2);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;


        }

//----------------------------------------------------------------------------------------------------------------------------------

        public void uyeSil(string ID)
        {
            mySqlbaglan();

            string sql = " DELETE FROM uyeList WHERE ID=@ID";
            MySqlCommand com = new MySqlCommand(sql,mySqlCon);
            com.Parameters.AddWithValue("@ID", ID);
            com.ExecuteNonQuery();
            mySqlCon.Close();
        }




        public void uyeKayit(string ID, string yuAd, string yuSoyad, string yuBolum, string yuTel, string yuMail, string yuOgNo, string yuHava, string yuKara, string yuDeniz, string yuSiber, string yuAciklama)
        {
            mySqlbaglan();

            string sql = "INSERT INTO uyeList (ID, Isim, Soyisim, Bolum, Telefon, Mail, OgrenciNO, Hava, Kara, Deniz, Siber, Aciklama) VALUES ('"+ID+"', '"+yuAd+"','"+yuSoyad+"','"+yuBolum+"','"+yuTel+"','"+yuMail+"','"+yuOgNo+"', '"+yuHava+"', '"+yuKara+"', '"+yuDeniz+"', '"+yuSiber+"', '"+yuAciklama+"')";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);


            com.ExecuteNonQuery();
            com.Dispose();
            mySqlCon.Close();
        }



        public void uyeGuncelle(string ID, string yuAd, string yuSoyad, string yuBolum, string yuTel, string yuMail, string yuOgNo, string yuHava, string yuKara, string yuDeniz, string yuSiber, string yuAciklama)
        {
            mySqlbaglan();

            string sql = "UPDATE uyeList set ID='" + ID + "', Isim='" + yuAd + "', Soyisim='" + yuSoyad + "', Bolum='" + yuBolum + "', Telefon='" + yuTel + "', Mail='" + yuMail + "', OgrenciNO='" + yuOgNo + "', Hava='" + yuHava + "', Kara='" + yuKara + "', Deniz='" + yuDeniz + "', Siber='" + yuSiber + "', Aciklama='" + yuAciklama + "' WHERE ID='" + ID + "' ";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);





            com.ExecuteNonQuery();
            com.Dispose();
            mySqlCon.Close();
        }

        // kayıt formu açıldığında id ye göre sıralama yapılması için
        public DataTable uyeListeleme()
        {

            mySqlbaglan();

            string sql = "SELECT * FROM uyeList ORDER BY ID ASC";
            
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);
            mySqlCon.Close();
            return dt;

        }
       
        // kayıt yapılırken aynı öğrenci numarası ile kayıt yapmayı önlemek için
        public bool uyeKontrol(string OgNO) {

            mySqlbaglan();

            string sql = " SELECT * FROM uyeList WHERE OgrenciNO = @OgNO";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.SelectCommand.Parameters.AddWithValue("@OgNO", OgNO);
            sda.Fill(dt);

            if (dt.Rows.Count==0)
            {
                mySqlCon.Close();
                return true;
            }
            else
            {
                mySqlCon.Close();
                return false;
            }
            

        } 

       
      
        public DataTable uyeOkumaID()
        {

            mySqlbaglan();

            string sql = " SELECT * FROM uyeList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);

           
            sonIDst = dt.Rows[0]["ID"].ToString();
            mySqlCon.Close();
            return dt;
        }

        public DataTable uyeBilgi(int ID)
        {
            mySqlbaglan();

            string sql = " SELECT * FROM uyeList WHERE ID=@ID";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            mySqlCon.Close();
            return dt;
        }

        public DataTable GirisYap(string KullaniciAd, string Sifre)
        {
            mySqlbaglan();

            string sql = " SELECT * FROM gorevliler WHERE KullaniciAd=@KullaniciAd and Sifre=@Sifre";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            sda.SelectCommand.Parameters.AddWithValue("@Sifre", Sifre);
            sda.Fill(dt);
            mySqlCon.Close();
            return dt;
        }



        //------------------------------------------------------------------------------------------------------------------
        // GOREVLI BOLUMU

        public DataTable grvBilgi(string ID)
        {
            mySqlbaglan();

            string sql = " SELECT * FROM uyeList WHERE ID=@ID";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            mySqlCon.Close();
            return dt;
        }


        public DataTable grvListeleme()
        {

            mySqlbaglan();

            string sql = "SELECT * FROM gorevliler ORDER BY ID ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);
            mySqlCon.Close();
            return dt;

        }

        public bool grvKontrol(string ID)
        {

            mySqlbaglan();

            string sql = " SELECT * FROM gorevliler WHERE ID = @ID";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                mySqlCon.Close();
                return true;
            }
            else
            {
                mySqlCon.Close();
                return false;
            }


        }

        public void grvKayit(string ID, string sgAd, string sgSoyad, string sPoz, string yKayGor, string yPrjGor, string yTopGor, string yGorevGo, string yUyeGor, string yUyeKay, string yGrvGor, string yGrvKay, string yRefGor, string yRefKay, string tumPrjGor, string prjKay, string tumTopGor, string topKay, string tumGorevGor,string gorevKay, string ygKul, string ygSifre)
        {
            mySqlbaglan();

            string sql = "INSERT INTO gorevliler(ID, Isim, Soyisim, Pozisyon, KayitGo, ProjeGo, TopGo, GorevGo, UyeGo, UyeKay, GrvGo, GrvKay, RefGo, RefKay, TumProjeGor, ProjeKay, TumTopGor, TopKay, TumGorevGor, GorevKay, KullaniciAd, Sifre) VALUES('" + ID + "', '" + sgAd + "','" + sgSoyad + "','" + sPoz + "','" + yKayGor + "', '" + yPrjGor + "', '" + yTopGor + "', '" + yGorevGo + "', '" + yUyeGor + "','" + yUyeKay + "', '" + yGrvGor + "', '" + yGrvKay + "', '" + yRefGor + "', '" + yRefKay + "', '" + tumPrjGor + "', '" + prjKay + "', '" + tumTopGor + "', '" + topKay + "', '" + tumGorevGor + "', '" + gorevKay + "', '" + ygKul + "','" + ygSifre + "')";

            MySqlCommand com = new MySqlCommand(sql, mySqlCon);





            com.ExecuteNonQuery();
            com.Dispose();
            mySqlCon.Close();
        }



        public void grvGuncelle(string ID, string sgAd, string sgSoyad, string sPoz, string yKayGor, string yPrjGor, string yTopGor, string yGorevGo, string yUyeGor, string yUyeKay, string yGrvGor, string yGrvKay, string yRefGor, string yRefKay, string tumPrjGor, string prjKay, string tumTopGor, string topKay, string tumGorevGor, string gorevKay, string maliyeGor, string maliyeKay, string ygKul, string ygSifre)
        {
            mySqlbaglan();
            string sql = "UPDATE gorevliler set ID='" + ID + "', Isim='" + sgAd + "', Soyisim='" + sgSoyad + "', Pozisyon='" + sPoz + "', KayitGo='" + yKayGor + "', ProjeGo='" + yPrjGor + "', TopGo='" + yTopGor + "', GorevGo='" + yGorevGo + "', UyeGo='" + yUyeGor + "', UyeKay='" + yUyeKay + "', GrvGo='"+yGrvGor+"', GrvKay='"+yGrvKay+ "', RefGo='" + yRefGor + "',  RefKay='" + yRefKay + "', TumProjeGor='" + tumPrjGor + "', ProjeKay='" + prjKay + "', TumTopGor='" + tumTopGor + "', TopKay='" + topKay + "', TumGorevGor='" + tumGorevGor + "', GorevKay='" + gorevKay + "',          maliyeGo='" + maliyeGor + "', maliyeKay='" + maliyeKay + "', KullaniciAd='" + ygKul + "', Sifre='" + ygSifre + "' WHERE ID='" + ID + "' ";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);





            com.ExecuteNonQuery();
            com.Dispose();
            mySqlCon.Close();
        }


        public void grvSil(string ID)
        {
            mySqlbaglan();

            string sql = " DELETE FROM gorevliler WHERE ID=@ID";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);
            com.Parameters.AddWithValue("@ID", ID);
            com.ExecuteNonQuery();
            mySqlCon.Close();
        }

        //------------------------------------------------------------------------------------------------------------------
        // REFERANS BOLUMU

        public DataTable rfrListeleme()
        {

            mySqlbaglan();

            string sql = "SELECT * FROM referansList ORDER BY ID ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);
            mySqlCon.Close();
            return dt;

        }

        public DataTable rfrOkumaID()
        {

            mySqlbaglan();

            string sql = " SELECT * FROM referansList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);


            sonIDst = dt.Rows[0]["ID"].ToString();
            mySqlCon.Close();
            return dt;
        }

        public void rfrKayit(string ID, string rfrAd, string rfrSoyad, string rfrKurum, string rfrIs, string rfrTel, string rfrMail, string rfrAcik, string rfrKisi)
        {
            mySqlbaglan();

            string sql = "INSERT INTO referansList (ID, Isim, Soyisim, Kurum, Isi, Telefon, Mail, Aciklama, RfrKisi) VALUES('" + ID + "', '" + rfrAd + "','" + rfrSoyad + "','" + rfrKurum + "','" + rfrIs + "','" + rfrTel + "','" + rfrMail + "','" + rfrAcik + "','" + rfrKisi + "')";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);

            com.ExecuteNonQuery();
            com.Dispose();
            mySqlCon.Close();
        }

        public void rfrSil(string ID)
        {
            mySqlbaglan();

            string sql = " DELETE FROM referansList WHERE ID=@ID";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);
            com.Parameters.AddWithValue("@ID", ID);
            com.ExecuteNonQuery();
            mySqlCon.Close();
        }

        //--------------------------------------------------------------------------------------------------------
        // PROJELER BÖLÜMÜ

        public DataTable prjAdminOkuma(string OgNO)
        {

            mySqlbaglan();

            string sql = " SELECT * FROM uyeList WHERE OgrenciNO = @OgNO";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.SelectCommand.Parameters.AddWithValue("@OgNo", OgNO);
            sda.Fill(dt);
            return dt;


        }

        public DataTable prjUyeOkuma(string ID)
        {

            mySqlbaglan();

            string sql = " SELECT * FROM uyeList WHERE ID = @ID";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            return dt;


        }

        public DataTable projelerimListele(string ID)
        {

            mySqlbaglan();

            string sql = " SELECT * FROM prjUyeList WHERE ID = @ID";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            return dt;


        }

        public DataTable prjListeleme()
        {

            mySqlbaglan();

            string sql = "SELECT * FROM projeList ORDER BY ID ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);
            mySqlCon.Close();
            return dt;

        }


        public DataTable prjUyeListeleme()
        {

            mySqlbaglan();

            string sql = "SELECT * FROM prjUyeList ORDER BY ID ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);
            mySqlCon.Close();
            return dt;

        }

        public void prjKayit(string ID, string prjAd, string prjACiklama, string prjUyeler, string prjAdmin)
        {
            mySqlbaglan();

            string sql = "INSERT INTO projeList (ID, ProjeAd, Aciklama, Uyeler, ProjeAdmin) VALUES('" + ID + "', '" + prjAd + "','" + prjACiklama + "','" + prjUyeler + "','"+prjAdmin+"')";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);

            com.ExecuteNonQuery();
            com.Dispose();
            mySqlCon.Close();
        }

        public void prjSil(string ID)
        {
            mySqlbaglan();

            string sql = " DELETE FROM projeList WHERE ID=@ID";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);
            com.Parameters.AddWithValue("@ID", ID);
            com.ExecuteNonQuery();
            mySqlCon.Close();
        }

        public void prjUyeListesindenSil(string prjID)
        {
            mySqlbaglan();

            string sql = " DELETE FROM prjUyeList WHERE ProjeID=@prjID";
            MySqlCommand com = new MySqlCommand(sql, mySqlCon);
            com.Parameters.AddWithValue("@prjID", prjID);
            com.ExecuteNonQuery();
            mySqlCon.Close();
        }

        public void prjUyelerKayit(string ID, string uAd, string uSoyad, string uOgNo, string uPrjAd, string PrjID, string PrjAdmin, string Aciklama, string Uyeler)
        {
            baglan();

            string sql = "INSERT INTO prjUyeList (ID, Isim, Soyisim, OgrenciNO, ProjeAd, ProjeID, ProjeAdmin, Aciklama, Uyeler) VALUES('" + ID + "', '" + uAd + "','" + uSoyad + "','" + uOgNo + "','" + uPrjAd + "','" + PrjID + "','" + PrjAdmin + "','" + Aciklama + "','" + Uyeler + "')";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public void prjGuncelleUyeler(string ID, string uAd, string uSoyad, string uOgNo, string uPrjAd, string PrjID, string PrjAdmin, string Aciklama, string Uyeler)
        {
            baglan();

            string sql = "UPDATE prjUyeList set ID='" + ID + "', Isim='" + uAd + "', Soyisim='" + uSoyad + "', OgrenciNO='" + uOgNo + "', ProjeAd='" + uPrjAd + "', ProjeID='" + PrjID + "', ProjeAdmin='" + PrjAdmin + "', Aciklama='" + Aciklama + "', Uyeler='" + Uyeler + "' WHERE ID='" + ID + "' ";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public void prjGuncelle(string ID, string prjAd, string prjAciklama, string prjUyeler, string prjAdmin)
        {
            baglan();

            string sql = "UPDATE projeList set ID='" + ID + "', ProjeAd='" + prjAd + "', Aciklama='" + prjAciklama + "', Uyeler='" + prjUyeler + "', ProjeAdmin='" + prjAdmin + "' WHERE ID='" + ID + "' ";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);


            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }


        public DataTable prjOkumaID()
        {

            baglan();

            string sql = " SELECT * FROM projeList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);


            sonIDst = dt.Rows[0]["ID"].ToString();
            sqlcon.Close();
            return dt;
        }

        public DataTable prjDznUyeler(string ID)
        {
            baglan();

            string sql = " SELECT * FROM prjUyeList WHERE ProjeID=@ID";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        public DataTable prjUyeBilgi(int ID)
        {
            baglan();

            string sql = " SELECT * FROM prjUyeList WHERE ID=@ID";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        //---------------------------------------------------------------------------------------------------------------------- TOPLANTILAR BÖLÜMÜ

        public DataTable topListeleme()
        {

            baglan();

            string sql = "SELECT * FROM toplantiList ORDER BY ID ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;

        }

        public DataTable topDavetListeYaz(string ListeAd)
        {

            baglan();

            string sql = " SELECT * FROM topDavetList WHERE ListeAd = @ListeAd";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.SelectCommand.Parameters.AddWithValue("@ListeAd", ListeAd);
            sda.Fill(dt);
            return dt;


        }

        public DataTable topDavetListele()
        {

            baglan();

            string sql = "SELECT * FROM topDavetList ORDER BY ID ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;

        }

        public void topKayit(string ID, string topAd, string topKonu, string topIcerik, string topDavetli, string topOlus, string topTarih, string topSaat)
        {
            baglan();

            string sql = "INSERT INTO toplantiList (ID, Isim, Konu, Icerik, Davetliler, Olusturan, Tarih, Saat) VALUES('" + ID + "', '" + topAd + "','"+topKonu+"','" + topIcerik + "','" + topDavetli + "','"+topOlus+"','"+topTarih+"','"+topSaat+"' )";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public void topDavetListeKayit(string ID, string uyeAd, string uyeID, string listeAd)
        {
           

            baglan();

            string sql = "INSERT INTO topDavetList (ID, UyeAd, UyeID, ListeAd) VALUES('" + ID + "', '" + uyeAd + "','" + uyeID + "','" + listeAd + "' )";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }


        public DataTable topDavetListOkumaID()
        {

            baglan();

            string sql = " SELECT * FROM topDavetList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);


            sonIDstList = dt.Rows[0]["ID"].ToString();
            sqlcon.Close();
            return dt;
        }

       

        public DataTable topOkumaID()
        {

            baglan();

            string sql = " SELECT * FROM toplantiList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);


            sonIDst = dt.Rows[0]["ID"].ToString();
            sqlcon.Close();
            return dt;
        }

        public DataTable topUyeOkuma(string ID)
        {

            baglan();

            string sql = " SELECT * FROM uyeList WHERE ID = @ID";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            return dt;


        }

        public void topUyelerKayit(string uID, string uAd, string uSoyad, string TopID, string TopAd, string TopKonu, string topIcerik, string topOlusturan, string topTarih, string topSaat, int okuDurum)
        {
            baglan();

            string sql = "INSERT INTO  topUyeList (UyeID, UyeIsim, UyeSoyisim, ID, Isim, Konu, Icerik, Olusturan, Tarih, Saat, OkuDurum ) VALUES('" + uID + "', '" + uAd + "','" + uSoyad + "', '" + TopID + "' , '" + TopAd + "','" + TopKonu + "','" + topIcerik + "', '" + topOlusturan + "','" + topTarih + "','" + topSaat + "','" + okuDurum + "')";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public DataTable topDznUyeler(string ID)
        {
            baglan();

            string sql = " SELECT * FROM topUyeList WHERE ID=@ID";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        public DataTable topOkumaDurum(string ID)
        {
            baglan();

            string sql = " SELECT * FROM topUyeList WHERE UyeID=@ID";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        public void topGuncelleUyeler(string ID, string TopID)
        {
            baglan();

            string sql = "UPDATE topUyeList set Katilmama='VAR' WHERE UyeID='" + ID + "' and ID='"+TopID+"' ";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public void topOkuDurumGuncelle(int uID, int TopID)
        {
            baglan();

            string sql = "UPDATE topUyeList set OkuDurum='1' WHERE UyeID='" + uID + "' and ID='" + TopID + "' ";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public void topYoklamaTemizle(string TopID)
        {
            baglan();

            string sql = "UPDATE topUyeList set Katilmama='' WHERE ID='" + TopID + "' ";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public void topGuncelle(string ID, string topAd, string topKonu, string topIcerik, string topKarar, string topTarih, string topSaat)
        {
            baglan();

            string sql = "UPDATE toplantiList set ID='" + ID + "', Isim='" + topAd + "', Konu='" + topKonu + "', Icerik='" + topIcerik + "', Kararlar='" + topKarar + "', Tarih='" + topTarih + "', Saat='" + topSaat + "' WHERE ID='" + ID + "' ";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);


            com.ExecuteNonQuery();
            com.Dispose();

            sqlcon.Close();
        }

        public void topGuncelleUye(string ID, string topAd, string topKonu, string topIcerik, string topKarar, string topTarih, string topSaat)
        {
            baglan();

            string sql = "UPDATE topUyeList set ID='" + ID + "', Isim='" + topAd + "', Konu='" + topKonu + "', Icerik='" + topIcerik + "', Kararlar='" + topKarar + "', Tarih='" + topTarih + "', Saat='" + topSaat + "' WHERE ID='" + ID + "' ";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);


            com.ExecuteNonQuery();
            com.Dispose();

            sqlcon.Close();
        }

        public void topSil(string ID)
        {

            baglan();

            string sql = " DELETE FROM toplantiList WHERE ID=@ID";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);
            com.Parameters.AddWithValue("@ID", ID);
            com.ExecuteNonQuery();
            sqlcon.Close();


        }

        public void topDavetListSil(string ListeAd)
        {

            baglan();

            string sql = " DELETE FROM topDavetList WHERE ListeAd=@ListeAd";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);
            com.Parameters.AddWithValue("@ListeAd", ListeAd);
            com.ExecuteNonQuery();
            sqlcon.Close();


        }

        public void topUyeleriSil(string ID)
        {
            baglan();

            string sql = " DELETE FROM topUyeList WHERE ID=@ID";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);
            com.Parameters.AddWithValue("@ID", ID);
            com.ExecuteNonQuery();
            sqlcon.Close();


        }

        public DataTable topEksikUyeBilgi(int ID)
        {
            baglan();

            string sql = " SELECT * FROM topUyeList WHERE UyeID=@ID";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        public DataTable topUyeKunye(int ID)
        {
            baglan();

            string sql = " SELECT * FROM toplantiList WHERE ID=@ID";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        //---------------------------------------------------------------------------------------------------------------------- GÖREVLER BÖLÜMÜ

        public DataTable yeniGorevListeleme()
        {

            baglan();

            string sql = "SELECT * FROM yeniGorevList ORDER BY ID ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;

        }

        public DataTable gecmisGorevListeleme()
        {

            baglan();

            string sql = "SELECT * FROM gecmisGorevList ORDER BY ID ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;

        }

        public DataTable gorevOkumaID()
        {

            baglan();

            string sql = " SELECT * FROM yeniGorevList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);
            try
            {

                sonIDst = dt.Rows[0]["ID"].ToString();

            }
            catch (Exception hata)
            {
                if (hata.Message== "0 konumunda satır yok.")
                {
                   
                }
                else
                {
                    MessageBox.Show(hata.Message);
                }
            }
         
            sqlcon.Close();
            return dt;
        }

        public DataTable gorevOkumagecmisID()
        {

            baglan();

            string sql = " SELECT * FROM gecmisGorevList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);
            try
            {

                sonIDst = dt.Rows[0]["ID"].ToString();

            }
            catch (Exception hata)
            {
                if (hata.Message == "0 konumunda satır yok.")
                {

                }
                else
                {
                    MessageBox.Show(hata.Message);
                }
            }

            sqlcon.Close();
            return dt;
        }

        //  ANA FORMDA GÖZÜKMESİ İÇİN

        public DataTable gorevleriListeleme(string ID)
        {

            baglan();

            string sql = " SELECT * FROM yeniGorevList WHERE GorevliID = @ID";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            return dt;


        }
        public DataTable eskiGorevleriListeleme(string ID)
        {

            baglan();

            string sql = " SELECT * FROM gecmisGorevList WHERE GorevliID = @ID";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            return dt;


        }

        public DataTable gorevUyeOkuma(string ID)
        {

            baglan();

            string sql = " SELECT * FROM uyeList WHERE ID = @ID";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);
            return dt;


        }

        public void gorevUyelerKayit(string gorevliID, string gorevliAd)
        {
            baglan();

            string sql = "INSERT INTO  yeniGorevList (GorevliAdSoyad, GorevliID) VALUES('" + gorevliID + "', '" + gorevliAd + "')";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public void gorevKayit(string gID, string grvAd, string grvKategori, string grvIcerik, string gorevliAd, string gVeren, string gSonTarih, string gorevliID, string gorevVerTarih)
        {
            baglan();

            string sql = "INSERT INTO yeniGorevList (ID, Isim, Kategori, Icerik,GorevliAdSoyad, Kimden, SonTarih, GorevliID, VerildigiTarih) VALUES('" + gID + "', '" + grvAd + "','" + grvKategori + "', '" + grvIcerik + "','"+gorevliAd+"','" + gVeren + "','" + gSonTarih + "','"+gorevliID+"', '"+gorevVerTarih+"')";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        public void gecmisGorevKayit(string gID, string grvAd, string grvKategori, string grvIcerik, string gorevliAd, string gVeren, string gSonTarih, string gorevliID, string gorevVerTarih, string yapilanTarih ,string gRapor)
        {
            baglan();

            string sql = "INSERT INTO gecmisGorevList (ID, Isim, Kategori, Icerik,GorevliAdSoyad, Kimden, SonTarih, GorevliID, VerildigiTarih, YapildigiTarih, Rapor) VALUES('" + gID + "', '" + grvAd + "','" + grvKategori + "', '" + grvIcerik + "','" + gorevliAd + "','" + gVeren + "','" + gSonTarih + "','" + gorevliID + "', '" + gorevVerTarih + "', '" + yapilanTarih + "',  '" + gRapor + "')";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }


        public void gorevSil(string ID)
        {

            baglan();

            string sql = " DELETE FROM yeniGorevList WHERE ID=@ID";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);
            com.Parameters.AddWithValue("@ID", ID);
            com.ExecuteNonQuery();
            sqlcon.Close();


        }

        //---------------------------------------------------------------------------------------------------------------
        //  LOG BOLUMU

        public DataTable sonLogIDoku()
        {

            baglan();

            string sql = " SELECT * FROM logList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlcon);
            sda.Fill(dt);


            sonLogID = Convert.ToInt32(dt.Rows[0]["ID"]);
            sqlcon.Close();
            return dt;
        }

        public void logKayit(int ID, string gID, string gAd, string gSoyad, string Sehir, string Sirket, string IP, string Mac ,string Enlem, string Boylam, string Islem, string Tarih, string Saat)
        {

            baglan();

            string sql = "INSERT INTO logList (ID, grvID, Isim, Soyisim, Sehir, Sirket, IP, MacAdres ,Enlem, Boylam, Islem, Tarih, Saat) VALUES ('" + ID + "', '" + gID + "','" + gAd + "','" + gSoyad + "','" + Sehir + "','" + Sirket + "','" + IP + "', '"+ Mac +"' ,'" + Enlem + "', '" + Boylam + "', '" + Islem + "', '" + Tarih + "', '" + Saat + "')";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

        //--------------------------------- MALİYE ---------------------------------

        public DataTable maliyeListele()
        {

            baglan();

            string sql = "SELECT * FROM maliyeList order by ID DESC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;


        }

        public DataTable maliyeLogListele()
        {

            baglan();

            string sql = "SELECT * FROM maliyeLogList order by ID DESC";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;


        }

        public DataTable maliyeSonID()
        {

            mySqlbaglan();

            string sql = " SELECT * FROM maliyeList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);


            sonIDst = dt.Rows[0]["ID"].ToString();
            sqlcon.Close();
            return dt;
        }

        public DataTable maliyeLogSonID()
        {

            mySqlbaglan();

            string sql = " SELECT * FROM maliyeLogList ORDER BY ID DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);


            sonIDst = dt.Rows[0]["ID"].ToString();
            sqlcon.Close();
            return dt;
        }

        //----------------------------------- KIRMIZI LİSTE ---------------------------------

        public void kirmiziKayit(int ID, string Ad, string Soyad, string Puan)
        {

            baglan();

            string sql = "INSERT INTO KirmiziList (ID, Isim, Soyisim, Puan) VALUES ('" + ID + "', '" + Ad + "','" + Soyad + "','" + Puan + "')";
            MySqlCommand com = new MySqlCommand(sql, sqlcon);

            com.ExecuteNonQuery();
            com.Dispose();
            sqlcon.Close();
        }

       

        public bool kirmiziKontrol(int ID)
        {

            mySqlbaglan();

            string sql = " SELECT * FROM KirmiziList WHERE ID = @ID";
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                mySqlCon.Close();
                return true;
            }
            else
            {
                mySqlCon.Close();
                return false;
            }


        }

        public DataTable kirmiziListele()
        {

            mySqlbaglan();

            string sql = "SELECT * FROM KirmiziList ";

            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, mySqlCon);
            sda.Fill(dt);
            sqlcon.Close();
            return dt;


        }

    }
}
