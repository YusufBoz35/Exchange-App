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
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmGirisYap fr = new FrmGirisYap();
            fr.Show();
            this.Hide();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            FrmKayitOl fr = new FrmKayitOl();
            fr.Show();
            this.Hide();
        }
    }
}
