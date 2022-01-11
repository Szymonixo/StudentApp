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

namespace StuadentApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            StreamWriter streamWriter = File.CreateText("study.txt");
            streamWriter.WriteLine(textBox1.Text);
            streamWriter.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            StreamWriter streamWriter = File.CreateText("sbtnurl.txt");
            streamWriter.WriteLine(textBox2.Text);
            streamWriter.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            StreamWriter streamWriter = File.CreateText("sbtn.txt");
            streamWriter.WriteLine(textBox3.Text);
            streamWriter.Close();
        }
    }
}
