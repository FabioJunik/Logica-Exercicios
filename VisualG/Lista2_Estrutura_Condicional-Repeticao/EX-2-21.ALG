Algoritmo "Ex-2-21"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
 n1,n2,i:inteiro
Inicio
      escreva("Digite o primeiro valor: ")
      leia(n1)
      escreva("Digite o segundo valor: ")
      leia(n2)
      se (n1 > n2) entao
         para i<-n1 ate n2 passo -1 faca
           escreval(i)
         fimpara
      senao
           para i<-n1 ate n2 faca
                escreval(i)
           fimpara
      fimse
Fimalgoritmo