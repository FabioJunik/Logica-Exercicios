#include <stdio.h>
#include <locale.h>

main()
{
	int v[10],v1[10],v2[10];
	
	setlocale(LC_ALL,"portuguese");
	
	printf("Preenchendo o vetor V\n");
	printf("---------------------\n");
	
	for(int y=0;y<10;y++)
	{
		printf("Informe o valor da posição[%d]:",y);
		scanf("%d",&v[y]);
		
		if(v[y]%2==0)
		{
			v2[y]=v[y];
			v1[y]=0;
		}
		else
		{
			v1[y]=v[y];
			v2[y]=0;
		}
	}
	
	printf("\nOs Valores do vetor V1 são:");
	for(int y=0;y<10;y++)
	{
		if(v1[y]!=0)
			printf("%d:",v1[y]);
	}
	
	printf("\nOs Valores do vetor V2 são:");
	for(int y=0;y<10;y++)
	{
		if(v2[y]!=0)
			printf("%d:",v2[y]);
	}
}