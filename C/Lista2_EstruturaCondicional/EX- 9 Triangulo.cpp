#include <stdio.h>
#include <stdlib.h>

int main()
{
	float l1,l2,l3;
	
	printf("Infome o valor dos Tr%cs lados do triangulo",131);
	scanf("%f%f%f",&l1,&l2,&l3);
	if( l1+l2>l3 && l1+l3>l2 && l2+l3>l1)
	{
		printf("Pode formar um triangulo\n");
		if(l1==l2 && l1==l3)
		{
			printf("Forma um triangulo equilatero\n");
		}	
		else
		if(l1!=l2 && l2!=l3 && l3!=l1)
		{
			   	printf("Forma um triangulo escaleno\n");
		}   	   	
		else
		{
			printf("Forma um triangulo esosceles\n");
		}
	}	
	else
	{
		printf("Nao pode formar um triangulo\n");
	}
	system("pause");
	return 0;
}