#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char** argv)
{
	float a,b,c,d,x1,x2;
	
		
	printf("Qual e o valor de a:\n ");
	scanf("%f",&a);
	printf("Qual e o valor de b:\n ");
	scanf("%f",&b);
	printf("Qual e o valor de c:\n ");
	scanf("%f",&c);
	
	d=b*b-4*a*c;
	printf("Delta = %.2f\n",d);
	
	if(d<0)
		printf("Nao tem solucao\n");
	else if(d==0)
	{
		x1=x2=-b/2*a;
		printf("As raizes sao iguais. x1 e x2 = .2%f",x1);
	}else{
		x1=(-b+sqrt(d))/(2*a);
		x2=(-b-sqrt(d))/(2*a);
		printf("O valor x1 = %.2f\n", x1);
		printf("O valor x2 = %.2f\n", x2);
	}
	system("pause");
	return 0;
}