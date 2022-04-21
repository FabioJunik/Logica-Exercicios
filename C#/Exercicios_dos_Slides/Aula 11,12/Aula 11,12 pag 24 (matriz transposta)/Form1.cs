using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_12_pag_24__matriz_transposta_
{
    public partial class Form1 : Form
    {
        int[,] matNumero;
        int linha;
        int coluna;
        int lin = 0;
        int col = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_criarMatriz_Click(object sender, EventArgs e)
        {
            linha = int.Parse(txt_linha.Text);
            coluna = int.Parse(txt_coluna.Text);

            matNumero = new int[linha, coluna];

            txt_linha.ReadOnly = true;
            txt_coluna.ReadOnly = true;
            btn_criarMatriz.Enabled = false;
        }

        private void btn_lerValor_Click(object sender, EventArgs e)
        {
            int valor= int.Parse(txt_valor.Text);

            if (coluna > col && linha > lin)
            {
                matNumero[lin,col] = valor;

                lbl_posicao.Text = "Posiçao: [" + lin + "," + col + "]";
                lb_matriz.Items.Add(matNumero[lin, col]);

                col +=1;

                if (coluna == col)
                {
                    col = 0;
                    lin++;
                }
                if (linha == lin)
                    lin--;
            }

            if (coluna == col + 1 && linha == lin + 1)
            {
                lbl_posicao.Text = "Posiçao: [" + lin + "," + col + "]";
                lb_matriz.Items.Add(matNumero[lin, col]);
                btn_lerValor.Enabled = false;
            }
            txt_valor.Focus();
               
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            int[,] matTransposta = new int[coluna, linha];
            string linhas=" ";

            for (int i = 0; i < linha; i++)
                for (int j = 0; j < coluna; j++)
                    matTransposta[j, i] = matNumero[i, j];

            //foreach (int i in matTransposta)
            //    lb_matrizTransposta.Items.Add(i);

            for (int i = 0; i < coluna; i++)
            {
                for (int j = 0; j < linha; j++)
                {
                    linhas+=" | "+matTransposta[i, j];
                }
                lb_matrizTransposta.Items.Add(linhas);
                linhas = " ";
            }
        }
    }
}
