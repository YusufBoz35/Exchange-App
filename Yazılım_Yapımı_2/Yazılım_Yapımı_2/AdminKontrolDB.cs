using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Yazılım_Yapımı_2
{
    public class AdminKontrolDB
    {
        public void para_istek_sil(int istek_id)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete FROM para_istek WHERE para_istek_id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", istek_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            

        }

        public void urun_istek_sil(int istek_id)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete FROM urun_istek WHERE urun_istek_id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", istek_id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public int bakiye_getir(string secilen_kul_nick)                       // guncelleme işlemi için önceki bakiyeyi veri tabanından çeker
        {
            int eski_bakiye;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");


            SqlCommand komut = new SqlCommand("SELECT kul_bakiye FROM kullanici WHERE kul_username = @kn", baglanti);
            komut.Parameters.AddWithValue("@kn", secilen_kul_nick);

            baglanti.Open();
            var bakiye = komut.ExecuteScalar();
            eski_bakiye = Convert.ToInt32(bakiye);
            baglanti.Close();

            return eski_bakiye;
        }

        public void para_guncelle(float yeni_bakiye, string kullanici)    // güncellenmiş bakiyey veri tabanına kaydeder
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");

            SqlCommand komut = new SqlCommand("update kullanici Set kul_bakiye = @k1 WHERE kul_username = @k2 ", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@k1", yeni_bakiye);
            komut.Parameters.AddWithValue("@k2", kullanici);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }


       public int yeni_miktar_hesapla(string urun_tip , int urun_istek_miktar , string secilen_kullanici_nick)
        {
            int eski_miktar;
            int yeni_miktar ;

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            SqlCommand komut2 = new SqlCommand();

            switch (urun_tip)
            {
                case "Bugday":
                    komut = new SqlCommand("select bugday from kullanici WHERE kul_username = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set bugday = @k1 WHERE kul_username = @k2 ", baglanti);
                    break;
                case "Arpa":
                    komut = new SqlCommand("select arpa from kullanici WHERE kul_username = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set arpa = @k1 WHERE kul_username = @k2 ", baglanti);
                    break;
                case "Yulaf":
                    komut = new SqlCommand("select yulaf from kullanici WHERE kul_username = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set yulaf = @k1 WHERE kul_username = @k2 ", baglanti);
                    break;
                case "Petrol":
                    komut = new SqlCommand("select petrol from kullanici WHERE kul_username = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set petrol = @k1 WHERE kul_username = @k2 ", baglanti);
                    break;
                case "Pamuk":
                    komut = new SqlCommand("select pamuk from kullanici WHERE kul_username = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set pamuk = @k1 WHERE kul_username = @k2 ", baglanti);
                    break;
                default: break;
            }
            baglanti.Open();
            komut.Parameters.AddWithValue("@kn",secilen_kullanici_nick);
            var miktar = komut.ExecuteScalar();
            eski_miktar = Convert.ToInt32(miktar);

            yeni_miktar = eski_miktar + urun_istek_miktar;
            komut2.Parameters.AddWithValue("@k2", secilen_kullanici_nick);
            komut2.Parameters.AddWithValue("@k1", yeni_miktar);
            komut2.ExecuteNonQuery();

            baglanti.Close();

            return yeni_miktar;
        }





    }
}
