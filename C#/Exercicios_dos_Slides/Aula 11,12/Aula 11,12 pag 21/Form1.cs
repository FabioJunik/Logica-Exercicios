using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_12_pag_21
{
    public partial class Form1 : Form
    {
        int[,] mat = new int[5, 5];
        Calculos obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(5);

            dataGridView1.Rows[0].HeaderCell.Value= "0";
            dataGridView1.Rows[1].HeaderCell.Value= "1";
            dataGridView1.Rows[2].HeaderCell.Value= "2";
            dataGridView1.Rows[3].HeaderCell.Value= "3";
            dataGridView1.Rows[4].HeaderCell.Value = "4";
        }

        private void btn_lerMatriz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat[i, j] = int.Parse(Interaction.InputBox("Posição[" + i + "," + j + "]"));
                    dataGridView1[j, i].Value = mat[i, j];
                }
            }
            obj = new Calculos(mat);

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            int linhaD = int.Parse(txt_linha.Text);
            int colunaD = int.Parse(txt_coluna.Text);

            imprimirColuna(colunaD);
            imprimirLinha(linhaD);

            int[] vetLinha = obj.SomaDeCadaLinha();
            int[] vetColuna = obj.SomaDeCadaColuna();

            for(int i = 0; i < vetLinha.Length; i++)
            {
                lb_SomaColuna.Text = vetColuna[i].ToString();
            }

            for (int i = 0; i < vetLinha.Length; i++)
            {
                lb_SomaLinha.Text = vetColuna[i].ToString();
            }
        }

        private void imprimirLinha(int i)
        {
            for(int j=0;j<5;j++)
                lb_linha.Items.Add(mat[i, j]);
        }
        private void imprimirColuna(int i)
        {
            for (int j = 0; j < 5; j++)
                lb_coluna.Items.Add(mat[j,i]);
        }

    }
}
