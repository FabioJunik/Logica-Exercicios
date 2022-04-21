using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_12_pag_30_Ex_01__S_casamento_
{
    public partial class Form1 : Form
    {
        OperationString obj =new OperationString();
        public Form1()
        {
            InitializeComponent();
            txt_novoNome.Visible = false;
            btn_executar.Enabled = false;
            lbl_novoNome.Visible = false;

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string mulher = txt_nomeMulher.Text;
            string homem = txt_nomeHomem.Text;

            txt_novoNome.Visible = true;
            lbl_novoNome.Visible = true;

            txt_novoNome.Text= " "+obj.Casamento(homem,mulher);
        }

        private void rb_sim_CheckedChanged(object sender, EventArgs e)
        {
            btn_executar.Enabled = true;
        }

        private void rb_nao_CheckedChanged(object sender, EventArgs e)
        {
            btn_executar.Enabled = false;
        }
    }
}
