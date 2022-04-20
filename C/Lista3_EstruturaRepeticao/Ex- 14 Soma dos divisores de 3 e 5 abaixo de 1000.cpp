#include <stdio.h>
#include <stdlib.h>

int main()
{
	int s=0;
	
	for(int e=1;e<1001;e++)
	{
		if(e%3==0 && e%5==0)
			s=s+e;
	}
	printf("A soma dos numeros naturais abaixo de 1000 que sao multiplos de 3 e 5  eh %d", s);
	return 0;
}