using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
            bool veriDeMiyim = false;
            txtBaslik.Text = baslik;
            XmlTextReader xmlOku = new XmlTextReader("http://www.star.com.tr/rss/sondakika.xml");
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title" && xmlOku.ReadString() == baslik)
                {
                    veriDeMiyim = true;
                }
                else if(xmlOku.Name == "title")
                {
                    veriDeMiyim = false;
                }
                if (veriDeMiyim && xmlOku.Name.ToLower() == "description")
                {
                    txtDetay.Text = xmlOku.ReadString();
                }
                if (veriDeMiyim && xmlOku.Name.ToLower() == "image")
                {
                    pictureBox1.Load(xmlOku.ReadString());
                }
            }
        }
    }
}
