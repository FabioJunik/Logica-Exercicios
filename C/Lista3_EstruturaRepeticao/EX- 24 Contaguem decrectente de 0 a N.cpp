#include <stdio.h>
#include <locale.h>

main()
{
	int N;
	
	setlocale(LC_ALL,"portuguese");
	
	printf("Digite um n�mero:");
	scanf("%d",&N);
	
	for(int c=N;c>=0;c--)
		printf("%d\n",c);
}