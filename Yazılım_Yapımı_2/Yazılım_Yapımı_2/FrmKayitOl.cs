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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }
        GirisKayitDB VTM = new GirisKayitDB();
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaEkran fr = new FrmAnaEkran();
            fr.Show();
            this.Hide();
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            VTM.kullanici_kayit(TxtAd.Text, TxtSoyad.Text, TxtNick.Text, TxtParola.Text, MskTc.Text, TxtMail.Text, RtxtAdres.Text, MskTel.Text); //kayıt alma fonksiyonu
            MessageBox.Show("Kaydınız başarıyla tamamlanmıştır" ,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FrmGirisYap fr = new FrmGirisYap();
            fr.Show();
            this.Hide();
        }
    }
}
