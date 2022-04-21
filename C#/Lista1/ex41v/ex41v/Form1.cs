using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;1
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex41v
{
    public partial class Form1 : Form
    {
        char[] vchar2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_criptografar_Click(object sender, EventArgs e)
        {
            string frase = txt_frase.Text;
            criptografar(frase);
            
        }

        private void criptografar(string c)
        {
            char[] vchar;
            vchar = c.ToCharArray();
            vchar2 = c.ToCharArray();
            c = " ";
            for(int i = 0; i < vchar.Length; i++)
            {
                if (vchar[i] == 'a'|| vchar[i] == 'e' || vchar[i] == 'i' || vchar[i] == 'o' || vchar[i] == 'u')
                {
                    vchar[i] = ' ';
                }
                c += vchar[i].ToString();
            }
            
            txt_frase.Text = c;
        }
        private void descriptografar(string c)
        {
            c.ToLower();

            c = " ";
            for(int i = 0; i < vchar2.Length; i++)
            {
                c += vchar2[i];
            }
            txt_frase.Text = "";
            txt_frase.Text = c;
        }

        private void btn_descriptografar_Click(object sender, EventArgs e)
        {
            string frase = txt_frase.Text;
            descriptografar(frase);
        }
    }
}
