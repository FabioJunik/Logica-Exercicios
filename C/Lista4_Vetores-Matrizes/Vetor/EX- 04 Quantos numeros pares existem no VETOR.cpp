#include <stdio.h>
#include <stdlib.h>

int main()
{
	int t[10],q=0;
	
	for(int k=0;k<10;k++)
	{
		printf("Informe o valor da posicao[%d]",k);
		scanf("%d",&t[k]);
		
		if(t[k]%2==0)
			q++;
	}
	
	printf("\nOs vetor tem %d numeros pares\n",q);
}