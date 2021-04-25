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
using System.IO;

namespace XML_Cekme_Odev
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string eskiVeri;

        private void lbBasliklar_DoubleClick(object sender, EventArgs e)
        {
            tbBaslik.Text = lbBasliklar.Items[lbBasliklar.SelectedIndex].ToString();
        }

        private void btnHaberGoster_Click(object sender, EventArgs e)
        {
            if (tbBaslik.Text != "")
            {
                HaberDetay haberDetay = new HaberDetay();
                haberDetay.baslik = tbBaslik.Text;
                haberDetay.Show();
            }
        }

        private void timerXML_Tick(object sender, EventArgs e)
        {
            lbBasliklar.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.star.com.tr/rss/sondakika.xml");
            string temp = TextdenCek();
            eskiVeri = "";
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    string veri = xmlOku.ReadString();
                    lbBasliklar.Items.Add(veri);
                    eskiVeri += veri;
                }
            }
            if (eskiVeri != temp)
            {
                MessageBox.Show("Yeni Haber Geldi !","Yeni Bildirimi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            TexteKaydet();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            XmlTextReader xmlOku = new XmlTextReader("http://www.star.com.tr/rss/sondakika.xml");
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    string veri = xmlOku.ReadString();
                    lbBasliklar.Items.Add(veri);
                    eskiVeri += veri;
                }
                
            }
            TexteKaydet();
        }
        // EskiHaberler.txt
        void TexteKaydet()
        {
            FileStream fs = new FileStream(Application.StartupPath + @"\EskiHaberler.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(eskiVeri);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        string TextdenCek()
        {
            FileStream fs = new FileStream(Application.StartupPath + @"\EskiHaberler.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string veri = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            return veri;
        }
    }
}
