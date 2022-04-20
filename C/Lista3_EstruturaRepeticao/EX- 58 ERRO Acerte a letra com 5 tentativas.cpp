#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	int n,k=0;
	char l_u,l_a;
	
	
	n = rand()%25;	
	l_a= 'a'+n;
	
	do
	{
		k++;
		printf("Digita uma letra");
		scanf("%c",&l_u);
	 
	    if(l_u==l_a)
	    	printf("Parabens voçê acertou \n");
		else if(k==5)
			printf("A palavra digitada foi %c\n",l_a);
	}
	while(l_u!=l_a || k!=5);
	return 0;
}