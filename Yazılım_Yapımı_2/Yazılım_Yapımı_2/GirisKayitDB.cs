using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Yazılım_Yapımı_2
{
    public class GirisKayitDB
    {
        //giriş fonksiyonu

        public int giris_kontrol(string username, string parola)  //giris_kontrol fonksiyonu girilen kullanıcı adı ile parolanın eşleşmesi durumunda
        {                                                         // 1 eşleşmemesi durumunda 0 değerini döndürür                    
            int a;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanici WHERE kul_username = @k1 AND kul_parola = @k2", baglanti);
            komut.Parameters.AddWithValue("@k1", username);
            komut.Parameters.AddWithValue("@k2", parola);
            SqlDataReader dr = komut.ExecuteReader();
            a = Convert.ToInt32(dr.Read());
            baglanti.Close();
            return a;

        }



        //kayıt fonksiyonu

        public void kullanici_kayit(string ad, string soyad, string nick, string parola, string tc, string mail, string adres, string tel)
        {

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into kullanici (kul_ad ,kul_soyad,kul_username,kul_parola,kul_TC,kul_mail,kul_adres,kul_tel,kul_bakiye,bugday,arpa,yulaf,petrol,pamuk) values (@k1 , @k2 , @k3 ,@k4 ,@k5 ,@k6 , @k7 ,@k8 ,@k9,@k10,@k11,@k12,@k13,@k14)", baglanti);
            komut.Parameters.AddWithValue("@k1", ad);
            komut.Parameters.AddWithValue("@k2", soyad);
            komut.Parameters.AddWithValue("@k3", nick);
            komut.Parameters.AddWithValue("@k4", parola);
            komut.Parameters.AddWithValue("@k5", tc);
            komut.Parameters.AddWithValue("@k6", mail);
            komut.Parameters.AddWithValue("@k7", adres);
            komut.Parameters.AddWithValue("@k8", tel);
            komut.Parameters.AddWithValue("@k9", 0);
            komut.Parameters.AddWithValue("@k10", 0);
            komut.Parameters.AddWithValue("@k11", 0);
            komut.Parameters.AddWithValue("@k12", 0);
            komut.Parameters.AddWithValue("@k13", 0);
            komut.Parameters.AddWithValue("@k14", 0);
            komut.ExecuteNonQuery();

            baglanti.Close();

        }

    }
}
