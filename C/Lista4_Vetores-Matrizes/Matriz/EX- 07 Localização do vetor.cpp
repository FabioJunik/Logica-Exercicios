#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int m[5][5],co=0,x;
	
	for(int c=0;c<5;c++)
	{
		for(int k=0;k<5;k++)
		{
			printf("Informe o valor da posi��o[%d-%d]:",c,k);
			scanf("%d",&m[c][k]);
		}
	}

	printf("Digite um n�mero:");
	scanf("%d",&x);
	for(int c=0;c<5;c++)
	{
		for(int k=0;k<5;k++)
		{
			if(m[c][k]==x)
			{
				printf("Valor encontrado a posi��o [%d-%d]",c,k);
				co=1;
			}
		}
	}
	if(co==0)
		printf("Valor n�o encontrado\n");
	
}