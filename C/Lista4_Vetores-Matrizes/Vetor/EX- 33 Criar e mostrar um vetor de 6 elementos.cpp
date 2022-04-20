#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int f[6];
	
	for(int c=0;c<6;c++)
	{
		printf("Informe o valor da posição[%d]:",c);
		scanf("%d",&f[c]);
	}
	for(int c=0;c<6;c++)
	{
		printf("[%d]\n",f[c]);
	}	
	
	
}