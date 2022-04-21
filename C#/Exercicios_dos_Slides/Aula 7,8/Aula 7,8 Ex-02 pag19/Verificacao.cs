using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7_8_Ex_02_pag19
{
    class Verificacao
    {
        public bool Par(int num)
        {
            return num % 2==0;
        }
        public bool Impar(int num)
        {
            return num % 2 != 0;
        }
        public bool Positivo(int num)
        {
            return num > 0;
        }
        public bool Negativo(int num)
        {
            return num < 0;
        }
        public bool Perfeito(int num)
        {
            int somaDivisores = 0;
            for (int cont=1; cont < num; cont++)
            {
                if (num % cont == 0)
                    somaDivisores += cont;
            }
            if (somaDivisores == num)
                return true;
            else
                return false;
        }
        public bool Diferentes(int num1, int num2)
        {
            return num1 != num2;
        }
        public bool Amigos(int num1, int num2)
        {
            int qtd1 = SomaDivisores(num1);
            int qtd2 = SomaDivisores(num2);

            if (qtd1 == qtd2)
                return true;

            return false;
        }
        public bool TemPrimo(int num1,int num2)
        {
            return Primo(num1) || Primo(num2);
        }



        public bool Primo(int num)
        {
            int qtd=0;
            for (int cont = 1; cont <= num; cont++)
            {
                if (num % cont == 0)
                    qtd++;
            }
            if (qtd == 2)
                return true;

            return false;
        }
        public int SomaDivisores(int num)
        {
            int soma = 0;
            for (int cont = 1; cont <= num; cont++)
            {
                if (num % cont == 0)
                    soma+=cont;
            }

            return soma;
        }
    }
}
