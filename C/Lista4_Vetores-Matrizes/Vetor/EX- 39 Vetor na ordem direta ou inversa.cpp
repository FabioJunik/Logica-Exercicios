#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int code,f[5];
	
	printf("Preenchendo o vetor:\n");
	for(int k=0;k<5;k++)
	{
		printf("Informe o valor da posição[%d]:",k);
		scanf("%d",&f[k]);
	}
	
	printf("Escolha um codigo:\n");
	printf("0-Para terminar\n1- para mostra o vetor na ordem direta\n2- para mostra o vetor na ordem inversa\n");
	do
	{	
		scanf("%d",&code);
		printf("\n");
		switch(code)
		{
			case 0:
				break;
			case 1:
				for(int k=0;k<5;k++)
					printf("[%d]",f[k]);
				break;
			case 2:
				for(int k=4;k>=0;k--)
					printf("[%d]",f[k]);
				break;
			default:
				printf("Codigo invalido\n");
		}
	}
	while(code!=0);
}