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

namespace L1_Ex_29
{
    public partial class Form1 : Form
    {
        int qtd = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_executar_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:/fabio"))
            {
                Directory.CreateDirectory(@"C:/fabio");
                StreamWriter file_agenda = new StreamWriter(@"C:/fabio/agenda.txt", true);
 
                Escrever(file_agenda);
                SortFile(Ler());
                file_agenda.Close();
               
            }
            else
            {
                if (!File.Exists(@"C:/fabio/agenda.txt"))
                    Escrever(new StreamWriter(@"C:/fabio/agenda.txt", true));
                SortFile(Ler());
            }
        }

        private string[] Ler()
        {
            int i = 0;
            StreamReader file_agenda = new StreamReader(@"C:/fabio/agenda.txt");

            while (!file_agenda.EndOfStream)
            {
                file_agenda.ReadLine();
                qtd++;
            }
            file_agenda.Close();


            string[] lista = new string[qtd];
            
           StreamReader file_agend = new StreamReader(@"C:/fabio/agenda.txt");

            while (!file_agend.EndOfStream)
            {
                lista[i++] = file_agend.ReadLine();
                MessageBox.Show(i.ToString());
            }

            file_agend.Close();

            Array.Sort(lista);
            
            return lista;

        }

        private void SortFile(string[] lista)
        {
            if(File.Exists(@"C:/fabio/agenda organizada.txt"))
                File.Delete(@"C:/fabio/agenda organizada.txt");

            StreamWriter file_agenda = new StreamWriter(@"C:/fabio/agenda organizada.txt",true);

            for (int i = 0; i < lista.Length; i++)
            {
                file_agenda.WriteLine(lista[i]);

            }
            file_agenda.Close();
        }

        private void Escrever(StreamWriter arq)
        {
            arq.WriteLine("Fábio Mada - 932012321");
            arq.WriteLine("Simão Refael - 93723619");
            arq.WriteLine("Denilson Gaspar - 912938242");
            arq.WriteLine("André Batista - 949202230");
            arq.WriteLine("Envaristo Diogo - 999239231");
            arq.WriteLine("Maria de Jesus - 910273572");
            arq.Close();
        }
    }
}
