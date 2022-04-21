using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            listBox1.Items.Clear();
            mPA(n);
        }

        private void mPA(int v)
        {
            for(int c=1; c < v; c++)
            {
                if (primo(c))
                   listBox1.Items.Add(metade(c));
            }
        }

        private bool primo(int v)
        {
            int q = 0;
            for(int c=1;c<=v;c++)
            {
                if (v % c == 0)
                    q++;
            }
            if (q == 2)
                return true;
            else
                return false;
        }

        private double metade(float v)
        {
            return v/2;
        }
    }
}
