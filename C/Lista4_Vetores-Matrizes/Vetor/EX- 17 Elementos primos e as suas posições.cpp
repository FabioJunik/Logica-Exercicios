#include <stdio.h>
#include <locale.h>

main()
{
	int j[10],q=0;
	
	setlocale(LC_ALL,"portuguese");
	
	for(int g=0;g<10;g++)
	{
		printf("Informe o valor da posição[%d]:",g);
		scanf("%d",&j[g]);
	}
	
	printf("\n");
	for(int g=0;g<10;g++)
	{
		for(int r=1;r<=j[g];r++)
		{
			if(j[g]%r==0)
				q++;
		}
		if(q==2)
			printf("O valor %d é primo e encontra-se na posição %d\n",j[g],g);
		q=0;
	}
}