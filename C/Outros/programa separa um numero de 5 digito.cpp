#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int a,b,c,d,e,n;
	
	printf("Infome um numero");
	scanf("%i",&n);
	
	a= n/10000;
	n= n%10000;
	b= n/1000;
	n= n%1000;
	c= n/100;
	n= n%100;
	e= n%10;
	d= n/10;
	printf("e=%i\n",e);
	printf("d=%i\n",d);
	printf("c=%i\n",c);
	printf("b=%i\n",b);
	printf("a=%i\n",a);
	return 0;
}