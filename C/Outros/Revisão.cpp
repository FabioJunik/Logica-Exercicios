# include<stdio.h>;
#include<stdlib.h>;

main(){
	int n1,n2;
	char res;
	printf("Hello wold !\n");
	printf("Vamos somar dois numeros. \nPrimeiro numero: ");
	scanf("%d",&n1);
	printf("Segundo numero: ");
	scanf("%d",&n2);	
	printf("A soma dos numeros eh: %d\n",n1+n2);
	system("pause");
	system("cls");
	
	printf("Vamos contar de 0 a 10? ");
	system("pause");
	for(int c=0;c<=10;c++){
		printf("%d\n",c);
	}
	system("pause");
	system("cls");
	
	printf("Agora so os numeros pares?");
	system("pause");
	int c=0;	
	while(c<11){
		printf("%d\n",c);
		c+=2;
	}
	system("pause");
	system("cls");
	
	printf("Agora os impares? ");
	system("pause");
	c=1;
	do{
		printf("%d\n",c);
		c+=2;
	}while(c<10);
	system("pause");
	system("cls");
	
	
	printf("TESTE DE MEMORIA:\n");
	printf("Qual foi a resultado da soma dos dois números anteriores ?\n");
	int r;
	scanf("%d",&r);
	if(r== (n1+n2))
		printf("PARBENS!!!!!\nResposta certa!\n");
	else
		printf("Resposta Incorreta!");
	system("pause");
	system("cls");
	
	printf("Entre o primeiro e o segundo numero qual era o maior?\n ");
	printf("----------OPCOS---------\n");
	printf("A)- O primeiro numero\n");
	printf("B)- O segundo numero\n");
	printf("C)- Eram iguis\n");
	scanf("%c",&res);
	
	if((n1>n2 )&&( res=='A'||res=='a'))
		printf("ACERTOUUUUU\n");
	else if((n2>n1) && (res=='b'||res=='B'))
		printf("ACERTOUUUU\n");
	else if((n1==n2 )&& (res=='c'||res=='C'))
		printf("ACERTOUUUU\n\n");
	else
		printf("Opcao incoreecta\n");
	
	system("pause");
	system("cls");
	
}