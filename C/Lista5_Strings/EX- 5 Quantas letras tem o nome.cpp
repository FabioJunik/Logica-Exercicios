#include <stdio.h>


int main(int argc, char** argv)
{
	int k=0;
	char nome[10];
	
	printf("Type the name:");
	scanf("%s",&nome);
	
	while(nome[k]!='\0')
		k++;
	
	printf("The word have %d letter",k);
	return 0;
}