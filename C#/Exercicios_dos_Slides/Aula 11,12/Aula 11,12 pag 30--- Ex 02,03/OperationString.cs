using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_12_pag_30____Ex_02_03
{
    class OperationString
    {
        public char[] vogal= new char[5] {'a','e','i','o','u'};

        public string AbreviarNome(string nome)
        {
            string[] nomeDividido= nome.Split(' ');
            string nomeA= nomeDividido[0];

            for(int i=0; i< nomeDividido.Length; i++)
            {
                char[] nomeReDividido= nomeDividido[i].ToCharArray();
                if ((i != 0) && (i != nomeDividido.Length - 1))
                {
                    nomeA += " " + nomeReDividido[0]+".";
                }
            }

            return nomeA + " " + nomeDividido[nomeDividido.Length - 1];
        }

        public string Criptografar(string texto)
        {
            string textoCrip=texto.Replace("a","#");
            string textoCrip2= textoCrip.Replace("e","#");
            string textoCrip3= textoCrip2.Replace("i","#");
            string textoCrip4= textoCrip3.Replace("o","#");
            string textoCrip5= textoCrip4.Replace("u","#");

            //for (int i = 0; i < 5; i++)
            //{
            //    textoCrip=texto.Replace(vogal[i].ToString(), "#");
            //}

            return textoCrip5;
        }

        public string[] Virus(string texto)
        {
            string[] textos = texto.Split(' ');
            string[] textoV = new string [textos.Length*2];

            int c = 0;
            int j = 1;
            for(int i=0;i<textos.Length; i++)
            {
                
                textoV[c] = textos[i];
                textoV[j] = textos[i];

                c += 2;
                j += 2;
            }

            return textoV;
        }

    }
}
