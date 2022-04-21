using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex37
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
            string aux="";
            int tam = 0;

            string[] vet;

            vet = frase.Split(' ');
            tam = vet.Length;
            frase=" ";
            for (int i = 0; i <  tam; i++)
            {

                aux = vet[tam - 1];
                vet[tam - 1] = " ";
                vet[tam - 1] = vet[0];
                vet[0] = " ";
                vet[0] = aux;


                frase += vet[i]+" ";
            }

            txt_novafrase.Text = frase;
        }
    }
}
