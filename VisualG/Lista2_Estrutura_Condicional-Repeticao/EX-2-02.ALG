Algoritmo "Ex-2-02"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   q1,q2,i,n: inteiro
Inicio
      para i<-1 ate 200 faca
           escreva("Enter a number: ")
           leia(n)
           se (n%2=0)entao
              q1<-q2+1
           senao
                q2<-q2+1
           fimse
      fimpara
      escreval("Amount of pier: ",q1)
      escreval("Odd amount: ",q2)
Fimalgoritmo