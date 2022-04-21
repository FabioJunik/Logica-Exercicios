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

namespace Ex_20
{
    public partial class Form1 : Form
    {
        int c = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string diretion = textBox1.Text;
            string name = txt_name.Text;
            string file = diretion + "/" + name;

            if(Directory.Exists(file))
            { 
                Directory.CreateDirectory(file+"("+c+")");
                c++;
            }
            else
                Directory.CreateDirectory(file);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
