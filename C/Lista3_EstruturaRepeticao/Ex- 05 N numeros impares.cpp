#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n;
	
	printf("Digite um numero");
	scanf("%d",&n);
	
	for(int k=1;k <= n; k++)
	{
		if(k % 2==1)
			printf("%d",k);
	}
	system("pause");
	return 0;
}