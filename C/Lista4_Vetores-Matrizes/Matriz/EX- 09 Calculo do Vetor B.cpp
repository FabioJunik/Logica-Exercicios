#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int A[5][5],B[5][5];
	
	for(int a=0;a<5;a++)
	{
		for(int b=0;b<5;b++)
		{
			printf("Informe o valor da posição[%d-%d]:",a,b);
			scanf("%d",&A[a][b]);
			
			B[a][b]=pow(A[a][b],2);
		}
	}
	
	printf("Matriz A:\n");
	for(int a=0;a<5;a++)
	{
		for(int b=0;b<5;b++)
		{
			printf("%d  ",A[a][b]);
		}
		printf("\n");
	}
	
	printf("Matriz B:\n");
	for(int a=0;a<5;a++)
	{
		for(int b=0;b<5;b++)
		{
			printf("%d  ",B[a][b]);
		}
		printf("\n");
	}	
}