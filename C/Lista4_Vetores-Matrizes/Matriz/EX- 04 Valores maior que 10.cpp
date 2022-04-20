#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int m[4][4],q=0;
	
	for(int c=0;c<4;c++)
	{
		for(int k=0;k<4;k++)
		{
			printf("Informe o valor da posição[%d-%d]:",c,k);
			scanf("%d",&m[c][k]);
		}
	}
	
	for(int c=0;c<4;c++)
	{
		for(int k=0;k<4;k++)
		{
			if(m[c][k]>10)
				q++;
		}
	}
	
	printf("Existem %d valores maiores que 10\n",q);
}