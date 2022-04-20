#include <stdio.h>


int main(int argc, char** argv)
{
	char nome[10];
	
	printf("Type the name:");
	scanf("%s",&nome);
	
	printf("The first four letter of name is: ");
	for(int i=0;i<4;i++)
		printf("%c",nome[i]);
	
	printf("\n");
	return 0;
}