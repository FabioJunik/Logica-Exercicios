using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_12_pag_11
{
    public partial class Form1 : Form
    {
        int[] vetNumeros;
        CalculosVetor obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_criarVetor_Click(object sender, EventArgs e)
        {
            vetNumeros = new int[int.Parse(txt_tamanho.Text)];
            Random random = new Random();
            int minimo = int.Parse(txt_valorMinimo.Text);
            int maximo = int.Parse(txt_valorMaximo.Text);

            for(int i = 0; i < vetNumeros.Length; i++)
            {
                vetNumeros[i] = random.Next(minimo, maximo);
                lb_geradosUmaVez.Items.Add(vetNumeros[i]);
            }

            obj = new CalculosVetor(vetNumeros);
            
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            txt_mediaPares.Text = obj.MediaPares().ToString();


            txt_maiorValor.Text = vetNumeros.Max().ToString();
        }
    }
}
