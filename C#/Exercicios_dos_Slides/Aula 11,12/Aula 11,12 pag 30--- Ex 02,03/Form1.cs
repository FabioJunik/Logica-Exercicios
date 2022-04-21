using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_12_pag_30____Ex_02_03
{
    public partial class Form1 : Form
    {
        OperationString obj = new OperationString();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string text = txt_text.Text;

            txt_resultado.Text = obj.AbreviarNome(text);
        }

        private void btn_criptografar_Click(object sender, EventArgs e)
        {
            string text = txt_text.Text;
        
            txt_resultado.Text = obj.Criptografar(text);
        }

        private void btn_virus_Click(object sender, EventArgs e)
        {
            string text = txt_text.Text;

            txt_resultado.Text = obj.Virus(text).ToString();

        }
    }
}
