Algoritmo "Ex-1-25"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
 a,b,c,aux: real

Inicio
      escreva("Type the first number: ")
      leia(a)
      escreva("Type the second number: ")
      leia(b)
      escreva("Type the third number: ")
      leia(c)

      se (a<b)entao
         aux<-a
         a<-b
         b<-aux
      fimse
      se (a<c)entao
         aux<-a
         a<-c
         c<-aux
      fimse
      se (b>c)entao
         aux<-c
         c<-b
         b<-aux
      fimse

      escreval(a+c)
Fimalgoritmo