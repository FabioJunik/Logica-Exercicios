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

namespace Ex_31
{
    public partial class Form1 : Form
    {
        StreamReader arquivo1;
        StreamReader arquivo2;
        string[] vet = new string[100];
        int qtd = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_caminho_Click(object sender, EventArgs e)
        {
            string path = txt_caminho.Text;
            string nome = txt_nome.Text;
            arquivo1=new StreamReader(path+"\\"+nome+".txt");
            int cont = 0;
            //StreamReader valores = new StreamReader(@"C:\Users\Fábio junic\Documents\multiplo.txt");
            while (!arquivo1.EndOfStream)
            {
                vet[cont]=arquivo1.ReadLine();
                lb_arquivo1.Items.Add(vet[cont]);
                qtd++;
                cont++;
            }
            for(int cont2=cont-1;cont2>=0;cont2--)
            {
                lb_arquivo2.Items.Add(vet[cont2]);
            }
            arquivo1.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
