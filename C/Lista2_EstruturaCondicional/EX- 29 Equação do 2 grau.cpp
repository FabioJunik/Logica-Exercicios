#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char** argv)
{
	float a,b,c,d,r,x1,x2;
	
	printf("Qual e o valor de a:\n ");
	scanf("%f",&a);
	printf("Qual e o valor de b:\n ");
	scanf("%f",&b);
	printf("Qual e o valor de c:\n ");
	scanf("%f",&c);
	
	if(a != 0)
    {
		d = b*b-4*a*c;
		r= sqrt(d);
		if(r > 0)
		{
			x1= -b+(r)/2*a;
			x2= -b-(r)/2*a;
			printf("O valor de X1= %.2f\n",x1);
			printf("O valor de X2= %.2f\n",x2);
		}	
		else
		{
			if(r < 0)
			{
				printf("Nao existe raiz\n");
			}	
			else
			{
				printf("Raiz nula\n");
			}
		}
	}
	else
	{
		printf("Nao e uma equacao do 2 grau \n");
	}
	system("pause");
	return 0;
}