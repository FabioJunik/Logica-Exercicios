using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_12_pag_21
{
    class Calculos
    {
        private int[,] mat;

        public Calculos(int [,] mat)
        {
            this.mat = mat;
        }

        public int[] SomaDeCadaLinha()
        {
            int[] vet = new int[5];
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    soma += mat[i, j];
                }
                vet[i] = soma;
                soma = 0;
            }

            return vet;
        }

        public int[] SomaDeCadaColuna()
        {
            int[] vet = new int[5];
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    soma += mat[j, i];
                }
                vet[i] = soma;
                soma = 0;
            }

            return vet;
        }
    }
}
