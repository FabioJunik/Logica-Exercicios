#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
	int mes;
	
	printf("Digite um número");
	scanf("%d",&mes);
	
	switch (mes)
	{
		case 1 ... 4:
			printf("1234");
        break;
		case 5 ... 9:
			   printf("56789");	
        break; 
    	default:
    		printf("ERRO");
	}
	return 0;
	system("pause");
}