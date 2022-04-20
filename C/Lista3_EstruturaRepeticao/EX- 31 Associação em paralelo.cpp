#include <stdio.h>
#include <stdlib.h>

int main()
{
	float R,R1,R2;
	
	do
	{
		printf("Informe o valor de R1:");
		scanf("%f",&R1);
		printf("Informe o valor de R2:");
		scanf("%f",&R2);
		R =R1*R2/(R1+R2);
		if(R==0)
			break;
		else
			printf("O valor de Rt sera %.3f\n",R);
		printf("-----------------------------------\n");
	}
	while(R!=0);
}