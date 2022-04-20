#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	
	int i,j,p;
	
	printf("Informa o tamanho do vetor N:");
	scanf("%d",&i);
	printf("Informa o tamanho do vetor M:");
	scanf("%d",&j);
	
	p=i+j;
	
	int n[i],m[j],t=0,l[p];
	printf("Preenchendo o Vetor N\n");
	for(int c=0;c<i;c++)
	{
		printf("Informe o valor do posição{%d}:",c);
		scanf("%d",&n[c]);
	}
	
	printf("Preenchendo o Vetor M\n");
	for(int c=0;c<j;c++)
	{
		printf("Informe o valor do posição{%d}:",c);
		scanf("%d",&m[c]);
	}	
	
	for(int c=0;c<i;c++,t++)
		l[t]=n[c];

	for(int c=0;c<j;c++,t++)
		l[t]=m[c];		
	
	
	for(int c=0;c<t;c++)
		printf("posição [%d] =%d\n",c,l[c]);	
	
}