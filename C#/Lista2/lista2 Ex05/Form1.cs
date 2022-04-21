using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace lista2_Ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            bool ctrl = true;
            int c = 0;
            string word = "";
            string biggestWord = "";
            string smallestWord = "";
            do
            {
                string oldWord = word;
                word = Interaction.InputBox("Digite uma palava");

                lb_listaPalavra.Items.Add(word);

                if (c > 0)
                {
                    if (word.Length > biggestWord.Length)
                        biggestWord = word;

                    if (word.Length < smallestWord.Length)
                        smallestWord = word;

                    if (word == oldWord)
                    {
                        ctrl = false;
                        MessageBox.Show("Lida dos palavras iguais!");
                    }
                }
                else
                {
                   smallestWord= biggestWord = word;
                }
                c++;
                for (int i = 0; i < word.Length - 2; i++)
                {
                    string subWord = word.Substring(i);
                    if (subWord[0] == subWord[1] && subWord[1] ==subWord[2])
                    {
                        ctrl = false;
                        MessageBox.Show("Três caracteres iguas consecutivos na palavra");
                        break;
                    }
                }
                for (int i=0;i< word.Length-1; i++)
                {
                    string subWord= word.Substring(i);
                    if(subWord[0]==subWord[1] && ctrl==true)
                    {
                        ctrl = false;
                        MessageBox.Show("Dois caracteres iguas consecutivos na palavra");
                        break;
                    }
                }
            } while (ctrl);

            for(int i = 0; i < biggestWord.Length; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                dataGridView1.Rows.Add();

            }

            int j = biggestWord.Length - 1;
            int k = 0;
            for (int i = 0; i < biggestWord.Length; i++)
            {
                dataGridView1[i, i].Value = biggestWord[i];
                if (k < smallestWord.Length)
                    dataGridView1[j,i].Value = smallestWord[k];

                dataGridView1[i, i].Style.BackColor = Color.Aqua;
                dataGridView1[j, i].Style.BackColor = Color.AliceBlue;
                k++; j--;
            }
        }
    }
}
