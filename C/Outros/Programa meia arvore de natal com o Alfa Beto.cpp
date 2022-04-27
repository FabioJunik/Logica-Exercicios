#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n;
	char T,t, A;
	
	printf("Informe um numero");
	scanf("%d",&n);

	T='A';	
	for(int c=1;c<=n;c++)
	{
		for(int k=1;k<=c;k++)
			printf("%c",T);

		T++;
		printf("\n");
	}
	return 0;
}