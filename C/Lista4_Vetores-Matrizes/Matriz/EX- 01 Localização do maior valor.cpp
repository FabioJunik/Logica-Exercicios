#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int m[4][4],l,co,ma;
	
	for(int c=0;c<4;c++)
	{
		for(int k=0;k<4;k++)
		{
			printf("Informe o valor da posição[%d-%d]:",c,k);
			scanf("%d",&m[c][k]);
		}
	}
	ma=m[0][0];
	for(int c=0;c<4;c++)
	{
		for(int k=0;k<4;k++)
		{
			if(m[c][k]>ma)
			{
				ma=m[c][k];
				l=c;
				co=k;
			}
			
			printf("%d    ",m[c][k]);
		}
		printf("\n");
	}
	
	printf("O maior valor é %d e encontrasse na posição %d-%d\n",ma,l,co);
}