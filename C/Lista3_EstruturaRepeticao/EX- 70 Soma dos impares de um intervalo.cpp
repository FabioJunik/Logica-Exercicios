#include <stdio.h>
#include <stdlib.h>

int main()
{
	int i,j,s=0;
	
	
	printf("Informe o intervalo :\n");
	scanf("%d%d",&i,&j);
	
	if(i<j)
	{
		for(;i<=j;i++)
		{
			if(i%2==1)
				s=s+i;
		}
	 }
	else
		printf("ERRO intervalo invalido\n");
	
	printf("A soma dos valores impares deste intervalo e %d\n",s);
}