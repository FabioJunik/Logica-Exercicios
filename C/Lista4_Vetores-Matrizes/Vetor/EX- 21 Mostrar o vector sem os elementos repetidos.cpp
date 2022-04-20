#include <stdio.h>
#include <locale.h>

main()
{
	int z[20];
	
	setlocale(LC_ALL,"portuguese");
	
	for(int c=0;c<20;c++)
	{
		printf("Informe o valor da posição[%d]:",c);
		scanf("%d",&z[c]);
	}
	
	for(int c=0;c<20;c++)
	{
		for(int k=c+1;k<20;k++)
		{
			if(z[c]==z[k])
				z[k]=0;
		}
		if(z[c]!=0)
			printf("%d\n",z[c]);
		
	}
}