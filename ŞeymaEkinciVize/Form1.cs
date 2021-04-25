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
        string hava_durumu_link = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public Form1()
        {
            InitializeComponent();


        }

        private const string api = "60a369421209b65fd1ec279338e6d400";
        private const string baglanti = "http://api.openweathermap.org/data/2.5/weather?q=Yalova&mode=xml&lang=tr&units=metric&appid=" + api;

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("uyarı ver");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument havadurumu = XDocument.Load(baglanti);
            var sicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label_drc.Text = sicaklik.ToString() + "ºC";
            var durum = havadurumu.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            label_drm.Text = durum.ToString();
            if (durum.Contains("clouds") == true)
            {
                picture_bulutlu.Visible = true;
            }
           

        }
    }

    
        

        
    }


    