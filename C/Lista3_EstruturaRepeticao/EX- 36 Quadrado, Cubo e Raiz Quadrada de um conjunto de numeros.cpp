#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
	int n,q,c;
	float r;
	
	do
	{
		printf("Digite um numero");
		scanf("%i",&n);
		q= pow(n,2);
		c= pow(n,3);
		r= sqrt(n);
		if(n==0)
			break;
		else
			printf("O quadro do numero sera %d\n o de Cudo sera %d\n E a sua raiz quadrada sera %.2f\n",q,c,r);
	}
	while(n >0 || n!=0);
	system("pause");
}