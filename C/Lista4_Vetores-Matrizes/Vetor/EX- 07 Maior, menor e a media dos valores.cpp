#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int g[5],ma,me,s=0;
	float med;
	
	for(int w=0;w <5; w++)
	{
		printf("Informe o valor da posicao {%d}:",w);
		scanf("%d",&g[w]);
	}
	ma=me=g[0];
	for(int w=0;w<5;w++)
	{
		if(g[w]>ma)
			ma=g[w];
		if(g[w]<me)
			me=g[w];
		s=s+g[w];
	}
	
	med=s/5;
	printf("%d",s);
	printf("A media dos valores digitados eh %.2f\n",med);
	printf("O maior numero digitado eh %d\n",ma);
	printf("O menor valor digitado eh %d\n",me);
	return 0;
}