Algoritmo "Ex-1-16"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   a,c,b: real
Inicio
      escreva("Inform the sides of the triangle")
      leia(a,b,c)
      se (a=b) e (b=c)entao
         escreva("Equilatero")
      senao
           se (a<>b) e (b<>c) e (a<>c)entao
              escreva("Escaleno")
           senao
                escreva("Isoscele")
           fimse
      fimse
Fimalgoritmo