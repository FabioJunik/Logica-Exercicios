#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int x[10],y[10],m[20];
	
	printf("Primeiro vetor:\n");
	for(int c=0;c<10;c++)
	{
		printf("Informe o valor da posição[%d]:",c);
		scanf("%d",&x[c]);
	}
	
	printf("Segundo Vetor:\n");
	for(int c=0;c<10;c++)
	{
		printf("Informe o valor da posição[%d]:",c);
		scanf("%d",&y[c]);
	}
	
	
	for(int c=0,k=0;c<20;c=c+2,k++)
			m[c]=x[k];

		for(int c=1,k=0;c<20;c=c+2,k++)
			m[c]=y[k];
	for(int k=0;k<20;k++)
		printf("[%d]\n",m[k]);
	
}