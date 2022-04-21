using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_frase_MouseEnter(object sender, EventArgs e)
        {
            string frase = txt_frase.Text.ToLower();
            int c = 0;
            char[] vchar;
            vchar = frase.ToCharArray();

            frase = " ";
            for (int i = 0; i < vchar.Length; i++)
            {
                if (vchar[i] == 'r')
                {
                    vchar[i] = ' ';
                }
                if (vchar[i] == 'l')
                {
                    vchar[i] = 'u';
                }
                frase += vchar[i].ToString();
                c++;
            }
            if (c > 0)
            {
                MessageBox.Show(frase, "informação");
            }


        }
    }
    }
 
