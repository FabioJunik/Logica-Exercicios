#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv)
{
	int a; 

	printf("Informe um numero :");
	scanf("%d",&a);
	if(a % 2== 0)
	{
		printf("O numero e par\n");
	}
	else
	{
		printf("o numero e impar\n");
	}
	system("pause");
	return 0;
}