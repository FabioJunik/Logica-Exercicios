Algoritmo "Ex-2-09"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   n,f,i: inteiro
Inicio
      f<-1
      repita
            escreva("Type a number: ")
            leia(n)
      ate(n>0)
      para i<-1 ate n faca
           f<-f*i
      fimpara
      escreva(f)
Fimalgoritmo