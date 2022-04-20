Algoritmo "Ex-2-26"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   i:inteiro
   p,maior,med,s:real
Inicio
      para i<-1 ate 15 faca
           escreva("Enter the price ",i,": ")
           leia(p)
           se (i=0)entao
              maior<-p
           senao
                se (p>maior)entao
                   maior<-p
                fimse
           fimse
           s<-s+p
      fimpara
      med<-s/15
      escreval("The bigger price is: ",maior)
      escreval("The arithmetic average of product prices is: ",med)
      
Fimalgoritmo