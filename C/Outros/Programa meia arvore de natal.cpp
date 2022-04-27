#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int r;

	printf("Informe o numeros de ramos");
	scanf("%d", &r);

	for(int c = 1; c <= r; c++) {
		for(int k = 1; k <= c; k++)
			printf("*");
		printf("\n");
	}
	return 0;
}
