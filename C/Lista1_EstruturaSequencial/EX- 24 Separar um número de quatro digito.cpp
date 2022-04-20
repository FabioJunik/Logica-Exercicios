#include <stdio.h>
#include <locale.h>

main()
{
	int n,x,a,b,c,d;
	
	printf("Informe um número de quatro digito:");
	scanf("%d",&n);
	
	a=n/1000;
	n=n%1000;
	b=n/100;
	n=n%100;
	c=n/10;
	d=n%10;
	
	printf("%d\n%d\n%d\n%d\n",a,b,c,d);
}