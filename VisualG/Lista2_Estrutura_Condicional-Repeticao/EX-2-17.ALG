Algoritmo "Ex-2-17"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   n,q,i:inteiro
Inicio
      escreva("Type a number: ")
      leia(n)
      para i<-1 ate n faca
           se (n%i=0)entao
              q<-q+1
           fimse
      fimpara
      se (q=2)entao
         escreval("� primo")
      senao
           escreval("N�o � primo")
      fimse
Fimalgoritmo