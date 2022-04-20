#include <stdio.h>
#include <stdlib.h>

int main()
{
	int a,c=0,n;
	
	do
	{
		printf("Informe um numero");
		scanf("%d",&n);
		c++;
		a= 1+(rand()%1000);
		printf("%d\n",a);	
	}
	while(a!=n);
	printf("Vc tentou %d vezes\n",c);
}