#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	char palavra[20];
	int tamanho(char palavra[]);
	
	printf("Digite uma palavra:");
	scanf("%s",&palavra);
	
	printf("A palavra %s tem %d letras\n",palavra,tamanho(palavra));
}
int	tamanho(char palavra[])
{
	int c=0;
	while(palavra[c]!='\0')
		c++;
	return c;
}