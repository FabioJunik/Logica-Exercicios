#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int op,n1,n2;
	float d;

	printf("Digite dois n�meros:");
	scanf("%d%d",&n1,&n2);	

	
	do
	{	
	printf("Informe a op��o desejada:\n");
	printf("1-Adi��o\n");
	printf("2-Subrita��o\n");
	printf("3-Multipli��o\n");
	printf("4-Divis�o\n");
	printf("5-Sair\n");
	scanf("%d",&op);
		switch(op)
		{
			
			case 1:
				printf("A Soma de %d e %d � %d\n",n1,n2,n1+n2);
				break;
			case 2:
				printf("A Subtra��o de %d e %d � %d\n",n1,n2,n1-n2);
				break;			
			case 3:
				printf("A Multipli��o de %d e %d � %d\n",n1,n2,n1*n2);
				break;			
			case 4:
				d=n1/n2;
				printf("A Divis�o de %d e %d � %.2f\n",n1,n2,d);
				break;
			case 5:
				break;						
			default:
				printf("A op��o invalida/n");			
		}
	}
	while(op!=5);
	
} 