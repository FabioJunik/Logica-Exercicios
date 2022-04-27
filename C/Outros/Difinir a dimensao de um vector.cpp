#include <stdio.h>
#include <stdlib.h>

int main()
{
	int p;
	
	printf("Informe a dimensao do vetor:");
	scanf("%d",&p);
	
	int v[p];
	
	for(int k=0;k <p;k++)
	{
		v[k]=k;
		printf("%d\n",v[k]);
	}
}