#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n,q;
	
	printf("Digite um numero:");
	scanf("%d",&n);
	q=0;
	for(int c=1;c<=n;c++)
	{
		if(n%c==0)
			q=q+1;
	}
	if(q==2 || n==1)
		printf("O numero e primo");
	else
		printf("o numero nao e primo");
	return 0;
}