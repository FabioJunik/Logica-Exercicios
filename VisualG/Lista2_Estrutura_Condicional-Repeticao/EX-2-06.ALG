Algoritmo "Ex-2-06"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   n,s,med:real
   i,q:inteiro
Inicio
      para i<-1 ate 20 faca
           escreva("Type a numer: ")
           leia(n)
           se (n>0)entao
              escreval(n)
           senao
                q<-q+1
                s<-s+n
           fimse
      fimpara
      med<-s/q
      escreva("Average of number < 0 is: ",med)
Fimalgoritmo