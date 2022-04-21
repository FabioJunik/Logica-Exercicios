using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista2_Ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string texto = txt_texto.Text;
            string palavra = txt_palavra.Text;

            int q = 0;

            string[] vetTexto = texto.Split(' ');

            for(int i=0;i<texto.Length;i++)
            {
                if(texto.Length - i  >= palavra.Length)                  
                if (texto.Substring(i, palavra.Length) == palavra)
                    q++;
            }

            txt_qtd.Text = q.ToString();
        }
    }
}
