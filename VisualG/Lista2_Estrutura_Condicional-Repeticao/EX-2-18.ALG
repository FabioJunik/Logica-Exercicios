Algoritmo "Ex-2-18"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   n,i,sp,si,qh: inteiro
   med: real
Inicio
      para i<- 1 ate 100 faca
           escreva("Type a number: ")
           leia(n)
           se (n>0)entao
              sp<-sp+n
           senao
                si<-si+n
                qh<-qh+1
           fimse
      fimpara
      med<-si/qh
      escreval("A soma dos valores positivos: ",sp)
      escreval("M�dia dos negativos: ",med)
Fimalgoritmo