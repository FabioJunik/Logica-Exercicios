Algoritmo "Ex-2-07"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   i,q,c: inteiro
   n,med,s:real
   nome:caracter
Inicio
      escreva("How many students: ")
      leia(q)
      para i<-1 ate q faca
           escreva("Name: ")
           leia(nome)
           para c<-1 ate 6 faca
                escreva("Note ",c,": ")
                leia(n)
                s<-s+n
           fimpara
           med<-s/6
           s<-0
           limpatela
           se (med >6)entao
              escreval(nome,"---",med,"---Aprovado")
           senao
                se ((med>4)e (med<7))entao
                   escreval(nome,"---",med,"---Recupera��o")
                senao
                     escreval(nome,"---",med,"---Reprovado")
                fimse
           fimse

      fimpara
Fimalgoritmo