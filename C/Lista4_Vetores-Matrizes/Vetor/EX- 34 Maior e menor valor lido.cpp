#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int x[10],ma,me;
	
	for(int c=0;c<10;c++)
	{
		printf("Informe o valor da posi��o[%d]:",c);
		scanf("%d",&x[c]);
	}
	
	ma=me=x[0];
	
	for(int c=0;c<10;c++)
	{
		if(ma<x[c])
			ma=x[c];
		if(x[c]<me)
			me=x[c];
	}	
	printf("O maior valor lido � %d\n",ma);
	printf("O menor valor lido � %d\n",me);	
}