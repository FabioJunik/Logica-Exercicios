Algoritmo "Ex-2-30"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
  n,q,i: inteiro
  p1,p2,p3,s1,s2,s3:real
Inicio
      escreva("Quantidade de aluno: ")
      leia(n)
      para i<-1 ate n faca
           escreva("Aluno ",i,": ")
           leia(q)
           se (q <10)entao
              s1<-s1+1
           senao
                se ((q>9) e (q<16))entao
                   s2<-s2+1
                senao
                     s3<-s3+1
                fimse
           fimse
      fimpara
      p1<-s1*100/n
      p2<-s2*100/n
      p3<-s3*100/n
      escreval("Percentagem de alunos que utilizaram menos que 10 vezes o refeitório: ",p1)
      escreval("Percentagem de alunos que utilizaram entre 10 e 15 vezes: ",p2)
      escreval("A percentagem de alunos que utilizaram o restaurante acima de 15 vezes: ",p3)
Fimalgoritmo