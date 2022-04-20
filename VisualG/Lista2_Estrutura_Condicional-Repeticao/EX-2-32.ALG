Algoritmo "Ex-2-32"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   i,s,n:inteiro
Inicio
      escreva("Inform the number: ")
      leia(n)
      para i<-1 ate n-1 faca
           se (n%i=0)entao
              s<-s+i
           fimse
      fimpara
      se (s=n)entao
         escreva("The number is perfect")
      fimse
Fimalgoritmo