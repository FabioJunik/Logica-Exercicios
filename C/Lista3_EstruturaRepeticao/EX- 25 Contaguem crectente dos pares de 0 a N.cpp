#include <stdio.h>
#include <locale.h>

main()
{
	int N;
	
	setlocale(LC_ALL,"portuguese");
	
	printf("Digite um número:");
	scanf("%d",&N);
	
	for(int c=0;c<=N;c++)
	{
		if(c%2==0)
	   		printf("%d\n",c);
	}
}