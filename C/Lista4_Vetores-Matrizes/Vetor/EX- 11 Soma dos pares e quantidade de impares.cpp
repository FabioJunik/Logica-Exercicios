#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int w[6],s=0,q=0; 
	
	
	for(int y=0;y<=6;y++)
	{
		printf("Informe o valor da posicao[%d]:",y);
		scanf("%d",&w[y]);
	}
	
	
	printf("Os Valores impares sao :\n");
	for(int y=0;y<7;y++)
	{
		if(w[y]%2==1)
		{
			printf("%d\n",w[y]);
			q++;
		}	
	}
	printf("A quantidades de numeros impares digitados eh %d \n",q);
	
	printf("Os Valores pares sao :\n");
	for(int y=0;y <7;y++)
	{
		if(w[y]%2==0)
		{
			printf("%d\n",w[y]);
			s=s+w[y];
		}	
	}
	printf("A soma de todos numero pares eh %d\n",s);	
	
	return 0;
}