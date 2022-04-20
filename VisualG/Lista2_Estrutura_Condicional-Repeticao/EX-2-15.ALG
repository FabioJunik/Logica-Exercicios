Algoritmo "Ex-2-15"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 08/07/2021
Var
   qs,qn,qms,qmn,i,qh:inteiro
   sexo,resp:caracter
   ph: real
Inicio
      para i<-1 ate 35 faca
           escreva("Sex: ")
           leia(sexo)
           escreva("Answer: ")
           leia(resp)
           se ((resp="s") ou (resp="sim"))entao
              qs<-qs+1
              se ((sexo="f") ou (sexo="femenino"))entao
                 qms<-qms+1
              fimse
           fimse
           se ((resp="n") ou (resp="não") ou(resp="nao"))entao
              qn<-qn+1
              se ((sexo="m") ou (sexo="masculino"))entao
                 qmn<-qmn+1
              fimse
           fimse
           se ((sexo="m") ou (sexo="masculino"))entao
                 qh<-qh+1
           fimse
      fimpara
      se (qh>0)entao
         ph<-qmn*100/qh
      fimse
      escreval("O número de pessoas que respondeu sim: ",qs)
      escreval("O número de pessoas que respondeu não: ",qn)
      escreval("O número de mulheres que respondeu sim: ",qms)
      escreval("A percentagem de homens que respondeu não entre todos os homensanalisados: ",qmn)
Fimalgoritmo