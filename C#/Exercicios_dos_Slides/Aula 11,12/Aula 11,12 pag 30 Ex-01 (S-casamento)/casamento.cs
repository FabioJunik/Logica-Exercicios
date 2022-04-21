using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_12_pag_30_Ex_01__S_casamento_
{
    class OperationString
    {
        public string Casamento(string marido, string mulher)
        {
            marido.Trim();
            mulher.Trim();

            char espaco = ' ';
            int pos = marido.LastIndexOf(espaco);
            string subMarido = marido.Substring(pos+1);

            string novoNome= mulher+" "+subMarido;

            return novoNome;
        } 
    }
}
