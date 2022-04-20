Algoritmo "Ex-2-11"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   i,q1,q2,q3,cd,q4: inteiro
Inicio
      para i<-1 ate 10 faca
           escreval("(1)Pan")
           escreval("(2)kettle")
           escreval("(3)Dish")
           escreva("Choose the code: ")
           leia(cd)
           escolha(cd)
                caso 1
                     q1<-q1+1
                caso 2
                     q2<-q2+1
                caso 3
                     q3<-q3+1
                outrocaso
                     escreval("Codigo invalido")
                     q4<-q4+1
           fimescolha
      fimpara
      escreval("Amount of code 1: ",q1)
      escreval("Amount of code 2: ",q2)
      escreval("Amount of code 3: ",q3)
      escreval("Amount of invalid code: ",q4)
Fimalgoritmo