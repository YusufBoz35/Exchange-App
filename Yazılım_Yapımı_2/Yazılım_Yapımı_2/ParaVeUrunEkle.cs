using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Yazılım_Yapımı_2
{
    public class ParaVeUrunEkle
    {

        public void bakiye_ekle(string user_para, int miktar ,string birim)                      //Bakiye Ekleme Talebi Gönderir
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into para_istek (para_istek_user , para_istek_miktar ,para_istek_birim) values (@p1 ,@p2 ,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", user_para);
            komut.Parameters.AddWithValue("@p2", miktar);
            komut.Parameters.AddWithValue("@p3", birim);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public void urun_ekle(string kullanici, string urun, string miktar)         //Urun Ekleme Talebi Gönderir
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into urun_istek (urun_istek_user , urun_istek_tip ,urun_istek_miktar ,urun_istek_birim) values (@p1 ,@p2 ,@p3 ,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", kullanici);
            komut.Parameters.AddWithValue("@p2", urun);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(miktar));
            komut.Parameters.AddWithValue("@p4", "Kg");
            komut.ExecuteNonQuery();

            baglanti.Close();

        }

        public int bakiye_getir(string secilen_kul_nick)                       // guncelleme işlemi için önceki bakiyeyi veri tabanından çeker
        {
            int eski_bakiye;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");


            SqlCommand komut = new SqlCommand("SELECT kul_bakiye FROM kullanici WHERE kul_nick = @kn", baglanti);
            komut.Parameters.AddWithValue("@kn", secilen_kul_nick);

            baglanti.Open();
            var bakiye = komut.ExecuteScalar();
            eski_bakiye = Convert.ToInt32(bakiye);
            baglanti.Close();

            return eski_bakiye;
        }


    }
}
