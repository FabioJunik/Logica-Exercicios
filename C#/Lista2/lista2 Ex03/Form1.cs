using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista2_Ex03
{
    public partial class Form1 : Form
    {
        Data obj = new Data();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string data = txt_data.Text;
            string[] divData = data.Split('/');

            int mes = int.Parse(divData[1]);

            divData[1] = obj.mes[mes];

            lbl_extenceDate.Text = "Você nasceu em " + divData[0] + " de " + divData[1]
                                   + " de " + divData[2];                     
        }
    }
}
