Algoritmo "Ex-2-04"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   nome,cor:caracter
   a,i:inteiro
Inicio
      para i<-1 ate 10 faca
           escreva("Name: ")
           leia(nome)
           escreva("Color: ")
           leia(cor)
           se ((cor="azul") ou (cor="Azul"))entao
              a<-a+1
           fimse
           limpatela
      fimpara
      escreva("Blue cars: ",a)
Fimalgoritmo