#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	char p1[10],p2[10];
	int verificar(char p1[],char p2[]);
	
	printf("Digite a primeira palavra:");
	scanf("%s",&p1);
	printf("Digite a segunga palavra:");
	scanf("%s",&p2);
	
	if(verificar(p1,p2)==1)
		printf("AS palavras são iguais\n");
	else
		printf("As palavras são diferentes\n");
	
	return 0;
}

int  verificar(char p1[],char p2[])
{
	int k=0;
	
	while(p1[k]!='\0' && p2[k]!='\0' && p1[k]==p2[k] )
		k++;
	
	if(p1[k]=='\0' && p2[k]=='\0')
		return 1;
	else
		return 0;
}