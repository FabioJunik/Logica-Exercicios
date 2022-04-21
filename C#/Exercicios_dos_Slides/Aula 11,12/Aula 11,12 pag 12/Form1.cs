using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_12_pag_12
{
    public partial class Form1 : Form
    {
        string[] vetNomes;
        int qtd;
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_lerQauntidade_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txt_qtdNome.Text);
            vetNomes = new string[qtd];
            txt_qtdNome.ReadOnly = true;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void btn_lerNome_Click(object sender, EventArgs e)
        {
            try
            {
                if (c + 1 == qtd)
                    txt_nome.ReadOnly = true;

                vetNomes[c] = txt_nome.Text;
                c++;
            }
            catch (Exception ex){MessageBox.Show("ERRO\n", ex.ToString());}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Array.Sort(vetNomes);
            foreach (var n in vetNomes)
            {
                lb_nome.Items.Add(n);
            }
        }
    }
}
