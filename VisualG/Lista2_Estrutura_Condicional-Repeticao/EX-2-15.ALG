Algoritmo "Ex-2-15"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
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
           se ((resp="n") ou (resp="n�o") ou(resp="nao"))entao
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
      escreval("O n�mero de pessoas que respondeu sim: ",qs)
      escreval("O n�mero de pessoas que respondeu n�o: ",qn)
      escreval("O n�mero de mulheres que respondeu sim: ",qms)
      escreval("A percentagem de homens que respondeu n�o entre todos os homensanalisados: ",qmn)
Fimalgoritmo