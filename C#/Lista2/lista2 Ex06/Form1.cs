using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista2_Ex06
{
    public partial class Form1 : Form
    {
        int[,] matriz = new int[6, 6];
        Random a = new Random();

        public void CriarMatriz()
        {
            for(int i=0;i<6;i++)
                for(int j = 0; j < 6; j++)
                {
                    matriz[i, j] = a.Next(1, 9);
                    dgv_matriz[j,i].Value = matriz[i, j];
                }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_matriz.Rows.Add(6);
            dgv_matriz.Rows[0].HeaderCell.Value = "0";
            dgv_matriz.Rows[1].HeaderCell.Value = "1";
            dgv_matriz.Rows[2].HeaderCell.Value = "2";
            dgv_matriz.Rows[3].HeaderCell.Value = "3";
            dgv_matriz.Rows[4].HeaderCell.Value = "4";
            dgv_matriz.Rows[5].HeaderCell.Value = "5";
            btn_executar.Enabled = false;
        }

        private void btn_criarMatriz_Click(object sender, EventArgs e)
        {
            CriarMatriz();
            btn_executar.Enabled = true;
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {

            int a, b, c;

            int l1,l2,l3, lm1, lm2, lm3,lp1, lp2, lp3;
            l1 = l2 = l3 = lp1 = lp2 = lp3 = lm1= lm2= lm3=0;
            int c1, c2 , c3, cm1, cm2, cm3, cp1, cp2, cp3;

            cp1=cm1=c1 = 0;
            cp2=cm2=c2 = 1;
            cp3=cm3=c3 = 2;

            a = matriz[l1, c1];
            b = matriz[l2, c2];
            c = matriz[l3, c3];

            int maior, menor, produto;

            menor=maior = a*100 + b*10 + c;
            produto = a * b * c;

            int i1, i2,j1, j2;

            for(int i=0;i<6;i++)
            {
                int k=0;
                
                for (int j = 0; j < 6; j++)
                {
                    a = matriz[i, j];

                    if (j + 1 > 5) {
                        b = matriz[i + 1, k - 1];
                        i1 = i + 1;
                        j1 = k - 1;
                    }
                    else {
                        b = matriz[i, j + 1];
                        i1 = i; j1 = j+1;
                    }

                    if (j + 2 > 5)
                    {
                        if (i == 5)
                            break;
                        
                        c = matriz[i + 1, k];
                        i2 = i + 1; j2 = k;
                        k++;
                    }
                    else {
                        c = matriz[i, j + 2];
                        i2 = i ; j2 = j+2;
                    }

                    int soma = a*100 + b*10 + c;
                    int prod = a * b * c;

                    if (soma > maior)
                    {
                        l1 = i;  c1 = j;
                        l2 = i1; c2 = j1;
                        l3 = i2; c3 = j2;

                        maior = soma;
                    }
                    if (soma < menor)
                    {
                        lm1 = i; cm1 = j;
                        lm2 = i1; cm2 = j1;
                        lm3 = i2; cm3 = j2;

                        menor = soma;
                    }
                    if (prod > produto)
                    {
                        lp1 = i; cp1 = j;
                        lp2 = i1; cp2 = j1;
                        lp3 = i2; cp3 = j2;

                        produto = prod;
                    }
                }
            }


            dgv_matriz[c1,l1].Style.BackColor = Color.Red;
            dgv_matriz[c2,l2].Style.BackColor = Color.Red;
            dgv_matriz[c3,l3].Style.BackColor = Color.Red;

            dgv_matriz[cp1, lp1].Style.BackColor = Color.Blue;
            dgv_matriz[cp2, lp2].Style.BackColor = Color.Blue;
            dgv_matriz[cp3, lp3].Style.BackColor = Color.Blue;

            dgv_matriz[cm1, lm1].Style.BackColor = Color.Green;
            dgv_matriz[cm2, lm2].Style.BackColor = Color.Green;
            dgv_matriz[cm3, lm3].Style.BackColor = Color.Green;
        }
    }
}
