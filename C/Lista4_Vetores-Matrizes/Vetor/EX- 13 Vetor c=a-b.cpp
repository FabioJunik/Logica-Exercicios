#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main()
{
	int a[10],b[10],c[10];
	
	setlocale(LC_ALL,"portuguese");
	
	printf("PREENCHENDO O VETOR A\n");
	for(int f=0;f<10;f++)
	{
		printf("Informe o valor da posição[%d]:",f);
		scanf("%d",&a[f]);
	}
	
	printf("PREENCHENDO O VETOR B\n");
	for(int f=0;f<10;f++)
	{
		printf("Informe o valor da posição[%d]:",f);
		scanf("%d",&b[f]);
		c[f]=a[f]-b[f];
	}
	
	for(int f=0;f<10;f++)
		printf("\n O valor do Vetor C da posição[%d] é:%d",f,c[f]);

	return 0;
}