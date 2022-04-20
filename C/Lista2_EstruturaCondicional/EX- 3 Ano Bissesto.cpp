#include <stdio.h>
#include <stdlib.h>

int main()
{
	int a;
	
	printf("Informe o ano");
	scanf("%d",&a);
	if ((a%400==0 || a%4==0) && a%100!=0)
	{
		printf("O ano %d %c Bissesto\n",a,130);
	}
	else
	{
		printf("O ano nao e Bissesto\n");
	}
	system("pause");
	return 0;
}
