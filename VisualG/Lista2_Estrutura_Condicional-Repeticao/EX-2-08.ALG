Algoritmo "Ex-2-08"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi
// Descrição   : Aqui você descreve o que o programa faz! (função)
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