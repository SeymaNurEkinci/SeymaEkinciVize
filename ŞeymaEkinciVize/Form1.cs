using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;

namespace ŞeymaEkinciVize
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("uyarı ver");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        XmlDocument xdoc = new XmlDocument();
        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
            xdoc.Load(url);
            XmlNodeList secilenil = xdoc.DocumentElement.SelectNodes("sehirler");
            foreach (XmlNode istanbul in secilenil)
            {
                string ili = istanbul.SelectSingleNode("ili").InnerText;
                if (ili == "ISTANBUL")
                {
                    string Durum = istanbul.SelectSingleNode("Durum").InnerText;
                    string Mak = istanbul.SelectSingleNode("Mak").InnerText;
                    listBox1.Items.Add(ili);
                    listBox1.Items.Add(Durum);
                    listBox1.Items.Add(Mak);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
            xdoc.Load(url);
            XmlNodeList secilenil = xdoc.DocumentElement.SelectNodes("sehirler");
            foreach (XmlNode istanbul in secilenil)
            {
                string ili = istanbul.SelectSingleNode("ili").InnerText;
                if (ili == "ANKARA")
                {
                    string Durum = istanbul.SelectSingleNode("Durum").InnerText;
                    string Mak = istanbul.SelectSingleNode("Mak").InnerText;
                    listBox1.Items.Add(ili);
                    listBox1.Items.Add(Durum);
                    listBox1.Items.Add(Mak);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
            xdoc.Load(url);
            XmlNodeList secilenil = xdoc.DocumentElement.SelectNodes("sehirler");
            foreach (XmlNode istanbul in secilenil)
            {
                string ili = istanbul.SelectSingleNode("ili").InnerText;
                if (ili == "IZMIR")
                {
                    string Durum = istanbul.SelectSingleNode("Durum").InnerText;
                    string Mak = istanbul.SelectSingleNode("Mak").InnerText;
                    listBox1.Items.Add(ili);
                    listBox1.Items.Add(Durum);
                    listBox1.Items.Add(Mak);
                }
            }
        }
    }
}

    