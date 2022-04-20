#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n,s=0;
	
	printf("Ïnforme um numero");
	scanf("%d",&n);
	
	for(int k=1;k<n;k++)
	{
		if(n%k==0)
			s=s+k;
	}
	printf("A soma dos divisores de %d e=%d",n,s);
	return 0;
}