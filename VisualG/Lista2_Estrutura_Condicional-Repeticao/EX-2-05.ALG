Algoritmo "Ex-2-05"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   m7,m9,q,i:inteiro
   n,s:real
Inicio
      escreva("How many number for sum? ")
      leia(q)
      para i<-1 ate q faca
           escreva("Number ",i,": ")
           leia(n)
           s<-s+n
           se (n>7)entao
              m7<-m7+1
           fimse
           se (n>9)entao
              m9<-m9+1
           fimse
      fimpara
      escreval("Sum: ",s)
      escreval("Number greater than 7: ",m7)
      escreval("Number greater than 9: ",m9)
Fimalgoritmo