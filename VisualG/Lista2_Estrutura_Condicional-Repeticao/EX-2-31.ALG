Algoritmo "Ex-2-31"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   n,f,i,c: inteiro
   s: real
Inicio
      escreva("Type a number: ")
      leia(n)
      para i<-1 ate n faca
           f<-1
           para c<-1 ate i faca
                f<-f*c
           fimpara
           s<-s+(1/f)
      fimpara
      escreva(s)
Fimalgoritmo