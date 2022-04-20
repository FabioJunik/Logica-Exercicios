#include <stdio.h>
#include <stdlib.h>

int main()
{
	float v;
	char d;
	
	printf("Destinatarios :\n MG---7% \n SP---12%\n RJ---15%\n ");
	
	printf("Informe o valor inicial do produto: \n");
	scanf("%f",&v);
	printf("Qual e o destinatario: \n");
	scanf("%c",&d);
	
	switch(d)
	{
		case 'mg':
			printf("%f",v*7/100);
			break;
		case "sp":
			printf("%f",v*12/100);
			break;
		case 'rj':
			printf("%f",v*15/100);
			break;
		default:
			printf("Distinatario invalido");
	}
	system("pause");
	return 0;
}