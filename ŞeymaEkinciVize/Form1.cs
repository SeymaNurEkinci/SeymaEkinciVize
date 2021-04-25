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

        private void button1_Click(object sender, EventArgs e)
        {
            
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument hava = XDocument.Load(https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml);
        }
    }

    
        

        
    }


    