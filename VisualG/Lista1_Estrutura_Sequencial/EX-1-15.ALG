Algoritmo "Ex-1-15"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
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