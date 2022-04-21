using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_frase_MouseClick(object sender, MouseEventArgs e)
        {
            string frase = txt_frase.Text.ToLower();
            int c=0;
            char[] vchar;
            char maior=' ';
            vchar = frase.ToCharArray();
             
            for(int i = 0; i < vchar.Length; i++)
            {
                if (i == 0)
                {
                    maior = vchar[i];

                }else
                    if (vchar[i] > maior)
                {
                    maior = vchar[i];
                }

            }
            frase = " ";

            for(int i = 0; i < vchar.Length; i++)
            {
                if (maior == vchar[i])
                {
                    c++;
                }
               
            }
             frase += "maior é " + maior.ToString()+", tamanho "+c.ToString();
            txt_resultado.Text = frase;
        }
    }
}
