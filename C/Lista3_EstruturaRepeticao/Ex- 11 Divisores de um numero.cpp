#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int a;
	
	printf("Digite o numero");
	scanf("%d",&a);
	
	for(int j=1;j<=a;j++)
	{
		if(a%j==0)
			printf("%d-",j);
	}
	printf("\n");
	
	system("pause");
	return 0;
}