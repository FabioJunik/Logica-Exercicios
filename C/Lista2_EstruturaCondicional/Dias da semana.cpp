#include <stdio.h>
#include <stdlib.h>

main()

{
	int dia;
	
	printf("Intorme um numero:");
	scanf("%d",&dia);
	printf("O numero corresponde a: ");
	switch (dia)
	{
		case 2:
			printf("Segunda");
		break;
		case 3:
			printf("Terca\n");
		break;
		case 4:
			printf("Quarta\n");
		break;
		case 5:
			printf("Quinta\n");
		break;
		case 6:
			printf("Sexta\n");
		break;
		case 7:
			printf("Sabado\n");
		break;
		case 1:
			printf("Domingo\n");
		break;
		default:
			printf("NUMERO INVALIDO\n");
	}																																																	
}
