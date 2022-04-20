#include <stdio.h>


int main(int argc, char** argv)
{
	char nome[10];
	
	printf("Type the name:");
	scanf("%s",&nome);
	
	if(nome[0]=='a'||nome[0]=='A')
		printf("\nThe name %s bigin whith 'a'\n",nome);
	else 
		printf("\nThe name don't bigin whith 'a'\n");
	return 0;
}