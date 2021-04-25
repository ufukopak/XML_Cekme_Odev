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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlOku = new XmlTextReader("https://www.haberturk.com/rss/manset.xml");
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    lbBasliklar.Items.Add(xmlOku.ReadString());
                }
            }
        }

        private void lbBasliklar_DoubleClick(object sender, EventArgs e)
        {
            tbBaslik.Text = lbBasliklar.Items[lbBasliklar.SelectedIndex].ToString();
        }
    }
}
