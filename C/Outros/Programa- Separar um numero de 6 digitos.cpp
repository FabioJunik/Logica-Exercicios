#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int a,b,c,d,e,f,n;
	
	printf("Infome um numero");
	scanf("%i",&n);
	
	a= n/100000;
	n= n%100000;
	b= n/10000;
	n= n%10000;
	c= n/1000;
	n= n%1000;
	d= n/100;
	f= n%10;
	n= n%100;
	e= n/10;
	
	printf("f=%i\n",f);
	printf("e=%i\n",e);
	printf("d=%i\n",d);
	printf("c=%i\n",c);
	printf("b=%i\n",b);
	printf("a=%i\n",a);
	return 0;
}