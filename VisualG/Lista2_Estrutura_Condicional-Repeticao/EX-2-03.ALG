Algoritmo "Ex-2-03"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   n1,n2:inteiro
   d:real
Inicio
      escreva("Type the first value")
      leia(n1)
      repita
            escreva("Type the second value")
            leia(n2)
      ate(n2<>0)
      d<-n1/n2
      escreva(n1,"/",n2,"= ",d)
Fimalgoritmo