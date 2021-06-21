using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapımı_2
{
    public partial class FrmAraMenu : Form
    {
        public FrmAraMenu()
        {
            InitializeComponent();
        }

        public string UserNick;
        private void FrmAraMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnParaEkle_Click(object sender, EventArgs e)
        {
            FrmBakiyeEkle fr = new FrmBakiyeEkle();
            fr.user_para = UserNick;
            fr.Show();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunEkle fr = new FrmUrunEkle();
            fr.user_urun = UserNick;
            fr.Show();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAlim_Click(object sender, EventArgs e)
        {
            FrmIslemEkrani fr = new FrmIslemEkrani();
            fr.user_islem = UserNick;
            fr.Show();
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            FrmRapor fr = new FrmRapor();
            fr.user = UserNick;
            fr.Show();
        }
    }
}
