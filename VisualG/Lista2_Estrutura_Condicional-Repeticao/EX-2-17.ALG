Algoritmo "Ex-2-17"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
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
         escreval("É primo")
      senao
           escreval("Não é primo")
      fimse
Fimalgoritmo