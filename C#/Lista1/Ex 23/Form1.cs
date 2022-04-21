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

namespace Ex_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader ips = new StreamReader(@"C:\Users\Fábio junic\Documents\arquivos para testes em c#\IPs.txt");
            string ip;
            

            while (!ips.EndOfStream)
            {
                ip = ips.ReadLine();
                int t=0;
                string[] part=ip.Split('.');
                for(int c = 0; c < part.Length; c++)
                {
                    if(int.Parse(part[c])< 225)
                    {
                        t++;
                    }
                }
                if (t == part.Length)
                {
                    listBox1.Items.Add(ip);
                }

            }
        }
    }
}
