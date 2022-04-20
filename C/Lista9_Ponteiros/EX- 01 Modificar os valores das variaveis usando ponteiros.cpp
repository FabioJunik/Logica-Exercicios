#include <stdio.h>


int main(int argc, char** argv)
{
	int idade;
	char nome;
	float altura;
	
	int *pi;
	char *pn;
	float *pa;
	
	pi=&idade;
	pn=&nome;
	pa=&altura;
	
	printf("What's your first name:");
	scanf("%c",&nome);
	
	printf("How old are you:");
	scanf("%i",&idade);
	
	printf("what's your height(cm):");
	scanf("%f",&altura);

	printf("-----------------------\n");
	printf("The %c with %i years old and %.2f height \n",nome,idade,altura);		
	
	*pi=*pi+1;
	*pn='M';
	*pa=*pa+0,50;  
	
	printf("-----------------------\n");
	printf("The %c are %i years old and %.2f height now\n",nome,idade,altura);
	return 0;
}