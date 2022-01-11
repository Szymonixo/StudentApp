using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace StuadentApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string sbtntxt = File.ReadAllText("sbtn.txt");
            button4.Text = sbtntxt.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("https://www.dlaucznia.pl/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("https://www.nowaera.pl/przygotowanie-do-matury");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("https://www.terazmatura.pl/moja-matura");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string surl = File.ReadAllText("sbtnurl.txt");
            chromiumWebBrowser1.LoadUrl(surl);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fpath = path + "\\EPOP-P1-100-2105.pdf";

                string remoteUri = "http://jezdziecduszy.5v.pl/";
                string fileName = "EPOP-P1-100-2105.pdf", myStringWebResource = null;

                // Concatenate the domain with the Web resource filename.
                myStringWebResource = remoteUri +fileName ;

                client.DownloadFile(myStringWebResource,fpath);



            }
           
        }




    }
}
