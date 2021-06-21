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
    public partial class FrmGirisYap : Form
    {
        public FrmGirisYap()
        {
            InitializeComponent();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaEkran fr = new FrmAnaEkran();
            fr.Show();
            this.Hide();
        }

        

        GirisKayitDB VTM = new GirisKayitDB();                 // Kullanici giriş ve kayıt işlemleri için yazılan fonksiyonları kullanmak için VTM isimli bir nesne oluşturduk

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            int parola_onay = VTM.giris_kontrol(TxtKullaniciAdi.Text, TxtParola.Text);


            if (parola_onay == 1)                           // veri tabanı üzerinde kullanıcı adı ve parola eşleşmesi sağlanırsa kod buradaki karar yapısına girer
            {
                if (TxtKullaniciAdi.Text == "admin")                //kullanici adi eger admin kullanıcı adiyla sisteme giriş yapabildiyse admin sayfasına yönlendirilir
                {
                    FrmAdminPanel fr8 = new FrmAdminPanel();
                    fr8.Show();
                    this.Hide();
                }
                else
                {
                    FrmAraMenu fr4 = new FrmAraMenu();
                    fr4.UserNick = TxtKullaniciAdi.Text;
                    fr4.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanci adiniz veya parolanız hatalı");
            }

        }
    
    }
}
