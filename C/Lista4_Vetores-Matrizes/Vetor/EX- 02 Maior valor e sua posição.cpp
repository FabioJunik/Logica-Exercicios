#include <stdio.h>
#include <stdlib.h>

int main()
{
	int v[10],m,p;
	
 	
	for(int i=0; i<10; i++)
	{
		printf("Informe o valor da posicao[%d]:",i);
		scanf("%d",&v[i]);
	}
	
	m= v[0];
	for(int i=0;i<10;i++)
	{
		if(v[i]>m)
		{
			m=v[i];
			p=i;
		}
	}
	printf("O maior valor eh %d e encontra-se na posicao %d",m,p);
}