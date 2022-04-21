using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folha2_Ex_1
{
    public partial class Form1 : Form
    {
        extenco obj = new extenco();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string valor = txt_valor.Text;
            char[] valores = valor.Trim().ToCharArray();

            for(int i=0;i< valores.Length; i++)
            {
                int c = int.Parse(valores[i].ToString());
                txt_resultado.Text += obj.vetExtenco[c]+" ,";
            }
        }
    }
}
