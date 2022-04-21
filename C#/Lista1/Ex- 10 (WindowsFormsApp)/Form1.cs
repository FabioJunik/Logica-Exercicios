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

namespace Ex__10__WindowsFormsApp_
{
    public partial class Form1 : Form
    {
        char[] consoante = new char[21];
        char[] vogal = new char[5];
        char[] p;
        string frase;

        private void criar()
        {
            vogal[0]= 'a';
            vogal[1]= 'e';
            vogal[2]= 'i';
            vogal[3]= 'o';
            vogal[4]= 'u';

            consoante[0] = 'b';
            consoante[1] = 'c';
            consoante[2] = 'd';
            consoante[3] = 'f';
            consoante[4] = 'g';
            consoante[5] = 'h';
            consoante[6] = 'j';
            consoante[7] = 'k';
            consoante[8] = 'l';
            consoante[9] = 'm';
            consoante[10] = 'n';
            consoante[11] = 'p';
            consoante[12] = 'q';
            consoante[13] = 'r';
            consoante[14] = 's';
            consoante[15] = 't';
            consoante[16] = 'v';
            consoante[17] = 'w';
            consoante[18] = 'x';
            consoante[19] = 'y';
            consoante[20] = 'z';
        }
        
        public Form1()
        {
            criar();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A =textBox1.Text;
            /*verificarConsoante(A);
            verificarVogal(A);*/
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                string A =textBox1.Text;
                p = A.ToCharArray();
                //p = new char[p.Length];
                for(int c=0;c<p.Length;c++)
                {
                    sumirConsoante(verificarConsoante(p[c]),c);
                    sumirVogal(verificarVogal(p[c]),c);
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool verificarConsoante(char l)
        {
            bool v = false;
            for(int c = 0; c < consoante.Length; c++)
            {
                if (l == consoante[c])
                    v = true;
            }
            return v;
        }
        private bool verificarVogal(char l)
        {
            bool v = false;
            for (int c = 0; c < vogal.Length; c++)
            {
                if (l == vogal[c])
                    v = true;
            }
            return v;
        }

        private void sumirVogal(bool v, int n)
        {
            string palavra="";
            if (v == true)
            {
                textBox2.Text = palavra +" "+p[n].ToString();
                palavra = textBox2.Text;
                textBox2.Text = " ";
                p[n] = ' ';
            }
        }
        private void sumirConsoante(bool v, int n)
        {
            if (v == true)
            {
                frase += p[n];
                textBox3.Text = frase;
            }
        }
    }
}
