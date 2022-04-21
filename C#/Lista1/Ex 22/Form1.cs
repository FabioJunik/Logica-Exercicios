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
namespace Ex_22
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                int a;
                int v = int.Parse(textBox1.Text);
                listBox1.Items.Clear();
                StreamReader valores = new StreamReader(@"C:\Users\Fábio junic\Documents\multiplo.txt");
                while (!valores.EndOfStream)
                {
                    a = int.Parse(valores.ReadLine());
                    if(a %v == 0)
                    {
                        listBox1.Items.Add(a);
                    }
                }
                 valores.Dispose();
            }catch (Exception b) { }

        }
    }
}
