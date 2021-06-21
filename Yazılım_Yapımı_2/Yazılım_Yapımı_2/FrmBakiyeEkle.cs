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
    public partial class FrmBakiyeEkle : Form
    {
        public FrmBakiyeEkle()
        {
            InitializeComponent();
        }
        public string user_para;
        ParaVeUrunEkle VTM = new ParaVeUrunEkle();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            VTM.bakiye_ekle(user_para, Convert.ToInt32(TxtMiktar.Text),CmbBirim.Text);  //kullanıcının sisteme para ekleme isteği göndermesini sağlar
            TxtMiktar.Text = "";
            CmbBirim.Text = "";
            MessageBox.Show("para ekleme talebiniz iletilmiştir");
        }
    }
}
