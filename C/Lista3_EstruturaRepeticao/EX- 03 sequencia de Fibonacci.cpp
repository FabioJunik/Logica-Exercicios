#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n, no,a,act;
	
	printf("Informe um numero");
	scanf("%d",&n);
	
	printf("011");
	act=a=1;
	for (int c=1; c <=n ;c=no)
	{	
		no = a+act;
		act= a;
		a=no;
		printf("%d",no);
	}
	return 0;
}