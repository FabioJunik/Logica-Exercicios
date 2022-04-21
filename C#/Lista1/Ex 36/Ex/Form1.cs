using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ex
{
    public partial class Form1 : Form
    {
        string[] vet;
        string first;
        char[] g;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_criptografar_Click(object sender, EventArgs e)
        {
            string texto = txt_frase.Text;
            first = texto;
            cripto(texto);

        }
        private void cripto(string c)
        {
            string texto = txt_frase.Text.ToLower();
            char[] vchar = texto.ToCharArray();
           
            byte []b;

            b = Encoding.ASCII.GetBytes(txt_frase.Text);




            txt_frase.Text = BitConverter.ToString(b);
        }

        private void btn_descriptografar_Click(object sender, EventArgs e)
        {
            txt_frase.Text = "";
            txt_frase.Text = first;
        }
    }
}
