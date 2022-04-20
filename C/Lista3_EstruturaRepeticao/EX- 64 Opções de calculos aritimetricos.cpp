#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int op,n1,n2;
	float d;

	printf("Digite dois números:");
	scanf("%d%d",&n1,&n2);	

	
	do
	{	
	printf("Informe a opção desejada:\n");
	printf("1-Adição\n");
	printf("2-Subritação\n");
	printf("3-Multiplição\n");
	printf("4-Divisão\n");
	printf("5-Sair\n");
	scanf("%d",&op);
		switch(op)
		{
			
			case 1:
				printf("A Soma de %d e %d é %d\n",n1,n2,n1+n2);
				break;
			case 2:
				printf("A Subtração de %d e %d é %d\n",n1,n2,n1-n2);
				break;			
			case 3:
				printf("A Multiplição de %d e %d é %d\n",n1,n2,n1*n2);
				break;			
			case 4:
				d=n1/n2;
				printf("A Divisão de %d e %d é %.2f\n",n1,n2,d);
				break;
			case 5:
				break;						
			default:
				printf("A opção invalida/n");			
		}
	}
	while(op!=5);
	
} 