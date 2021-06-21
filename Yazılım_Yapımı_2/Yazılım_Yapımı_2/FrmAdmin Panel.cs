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
using System.Xml;
using System.Globalization;

namespace Yazılım_Yapımı_2
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");

        AdminKontrolDB VTM = new AdminKontrolDB();

        float eski_bakiye, yeni_bakiye;
        int eski_miktar, yeni_miktar;
        int para_istek_id , urun_istek_id;
        string para_istek_nick, urun_istek_nick;
        int para_istek_miktar, urun_istek_miktar;
        string para_istek_birim, urun_istek_birim;

        string USD, GBP, EURO;



        void para_istek_listele()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT para_istek_id,para_istek_user,para_istek_miktar,para_istek_birim FROM para_istek", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        void urun_istek_listele()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM urun_istek", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            baglanti.Close();
        }

        private void BtnUrunG_Click(object sender, EventArgs e)
        {
            VTM.yeni_miktar_hesapla(urun_istek_birim, urun_istek_miktar, urun_istek_nick);
            
            MessageBox.Show("guncelleme islemi tamamlandı");
            VTM.urun_istek_sil(urun_istek_id);
            urun_istek_listele();
        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            para_istek_listele();
            urun_istek_listele();

            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            baglanti.Open();
            int a;
            SqlCommand komut = new SqlCommand("SELECT kul_bakiye FROM kullanici WHERE kul_username = @p1 ",baglanti);
            komut.Parameters.AddWithValue("@p1","admin");
            var bakiye = komut.ExecuteScalar();
            a = Convert.ToInt32(bakiye);
            TxtMuhasebe.Text = a.ToString();
            baglanti.Close();



            SqlDataAdapter da = new SqlDataAdapter();








        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            para_istek_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            para_istek_nick = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            para_istek_miktar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            para_istek_birim = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urun_istek_id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            urun_istek_nick = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            urun_istek_birim = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            urun_istek_miktar = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
        }

        private void BtnParaS_Click(object sender, EventArgs e)
        {
            VTM.para_istek_sil(para_istek_id);
            para_istek_listele();
            MessageBox.Show("İstek listeden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUrunS_Click(object sender, EventArgs e)
        {
            VTM.urun_istek_sil(urun_istek_id);
            urun_istek_listele();
            MessageBox.Show("İstek listeden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnParaG_Click(object sender, EventArgs e)
        {
           eski_bakiye = VTM.bakiye_getir(para_istek_nick);
            yeni_bakiye = eski_bakiye + kur_hesapla(para_istek_birim, para_istek_miktar);
            VTM.para_guncelle(yeni_bakiye, para_istek_nick);
            VTM.para_istek_sil(para_istek_id);
            para_istek_listele();
            MessageBox.Show("Para Ekleme İsteği Gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        float kur_hesapla(string kur_tipi , float para_ekleme_istek)
        {
            float sonuc = 0;
            switch(kur_tipi)
            {
                case "USD": sonuc = float.Parse(USD, CultureInfo.InvariantCulture.NumberFormat) * para_ekleme_istek ; break;

                case "EURO": sonuc = float.Parse(EURO, CultureInfo.InvariantCulture.NumberFormat) * para_ekleme_istek; break;

                case "GBP": sonuc = float.Parse(GBP, CultureInfo.InvariantCulture.NumberFormat) * para_ekleme_istek; break;

                default: sonuc = para_ekleme_istek; break;
            }

            return sonuc;
        }



    }
}
