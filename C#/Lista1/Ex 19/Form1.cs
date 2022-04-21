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

namespace Ex_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = txt_caminho.Text;
            string[] qtdVideo = Directory.GetFiles(path, "*mp4");
            string[] qtdImagens = Directory.GetFiles(path, "*jpg");
            int qtdV = 0;
            int qtdI = 0;
            for(int cont = 0; cont < qtdVideo.Length; cont++)
            {
                qtdV++;
            }
            for (int cont = 0; cont < qtdImagens.Length; cont++)
            {
                qtdI++;
            }
            txt_video.Text = qtdV.ToString();
            txt_image.Text = qtdI.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
