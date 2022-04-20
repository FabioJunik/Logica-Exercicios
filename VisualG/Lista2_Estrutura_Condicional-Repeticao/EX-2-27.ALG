Algoritmo "Ex-2-27"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   nome: caracter
   preco,vt: real
   quantidade: inteiro
Inicio
      escreva("Produt name: ")
      leia(nome)
      escreva("Price: ")
      leia(preco)
      escreva("Amount: ")
      leia(quantidade)
      se (quantidade<11)entao
         vt<-preco
      senao
           se ((quantidade>10) e (quantidade<21))entao
              vt<- preco -(preco*10/100)
           senao
                se ((quantidade>20) e (quantidade<51))entao
                    vt<- preco -(preco*20/100)
                senao
                     vt<- preco -(preco*25/100)
                fimse
           fimse
      fimse
      escreva("Total amount to be paid is: ",vt)
Fimalgoritmo