Algoritmo "Ex-2-14"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   idade,i,qi,qp,qh: inteiro
   h,peso,sh,pp,med:real
Inicio
      para i<-1 ate 37 faca
           escreval("Person ",i,": ")
           escreva("Age: ")
           leia(idade)
           escreva("Height: ")
           leia(h)
           escreva("Weight: ")
           leia(peso)

           se (idade > 50)entao
              qi<-qi+1
           fimse
           se ((idade >9)e(idade<21))entao
              qh<-qh+1
              sh<-sh+h
           fimse
           se (peso < 40)entao
              qp<-qp+1
           fimse
      fimpara
      med<-sh/qh
      pp<-qp*100/37
      escreval("Quantidade de pessoas com idade superior a 50 anos: ",qi)
      escreval("Média das alturas das pessoas com idade entre 10 e 20: ",med)
      escreval("Percentagem de pessoas com peso inferior a 40 Kg: ",pp,"%")

Fimalgoritmo