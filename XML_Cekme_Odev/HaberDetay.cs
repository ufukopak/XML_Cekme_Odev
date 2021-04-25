using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_Cekme_Odev
{
    public partial class HaberDetay : Form
    {
        public HaberDetay()
        {
            InitializeComponent();
        }
        public string baslik;

        private void HaberDetay_Load(object sender, EventArgs e)
        {
            lblBaslik.Text = baslik;
        }
    }
}
