using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            char[] subFrase = (txt_ler.Text).ToCharArray();

            listBox1.Items.Clear();
            for(int cont=0;cont<subFrase.Length;cont++)
            {
                int qtd=0;
                int cont2 = cont + 1;

                if (!foiComparado(cont2, subFrase))
                {
                    for (; cont2 < subFrase.Length; cont2++)
                    {
                        if (subFrase[cont] == subFrase[cont2])
                        {
                            qtd++;
                        }
                    }
                }
                if(qtd>0)
                {
                    listBox1.Items.Add(subFrase[cont]+" : "+qtd);
                }
            }
        }

        private bool foiComparado(int contA, char[] vet)
        {
            bool verific=false;
            for(int cont = contA-1; cont > 0; cont--)
            {
                if (vet[contA] == vet[cont])
                    verific = true;
            }
            return verific;
        }
    }
}
