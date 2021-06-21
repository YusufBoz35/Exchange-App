using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Yazılım_Yapımı_2
{
    public class IslemlerDB
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");

        void muhasebe_islem(int tutar)
        {
            urun_arttir("admin", "kul_bakiye", (tutar / 100));
        }


        public void rapor_olustur(string islem_ad ,string islem_urun, int islem_urun_miktar,int islem_tutar,string islem_user )
        {

            

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into raporlar (islem_ad ,islem_urun ,islem_urun_miktar,islem_tutar,islem_user) values (@k1 , @k2 , @k3 ,@k4 ,@k5 )", baglanti);
            komut.Parameters.AddWithValue("@k1", islem_ad);
            komut.Parameters.AddWithValue("@k2", islem_urun);
            komut.Parameters.AddWithValue("@k3", islem_urun_miktar);
            komut.Parameters.AddWithValue("@k4", islem_tutar);
            komut.Parameters.AddWithValue("@k5", islem_user);
            komut.ExecuteNonQuery();

            baglanti.Close();



        }





        //ÜRÜN SATIM


        //Kullanıcının belirlediği fiyat ve miktardan satış teklifi oluşturur
        public void satis_teklifi_olustur(string urun , int miktar ,int birim_fiyat , int toplam_fiyat ,string teklif_user)    
        {

            if (miktar <= Convert.ToInt32(urun_kontrol(urun, teklif_user)))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO teklifler (teklif_urun,teklif_miktar,teklif_birim_fiyat,teklif_toplam_fiyat,teklif_username) VALUES (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", urun);
                komut.Parameters.AddWithValue("@p2", miktar);
                komut.Parameters.AddWithValue("@p3", birim_fiyat);
                komut.Parameters.AddWithValue("@p4", toplam_fiyat);
                komut.Parameters.AddWithValue("@p5", teklif_user);
               


                komut.ExecuteNonQuery();
                baglanti.Close();

                urun_azalt(teklif_user, urun, miktar);
            }
            else
            {
                MessageBox.Show(urun + " miktarınız yetersizdir", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //username'i girilen kullanıcının istenilen üründen ya da parasının ne kadar olduğunu getirir
        private string urun_kontrol(string urun , string teklif_user)
        {

            string deger = "";
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanici WHERE kul_username = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", teklif_user);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            

            foreach (DataRow o in dt.Select())
            {
                deger = o[urun].ToString();
            }

            return deger;                                   

        }


        //girilen kullanıcının istenildiği üründen girilen miktar düşer
        private void urun_azalt(string teklif_user ,string urun , int miktar)
        {
            
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanici WHERE kul_username = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", teklif_user);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            
            int yeni_Deger = Convert.ToInt32(urun_kontrol(urun, teklif_user)) - miktar;        //urun_kontrol metodu ile eski miktarı getirir
            
            foreach (DataRow o in dt.Select())
            {
                o[urun] = yeni_Deger;
            }
            
            baglanti.Open();
            SqlCommand komut_g = new SqlCommand("UPDATE kullanici SET kul_bakiye = @p1 , bugday = @p2 , arpa = @p3 ,yulaf = @p4 ,petrol = @p5 , pamuk = @p6 WHERE kul_username = @p7 ", baglanti);
            komut_g.Parameters.AddWithValue("@p1", yeni_Deger);  
            komut_g.Parameters.AddWithValue("@p2", dt.Rows[0][10]);
            komut_g.Parameters.AddWithValue("@p3", dt.Rows[0][11]);
            komut_g.Parameters.AddWithValue("@p4", dt.Rows[0][12]);
            komut_g.Parameters.AddWithValue("@p5", dt.Rows[0][13]);
            komut_g.Parameters.AddWithValue("@p6", dt.Rows[0][14]);
            komut_g.Parameters.AddWithValue("@p7", (dt.Rows[0][3]).ToString());
            komut_g.ExecuteNonQuery();
            baglanti.Close();
        }

        //

        public void Sat(string urun, string user, int talep,bool teklif_durum)
        {
            

            

            if (Convert.ToInt32(urun_kontrol(urun, user)) >= talep)         //Kullanıcının satmak istediği ürünün miktarına sahip olup olmadığını kontrol eder
            {
                urun_azalt(user, urun, talep);                              //Satıcının hesabından ürün düşer
                urun_arttir(user, "kul_bakiye", tutar_hesapla(urun, talep));//satıcının hesabına sattığı ürünün ücretini ekler
                teklif_guncelle(talep, urun);                               //var olan teklifleri günceller


                MessageBox.Show("Satış İşleminiz Başarılı");
            }
            else
            {
                MessageBox.Show("Ürün Miktarınız Yetersiz");
            }


        }






        //girilen kullanıcının istenildiği üründen girilen miktar kadar arttırır
        private void urun_arttir(string teklif_user, string urun, int miktar)
        {

            SqlCommand komut = new SqlCommand("SELECT * FROM kullanici WHERE kul_username = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", teklif_user);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int yeni_Deger = Convert.ToInt32(urun_kontrol(urun, teklif_user)) + miktar;

            foreach (DataRow o in dt.Select())
            {
                o[urun] = yeni_Deger;
            }

            baglanti.Open();
            SqlCommand komut_g = new SqlCommand("UPDATE kullanici SET kul_bakiye = @p1 , bugday = @p2 , arpa = @p3 ,yulaf = @p4 ,petrol = @p5 , pamuk = @p6 WHERE kul_username = @p7 ", baglanti);
            komut_g.Parameters.AddWithValue("@p1", dt.Rows[0][9]);
            komut_g.Parameters.AddWithValue("@p2", dt.Rows[0][10]);
            komut_g.Parameters.AddWithValue("@p3", dt.Rows[0][11]);
            komut_g.Parameters.AddWithValue("@p4", dt.Rows[0][12]);
            komut_g.Parameters.AddWithValue("@p5", dt.Rows[0][13]);
            komut_g.Parameters.AddWithValue("@p6", dt.Rows[0][14]);
            komut_g.Parameters.AddWithValue("@p7", (dt.Rows[0][3]).ToString());
            komut_g.ExecuteNonQuery();
            baglanti.Close();
        }

        //Kullanıcının belirlediği fiyat ve miktardan alım teklifi oluşturur
        public void alim_teklifi_olustur(string urun, int miktar, int birim_fiyat, int toplam_fiyat, string teklif_user)
        {
            if (toplam_fiyat <= Convert.ToInt32(urun_kontrol("kul_bakiye", teklif_user)))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO alim_teklifleri (teklif_urun,teklif_miktar,teklif_birim_fiyat,teklif_toplam_fiyat,teklif_username) VALUES (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", urun);
                komut.Parameters.AddWithValue("@p2", miktar);
                komut.Parameters.AddWithValue("@p3", birim_fiyat);
                komut.Parameters.AddWithValue("@p4", toplam_fiyat);
                komut.Parameters.AddWithValue("@p5", teklif_user);
                komut.ExecuteNonQuery();
                baglanti.Close();

                urun_azalt(teklif_user, "kul_bakiye", (miktar*birim_fiyat*101/100));
                muhasebe_islem(miktar * birim_fiyat / 100);

            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersizdir" ,"İşlem Başarısız" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }

        

        public void al(int talep,string user,string istek_urun )
        {
            if(Convert.ToInt32(urun_kontrol("kul_bakiye", user)) >= (tutar_hesapla(istek_urun, talep)/100*101))//kullanıcının satın almak istediği ürün miktarının maliyeti ile bakiyesini karşılaştırır
            {
                
                MessageBox.Show("Alım İşleminiz Gerçekleşti");
                                                                                       //kullanıcı bakiyesinden aldığı ürün maliyeti + %1 muhasebe kesintisini düşer   / 100 * 101)
                urun_arttir(user, istek_urun, talep);                       //kullanıcının aldığı ürünü ekler
                muhasebe_islem((tutar_hesapla(istek_urun, talep)));         //muhasebe ye yapılan işlemin %1 kadarını ekler
                teklif_guncelle(talep,istek_urun);                          //alım sonrası teklifleri siler ya da günceller
                urun_azalt(user, "kul_bakiye", (tutar_hesapla(istek_urun, talep) / 100 * 101));
                rapor_olustur("Alım", istek_urun, Convert.ToInt32(talep) , (tutar_hesapla(istek_urun, talep) / 100 * 101), user);
                
            }
            else
            {
                MessageBox.Show("Bakiyeniz Yetersiz");
            }
        }


        //secilen üründen istenilen miktarının fiyatını geri döner
        private int tutar_hesapla(string urun ,int teklif)
        {
            int tutar = 0;
            int toplam = 0;
            int son_urun_yeni_deger ;



            SqlCommand komut = new SqlCommand("SELECT * FROM teklifler WHERE teklif_urun = @p1 ORDER BY teklif_birim_fiyat asc", baglanti);
           


            komut.Parameters.AddWithValue("@p1", urun);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int i;
            for (i = 0; toplam < teklif; i++)
            {
                toplam += Convert.ToInt32(dt.Rows[i][2]);
                if (teklif < toplam)
                {
                    son_urun_yeni_deger = toplam - teklif;
                    tutar += (Convert.ToInt32(dt.Rows[i][2]) - son_urun_yeni_deger) * Convert.ToInt32(dt.Rows[i][3]);
                }
                else
                {
                    tutar += Convert.ToInt32(dt.Rows[i][4]);
                }

            }
            return tutar;
        }


        //alım ve satım işlemleri sonucunda değişen teklifleri oluşturur
        void teklif_guncelle(int teklif , string urun)
        {

            SqlCommand komut = new SqlCommand("SELECT * FROM teklifler WHERE teklif_urun = @p1 ORDER BY teklif_birim_fiyat asc", baglanti);

         
           

            komut.Parameters.AddWithValue("@p1", urun);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);


            int toplam = 0;
            int tutar = 0;
            int son_urun_yeni_deger = 0;
            int i;
            for (i = 0; toplam < teklif; i++)
            {

                toplam += Convert.ToInt32(dt.Rows[i][2]);


                if (teklif < toplam)
                {
                    int yedek = Convert.ToInt32(dt.Rows[i][2]);
                    son_urun_yeni_deger = toplam - teklif;
                    int eski_bakiye = Convert.ToInt32(urun_kontrol("kul_bakiye", (dt.Rows[i][5]).ToString()));
                    tutar += (Convert.ToInt32(dt.Rows[i][2]) - son_urun_yeni_deger) * Convert.ToInt32(dt.Rows[i][3]);
                    dt.Rows[i].SetField("teklif_miktar", son_urun_yeni_deger);
                    dt.Rows[i].SetField("teklif_toplam_fiyat", son_urun_yeni_deger * Convert.ToInt32(dt.Rows[i][3]));
                    int deger = Convert.ToInt32(dt.Rows[i][0]);

                    baglanti.Open();
                    SqlCommand komut_guncelle = new SqlCommand("UPDATE teklifler SET teklif_miktar  = @p1 , teklif_toplam_fiyat = @p2 WHERE teklif_id = @p3", baglanti);
                    komut_guncelle.Parameters.AddWithValue("@p1", son_urun_yeni_deger);
                    komut_guncelle.Parameters.AddWithValue("@p2", son_urun_yeni_deger * Convert.ToInt32(dt.Rows[i][3]));
                    komut_guncelle.Parameters.AddWithValue("@p3", deger);
                    
                    komut_guncelle.ExecuteNonQuery();
                    baglanti.Close();

                    
                    int yeni_bakiye = ((yedek - son_urun_yeni_deger) * Convert.ToInt32(dt.Rows[i][3])) + eski_bakiye;
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("UPDATE kullanici SET kul_bakiye = @p1 WHERE kul_username = @p2 ", baglanti);
                    komut1.Parameters.AddWithValue("@p1", yeni_bakiye);
                    komut1.Parameters.AddWithValue("@p2", dt.Rows[i][5]);
                    
                    komut1.ExecuteNonQuery();

                    baglanti.Close();


                }
                else
                {

                    tutar += Convert.ToInt32(dt.Rows[i][4]);
                    int deger = Convert.ToInt32(dt.Rows[i][0]);
                    int eski_bakiye = Convert.ToInt32(urun_kontrol("kul_bakiye", (dt.Rows[i][5]).ToString()));
                    baglanti.Open();
                    SqlCommand komut_sil = new SqlCommand("DELETE FROM teklifler WHERE teklif_id = @k1", baglanti);
                    komut_sil.Parameters.AddWithValue("@k1", deger);    
                    komut_sil.ExecuteNonQuery();
                    baglanti.Close();

                    
                    int yeni_bakiye = Convert.ToInt32(dt.Rows[i][4]) + eski_bakiye;
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("UPDATE kullanici SET kul_bakiye = @p1 WHERE kul_username = @p2 ", baglanti);
                    komut1.Parameters.AddWithValue("@p1", yeni_bakiye);
                    komut1.Parameters.AddWithValue("@p2", dt.Rows[i][5]);
                    
                    komut1.ExecuteNonQuery();

                    baglanti.Close();
                    dt.Rows[i].Delete();

                }

            }


        }





    }
}
