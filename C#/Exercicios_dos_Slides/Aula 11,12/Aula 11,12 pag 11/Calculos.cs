using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_12_pag_11
{
    class CalculosVetor
    {
        private int[] vet;
        public int qtdPares=0;

        public CalculosVetor(int[] vet)
        {
            this.vet = vet;
        }

        public int QtdPares()
        {
            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                    qtdPares++;
            }

            return qtdPares;
        }

        public int[] Pares()
        {
            int qtd = QtdPares();
            int[] pares = new int[qtd];
            int q = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    pares[q] = vet[i];
                    q++;
                }
            }

            return pares;
        }

        public float MediaPares()
        {
            int[] pares = new int[QtdPares()];
            pares = Pares();

            foreach(var i in pares)
            {
                System.Windows.Forms.MessageBox.Show(" ="+i);
            }
            float soma = pares.Sum();

            System.Windows.Forms.MessageBox.Show(" =" + soma);
            System.Windows.Forms.MessageBox.Show(" =" + QtdPares());

            return soma / pares.Length;
        }
    }
}
