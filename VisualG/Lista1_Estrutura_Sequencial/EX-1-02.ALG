Algoritmo "Ex-1-02"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
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
      escreva("J� se passanram ",pastday," dias desde o incio do ano")
Fimalgoritmo