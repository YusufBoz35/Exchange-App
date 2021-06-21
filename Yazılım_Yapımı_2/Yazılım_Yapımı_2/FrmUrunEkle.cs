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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }

        public string user_urun;
        ParaVeUrunEkle VTM = new ParaVeUrunEkle();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            VTM.urun_ekle(user_urun, CmbUrun.Text, TxtMiktar.Text);
            CmbUrun.Text = "";
            TxtMiktar.Text = "";
            MessageBox.Show("Ürün ekleme talabiniz iletilmiştir");
        }
    }
}
