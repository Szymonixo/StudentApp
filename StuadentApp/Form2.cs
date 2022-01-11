using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StuadentApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string url = File.ReadAllText("study.txt");
            chromiumWebBrowser1.LoadUrl(url);

        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }
    }
}
