using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yazılım_Yapımı_2
{
    public partial class FrmIslemEkrani : Form
    {
        public FrmIslemEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");
        IslemlerDB VTM = new IslemlerDB();

        public string user_islem;
        

        void islem_sec()
        {
            if (CmbIslem.Text == "Piyasa Emri" && radioButton1.Checked)
            {
                BtnIslem.Text = "AL";
            }
            else if (CmbIslem.Text == "Teklif Oluştur" && radioButton1.Checked)
            {
                BtnIslem.Text = "Alım Emri Oluştur";
            }
            else if (CmbIslem.Text == "Piyasa Emri" && (radioButton1.Checked == false))
            {
                BtnIslem.Text = "SAT";
            }
            else
            {
                BtnIslem.Text = "Satış Emri Oluştur";
            }

        }


        void toplam_tutar_hesapla()
        {
            if (TxtAlimMiktari.Text != "" && TxtBirimFiyat.Text != "")
            { 
                TxtTutar.Text = (Convert.ToInt32(TxtAlimMiktari.Text) * Convert.ToInt32(TxtBirimFiyat.Text)).ToString();
            }
            else
                TxtTutar.Text = "0";
        }

        void temizle()
        {
            TxtAlimMiktari.Text = "";
            TxtBirimFiyat.Text = "";
            TxtTutar.Text = "";
        }

        
        void listele(DataGridView tablo, SqlCommand komut ,string urun_birim)
        {
             baglanti.Open();
            komut.Parameters.AddWithValue("@p1",urun_birim);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tablo.DataSource = dt;

            baglanti.Close();
        }
        bool islem_durum;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            islem_sec();
            islem_durum = true;
        }

        private void CmbBugday_TextChanged(object sender, EventArgs e)
        {
            islem_sec();
            
        }

        private void CmbUrun_TextChanged(object sender, EventArgs e)
        {
            GrpBoxIslem.Text = CmbUrun.Text;
            SqlCommand satis_teklif_getir = new SqlCommand("SELECT * FROM teklifler WHERE teklif_urun = @p1  ORDER BY teklif_birim_fiyat asc", baglanti);
            SqlCommand alim_teklif_getir = new SqlCommand("SELECT * FROM alim_teklifleri WHERE teklif_urun = @p1 ORDER BY teklif_birim_fiyat desc", baglanti);
            listele(dataGridView1, satis_teklif_getir, CmbUrun.Text);
            listele(TabloAlimEmirlerim, alim_teklif_getir, CmbUrun.Text);

        }

        private void FrmIslemEkrani_Load(object sender, EventArgs e)
        {
            SqlCommand satis_teklif_getir = new SqlCommand("SELECT * FROM teklifler WHERE teklif_urun = @p1  ORDER BY teklif_birim_fiyat asc", baglanti);
            SqlCommand alim_teklif_getir = new SqlCommand("SELECT * FROM alim_teklifleri WHERE teklif_urun = @p1  ORDER BY teklif_birim_fiyat desc", baglanti);
            listele(dataGridView1, satis_teklif_getir, "bugday");
            listele(TabloAlimEmirlerim, alim_teklif_getir, CmbUrun.Text);

        }
      
        private void BtnIslem_Click(object sender, EventArgs e)
        {


            switch(BtnIslem.Text)
            {
                case "Satış Emri Oluştur" : VTM.satis_teklifi_olustur(CmbUrun.Text, Convert.ToInt32(TxtAlimMiktari.Text), Convert.ToInt32(TxtBirimFiyat.Text), Convert.ToInt32(TxtTutar.Text), user_islem ); break;

                case "Alım Emri Oluştur":   VTM.alim_teklifi_olustur(CmbUrun.Text, Convert.ToInt32(TxtAlimMiktari.Text), Convert.ToInt32(TxtBirimFiyat.Text), Convert.ToInt32(TxtTutar.Text), user_islem); break;

                case "AL": VTM.al(Convert.ToInt32(TxtAlimMiktari.Text), user_islem, CmbUrun.Text);  break;

                case "SAT" :  ; break;  

                default : MessageBox.Show("deneme"); break;
            }



            

            SqlCommand satis_teklif_getir = new SqlCommand("SELECT * FROM teklifler WHERE teklif_urun = @p1  ORDER BY teklif_birim_fiyat asc", baglanti);
            SqlCommand alim_teklif_getir = new SqlCommand("SELECT * FROM alim_teklifleri WHERE teklif_urun = @p1  ORDER BY teklif_birim_fiyat desc", baglanti);
            listele(dataGridView1, satis_teklif_getir, CmbUrun.Text);
            listele(TabloAlimEmirlerim, alim_teklif_getir, CmbUrun.Text);
            temizle();

        }

        private void TxtAlimMiktari_TextChanged(object sender, EventArgs e)
        {
            toplam_tutar_hesapla();
        }

        private void TxtBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            toplam_tutar_hesapla();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //VTM.Sat("arpa" , "abk_35" , 200);
            VTM.rapor_olustur("al", "arpa", 500,  2525, "boz_35"); 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            islem_durum = false;
        }

        private void GrpBoxIslem_Enter(object sender, EventArgs e)
        {

        }
    }
}
