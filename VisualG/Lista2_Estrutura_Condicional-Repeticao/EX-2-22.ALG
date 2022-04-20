Algoritmo "Ex-2-22"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   op: inteiro
   n1,n2,r:real
   resp: caracter
Inicio

      repita
      escreval("(1)-Sum")
      escreval("(2)-Subtraction")
      escreval("(3)-Multiplication")
      escreval("(4)-Division")
            escreva("Enter the first number: ")
            leia(n1)
            escreva("Enter the second number: ")
            leia(n2)
            escreva("Report the operation")
            leia(op)
            escolha (op)
                    caso 1
                         r<-n1+n2
                    caso 2
                         r<-n1-n2
                    caso 3
                         r<-n1*n2
                    caso 4
                         r<-n1/n2
                    outrocaso
                             escreval("Invalid operation! Try agein.")
            fimescolha
            escreval("Result: ",r)
            escreval("Want to do another calculation? (s/n)")
            leia(resp)
            r<-0
            limpaTela
      ate(resp="n")
Fimalgoritmo