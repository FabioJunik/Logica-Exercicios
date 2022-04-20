#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int l=0,c=0,o[l][c];
	
	printf("Informe a quantidade de linha e coluna :");
	scanf("%d%d",&l,&c);
	

	printf("Matriz gerada\n");
	for(int j=0;j<l;j++)
	{
		for(int k=0;k<c;k++)
		{	
			o[j][k]=j*k;
			printf("%d    ",o[j][k]);
		}
		printf("\n");
	}
	

}