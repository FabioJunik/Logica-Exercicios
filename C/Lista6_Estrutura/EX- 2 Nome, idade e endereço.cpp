#include <stdio.h>

int main(int argc, char** argv)
{
	struct estrutura
	{
		char nome[10];
		int idade;
		char end[10];
	};
	
	struct estrutura ind;
	
	printf("What's your name, age and address:");
	scanf("%s%d%s",&ind.nome,&ind.idade,&ind.end);
	
	
	printf("%s\n%d\n%s\n",ind.nome,ind.idade,ind.end);
	return 0;
}