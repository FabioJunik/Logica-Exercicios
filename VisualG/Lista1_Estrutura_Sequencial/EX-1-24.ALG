Algoritmo "Ex-1-24"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
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
      
      escreval("Biggest: ",a)
Fimalgoritmo