#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n,T;
	char t, A;
	
	printf("Informe um numero");
	scanf("%d",&n);

	T=1;	
	for(int c=1;c<=n;c++)
	{
		for(int k=1;k<=c;k++)
		{
			printf(" %d",T);
			T++;
		}
		printf("\n");
	}
	return 0;
}