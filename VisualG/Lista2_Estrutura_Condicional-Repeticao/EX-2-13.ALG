Algoritmo "Ex-2-13"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   q,i:inteiro
   s,sum,med,maS,meS: real
   nome: caracter
Inicio
      escreva("What's the amount of employee: ")
      leia(q)
      para i<-1 ate q faca
           escreval("Employee ",i,": ")
           escreva("Name: ")
           leia(nome)
           escreva("Salary: ")
           leia(s)
           sum<-s+sum
           se (i=1)entao
              maS<-s
              meS<-s
           senao
                se (s>maS)entao
                   maS<-s
                fimse
                se (s<meS)entao
                   meS<-s
                fimse
           fimse
      fimpara
      escreval("Average of salarys is: ",sum/q)
      escreval("The bigger salary is: ",maS)
      escreval("The lowest salary is: ",meS)
Fimalgoritmo