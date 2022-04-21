using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l1
{
    public partial class Form1 : Form
    {
        string n;
        int c=0,k;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = textBox1.Text;
            k = n.Length;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n.Substring(k - 2, 1) == "e") {
                label2.Text = n.Replace("er", "o");
                label3.Text = n.Replace("er", "es");
                label4.Text = n.Replace("er", "e");
                label5.Text = n.Replace("er", "emos");
                label6.Text = n.Replace("er", "eis");
                label7.Text = n.Replace("er", "em");
                    }
                 else if (n.Substring(k - 2, 1) == "a"){
                label2.Text = n.Replace("ar", "o");
                label3.Text = n.Replace("ar", "as");
                label4.Text = n.Replace("ar", "a");
                label5.Text = n.Replace("ar", "amos");
                label6.Text = n.Replace("ar", "ais");
                label7.Text = n.Replace("ar", "am");
                    }
                 else if (n.Substring(k - 2, 1) == "i"){
                label2.Text = n.Replace("ir", "o");
                label3.Text = n.Replace("ir", "es");
                label4.Text = n.Replace("ir", "e");
                label5.Text = n.Replace("ir", "imos");
                label6.Text = n.Replace("ir", "eis");
                label7.Text = n.Replace("ir", "em");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
