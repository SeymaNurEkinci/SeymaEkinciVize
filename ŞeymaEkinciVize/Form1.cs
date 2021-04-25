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


        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("uyarı ver");
        }

        
    }

    
        

        
    }


    