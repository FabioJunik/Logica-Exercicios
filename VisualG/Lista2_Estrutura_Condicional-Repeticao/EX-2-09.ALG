Algoritmo "Ex-2-09"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi
// Descrição   : Aqui você descreve o que o programa faz! (função)
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