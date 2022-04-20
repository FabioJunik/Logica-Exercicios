Algoritmo "Ex-1-20"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/07/2021
Var
   sexo, nome: caracter
   idade: inteiro
Inicio
      escreva("Name: ")
      leia(nome)
      escreva("Sex: ")
      leia(sexo)
      escreva("Age: ")
      leia(idade)
      se (((sexo="f") ou (sexo="femenino")) e (idade<25))entao
         escreva(nome," aceita")
      senao
           escreva("Não aceita")
      fimse
Fimalgoritmo