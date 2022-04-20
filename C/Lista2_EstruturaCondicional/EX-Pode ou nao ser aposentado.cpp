#include <stdio.h>
#include <stdlib.h>

int main()
{
	int i, ts;
	
	printf("Informe a idade do trabalhador:");
	scanf("%i",&i);
	printf("Informe o tempo de servico do trabalhador");
	scanf("%d",ts);
	
	if (i>=65 || ts>= 30 || i>=60 && ts>=25)
	{
		printf("O trabalhador pode ser aposentado\n");
	}
	else
	{
		printf("O trabalhador nao pode ser aposentado\n");
	}
	system("pause");
	return 0;
}
