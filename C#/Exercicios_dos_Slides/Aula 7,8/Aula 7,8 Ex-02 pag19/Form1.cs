using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_7_8_Ex_02_pag19
{
    public partial class Form1 : Form
    {
        Verificacao obj = new Verificacao();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt_num.Text);

            txt_par.Text = obj.Par(num).ToString();
            txt_impar.Text = obj.Impar(num).ToString();
            txt_positivo.Text = obj.Positivo(num).ToString();
            txt_negativo.Text = obj.Negativo(num).ToString();
            txt_perfeito.Text = obj.Perfeito(num).ToString();
        }

        private void bnt_vericar2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);

            txt_primo.Text = obj.TemPrimo(num1, num2).ToString();
            txt_amigo.Text = obj.Amigos(num1, num2).ToString();
            txt_maior.Text = obj.Diferentes(num1, num2).ToString();
        }
    }
}
