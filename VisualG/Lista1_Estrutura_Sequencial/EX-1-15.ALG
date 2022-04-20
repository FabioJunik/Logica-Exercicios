Algoritmo "Ex-1-15"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/07/2021
Var
   n,maior: real
   i: inteiro
Inicio
      maior<-0
      para i <- 1 ate 5 faca
           escreva("Type the Note: ")
           leia(n)
           se (n>maior)entao
              maior<-n
           fimse
      fimpara
      escreva("The bigger note is ",maior)
Fimalgoritmo