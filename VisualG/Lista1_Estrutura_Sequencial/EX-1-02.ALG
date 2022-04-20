Algoritmo "Ex-1-02"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 05/07/2021
Var
   month, day, pastday: inteiro
Inicio
      escreva("What's a month: ")
      leia(month)
      escreva("What's a day: ")
      leia(day)
      
      pastDay<- ((month*30)+day)-30
      escreva("Já se passanram ",pastday," dias desde o incio do ano")
Fimalgoritmo