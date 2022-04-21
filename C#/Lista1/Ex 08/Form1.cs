using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_08__Domingos_
{
    public partial class Form1 : Form
    {
        int[] valores= new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_valores_Click(object sender, EventArgs e)
        {
            Random d = new Random();

            for (int cont = 0; cont < 5; cont++)
            {
                valores[cont] = d.Next(1000, 9999);
                listBox1.Items.Add(valores[cont]);
            }

        }

        private void btn_impares_Click(object sender, EventArgs e)
        {
            for(int cont = 0; cont < 5; cont++)
            {
                int pp = valores[cont] / 100;
                int sp= valores[cont] % 100;

                if (pp % 2 !=0 && sp % 2 !=0)
                    listBox2.Items.Add(valores[cont]);
                else if (pp % 2 != 0)
                    listBox2.Items.Add(pp);
                else if (sp % 2 != 0)
                    listBox2.Items.Add(sp);
            }
        }
    }
}
