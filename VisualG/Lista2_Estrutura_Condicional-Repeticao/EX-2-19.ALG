Algoritmo "Ex-2-19"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   n,i,sp,si,qh: inteiro
   med: real
   resp: caracter
Inicio
      repita
           escreva("Type a number: ")
           leia(n)
           se (n>0)entao
              sp<-sp+n
           senao
                si<-si+n
                qh<-qh+1
           fimse
           escreva("Deseja continuar(s/n): ")
           leia(resp)
      ate(resp = "n")
      se (ph>0)
          med<-si/qh
      fimse
      escreval("A soma dos valores positivos: ",sp)
      escreval("M�dia dos negativos: ",med)
Fimalgoritmo