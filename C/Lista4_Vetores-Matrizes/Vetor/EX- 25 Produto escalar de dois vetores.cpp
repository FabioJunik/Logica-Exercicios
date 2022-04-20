#include <stdio.h>
#include <locale.h>

main()
{
	float x[5],y[5],p=0;
	
	setlocale(LC_ALL,"portuguese");
	
	printf("VETOR X\n");
	for(int k=0;k<5;k++)
	{printf("Informe o valor da posição[%d]:",k); scanf("%f",&x[k]);}
	
	printf("VETOR Y\n");
	for(int k=0;k<5;k++)
	{printf("Informe o valor da posição[%d]:",k); scanf("%f",&y[k]);}	
	
	for(int k=0;k<5;k++)
	{
		p= p+x[k]*y[k];
	}	
	
	printf("\nO produto escalar é%f\n",p);	
}