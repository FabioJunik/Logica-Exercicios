Algoritmo "Ex-2-10"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   q,i: inteiro
   n,s,s2,med: real
Inicio
      para i<-1 ate 20 faca
           escreva("Enter a number: ")
           leia(n)
           se (n>0)entao
              s<-s+n
           senao
                s2<-s2+n
                q<-q+1
           fimse
      fimpara
      escreval("Sum of positive values: ",s)
      med<-s2/q
      escreval("Average of negative values: ",med)
Fimalgoritmo