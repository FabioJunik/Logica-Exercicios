#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int s=0,n;
	
	for(int k=1;k<=10;k++)
	{
		printf("Digite o %d numero",k);
		scanf("%d",&n);
		s=s+n;
	}
	printf("A soma dos numeros e %d\n",s);
	
	system("pause");
	return 0;
}