#include <stdio.h>
#include <locale.h>

main()
{
	long int N;
	
	setlocale(LC_ALL,"portuguese");
	
	printf("Digite um número:");
	scanf("%d",&N);
	
	for(int c=0;c<=N;c++)
		printf("%d\n",c);
}