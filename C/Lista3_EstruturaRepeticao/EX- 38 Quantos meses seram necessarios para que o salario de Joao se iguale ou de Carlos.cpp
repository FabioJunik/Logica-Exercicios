#include <stdio.h>
#include <stdlib.h>

int main()
{
	float sac,saj,c,j;
	int r=1;
	
	printf("Informe o salario do Carlos");
	scanf("%f",&sac);
	saj= sac/3;
	printf("O salario do Joao eh,%.3f\n",saj);
	
	while(saj<=sac)
	{
		sac= sac+(sac*2/100);
		saj= saj+(saj*5/100);
		r++;
	}
	printf("Seram precisos %d para que o salario de Joao seje maior ou igual ao de Carlos\n",r);

		
	
}