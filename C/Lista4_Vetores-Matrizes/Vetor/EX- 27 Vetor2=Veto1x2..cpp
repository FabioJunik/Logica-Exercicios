#include <stdio.h>
#include <locale.h>
#include <math.h>

main()
{
	setlocale(LC_ALL,"Portuguese");
	
	int q;
	do
	{
		printf("Qual posições o vetor tera:");
		scanf("%d",&q);
		
		if(q>20)
			printf("OBS:O vetor tem que ter o maximo 20 elementos\n");
	}
	while(q >=20);
	
	float x[q],y[q];

	printf("Preenchendo o primeiro Vetor\n");
	for(int c=0;c<q;c++)
	{
		printf("Informe o valor da posição[%d]:",c);
		scanf("%f",&x[c]);
		y[c]=pow(x[c],2);
	}
	
	printf("os Valores do primeiro vetor são: ");
	for(int c=0;c<q;c++)
		printf("%.2f:",x[c]);
	printf("\n");
	
	printf("os Valores do segundo vetor são: ");
	for(int c=0;c<q;c++)
		printf("%.2f:",y[c]);
	printf("\n");
}