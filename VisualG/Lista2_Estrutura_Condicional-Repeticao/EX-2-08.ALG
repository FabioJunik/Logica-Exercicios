Algoritmo "Ex-2-08"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   n,i,c: inteiro
   h: real
Inicio
      repita
            escreva("Type a number: ")
            leia(n)
      ate(n>0)
      para i<-1 ate n faca
           h<-h+(1/i)
      fimpara
      escreva(h)
Fimalgoritmo