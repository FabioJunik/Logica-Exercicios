Algoritmo "Ex-1-10"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   nc: inteiro
   vt,sf,vv,sfinal: real
Inicio
      escreva("Sal�rio fixo: ")
      leia(sf)
      escreva("N�mero de carros vendidos: ")
      leia(nc)
      escreva("Valor total das vendas: ")
      leia(vt)
      escreva("Valor que recebido por carro vendido: ")
      leia(vv)
      sfinal<- sf+(vv*nc)+(vt*15/100)
      escreval("O seu salario final ser�: ",sfinal)

Fimalgoritmo