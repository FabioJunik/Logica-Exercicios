#include <stdio.h>
#include <stdlib.h>

int main()
{
	int a;
	float au,p=1.5;
	
	printf("Informe o ano actual");
	scanf("%d",&a);
 	
 	printf("Salario em 1995 = 2000\n");
	au = 2000+(2000*p/100);
	printf("Salrio em 1996 = %.3f\n",au);
	
	for(int c=1997;c<=a; c++)
	{
		p = p*2;
		au= au+(au*p/100);
		printf("Salrio em %d = %.3f\n",c,au);
	}
	return 0;
}