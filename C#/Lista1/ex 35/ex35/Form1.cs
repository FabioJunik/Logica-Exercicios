using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_frase_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = txt_frase.Text.ToLower();
            char[] vchar;

            

            vchar = frase.ToCharArray();

            frase = " ";
            for (int i = 0; i < vchar.Length; i++)
            {
                if (vchar[i] == 'a')
                {
                    vchar[i] = '1';
                }
                if (vchar[i] == 'e')
                {
                    vchar[i] = '2';
                }
                if (vchar[i] == 'i')
                {
                    vchar[i] = '3';
                }
                if (vchar[i] == 'o')
                {
                    vchar[i] = '4';
                }
                if (vchar[i] == 'u')
                {
                    vchar[i] = '5';
                }
                frase += vchar[i].ToString();
            }

            txt_frase.Text = frase;
        }
    }
}
