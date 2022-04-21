using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex_14
{
    public partial class Form1 : Form
    {
        int[] vet;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_lerNota_Click(object sender, EventArgs e)
        {
            try{
                StreamWriter notas = new StreamWriter(@"C:\Users\Fábio junic\Documents\arquivos para testes em c#\notas.txt", true);
                notas.WriteLine(int.Parse(txt_nota.Text));
                notas.Dispose();

                txt_nota.Text = "";
                txt_nota.Focus();
            }catch(Exception) { }
           
        }

        private void btn_qNotas_Click(object sender, EventArgs e)
        {
            int c = 0;
            StreamReader notas = new StreamReader(@"C:\Users\Fábio junic\Documents\arquivos para testes em c#\notas.txt");
            
            while(!notas.EndOfStream)
            {
                notas.ReadLine();
                c++;
            }
            txt_qNotas.Text = c.ToString();
            notas.Dispose();
        }

        private void btn_lNormal_Click(object sender, EventArgs e)
        {
            StreamReader notas = new StreamReader(@"C:\Users\Fábio junic\Documents\arquivos para testes em c#\notas.txt");

            while (!notas.EndOfStream)
            {
                listBox1.Items.Add(notas.ReadLine());
            }
            notas.Dispose();
        }

        private void btn_lInversa_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
