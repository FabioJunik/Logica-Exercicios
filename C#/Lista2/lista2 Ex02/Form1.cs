using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista2_Ex02
{
    public partial class Form1 : Form
    {
        string[] nameConector = new string[6]{ "e", "do", "da", "dos", "das","de"};
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string[] subNome = nome.Split(' ');

            for(int i=0;i<subNome.Length;i++)
            {
                if (!nameConector.Contains(subNome[i]))
                {
                    string inicial = subNome[i][0].ToString();
                    txt_inicias.Text += inicial.ToUpper();
                }
            }
        }
    }
}
