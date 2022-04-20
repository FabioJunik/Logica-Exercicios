Algoritmo "Ex-2-20"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   med,n,s: real
   i,c,m: inteiro
Inicio
      para i<-1 ate 15 faca
           escreval("Aluno ",i)
           para c<-1 ate 4 faca
                escreva("Nota ",c,":")
                leia(n)
                s<-s+n
           fimpara
           med<-s/4
           s<-0
           escreval("Média: ",med)
           leia(m)
           limpatela
      fimpara
Fimalgoritmo