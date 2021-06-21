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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;


namespace Yazılım_Yapımı_2
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=yazilim_yapimi;Integrated Security=True");
        public string user;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM raporlar WHERE islem_user = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", user);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string rapor = "id  islem  miktar  tutar\n";
            MessageBox.Show(user);
            foreach (DataRow o in dt.Select())
            {

                rapor += ("\t" + o["islem_id"] + "\t" + o["islem_ad"] + "\t" + o["islem_urun"] + "\t" + o["islem_urun_miktar"] + "\t" + o["islem_tutar"] + "\n").ToString();
            }
            richTextBox1.Text = rapor;
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "PDF DOSYALARI(*.pdf)|*.pdf";
            file.Title = "PDF DOSYASI OLUSTURMA";
            if (file.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(file.FileName, FileMode.Create);
                Document pdf = new Document();
                PdfWriter.GetInstance(pdf, dosya);
                pdf.Open();
                pdf.AddAuthor("sistem");
                pdf.AddCreator("Yusuf Boz");
                pdf.AddTitle("PDF DOSYASI İSLEMLERİ");
                pdf.AddSubject("konu");
                Paragraph paragraf = new Paragraph(richTextBox1.Text);
                pdf.Add(paragraf);
                pdf.Close();
                MessageBox.Show("İşlem Geçmişiniz İndirildi");

            }
        }
    }
}
