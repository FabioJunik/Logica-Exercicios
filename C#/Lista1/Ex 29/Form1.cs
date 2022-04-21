using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_29
{
    public partial class Form1 : Form
    {
        Agend[] vet = new Agend[15];
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            vet[cont].num = int.Parse(txt_num.Text);
            vet[cont].nome = txt_nome.Text;
            listBox1.Items.Add(vet[cont].nome + "  " + vet[cont].num);
            cont++;
        }
    }
}
