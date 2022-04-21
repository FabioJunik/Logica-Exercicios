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

namespace Aula_25_26_pag_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader quantide = new StreamReader(@"C:\zfabio\numero.txt");

            int qtd = int.Parse(quantide.ReadLine());
            quantide.Close();

            int menos = qtd - 1;

            if(menos <=0)
            {
                MessageBox.Show("O número de utilizacao excedido\nNao podera utilizar mais o Aplicativo!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Voce só pode abrir o programa 5 vezes\nJa abriste: " + (5 - menos) + "\nRestam: " + menos);

                StreamWriter quant = new StreamWriter(@"C:\zfabio\numero.txt");
                quant.Write(menos);
                quant.Close();
            }

        }
        private void btn_executar_Click(object sender, EventArgs e)
        {
            label1.Text = "Ola mundo!";


        }
    }
}
