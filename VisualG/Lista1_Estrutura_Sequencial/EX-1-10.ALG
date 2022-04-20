Algoritmo "Ex-1-10"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   nc: inteiro
   vt,sf,vv,sfinal: real
Inicio
      escreva("Salário fixo: ")
      leia(sf)
      escreva("Número de carros vendidos: ")
      leia(nc)
      escreva("Valor total das vendas: ")
      leia(vt)
      escreva("Valor que recebido por carro vendido: ")
      leia(vv)
      sfinal<- sf+(vv*nc)+(vt*15/100)
      escreval("O seu salario final será: ",sfinal)

Fimalgoritmo