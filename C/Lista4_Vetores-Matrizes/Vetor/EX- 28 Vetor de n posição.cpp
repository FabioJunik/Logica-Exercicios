#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int n=0,c[n],f,z=0,x[z];
	
	printf("Digite um número:");
	scanf("%d",&n);
	
	for(int v=0;v<n;v++)
	{
		printf("Informe o valor da posição[%d]:",v);
		scanf("%d",&c[v]);
	}
	
	printf("Digite um número:");
	scanf("%d",&f);
	for(int v=1;v<=f;v++)
	{
		if(f%v==0)
		{
			x[z]=v;
			z++;
		}
	}
	
	printf("Os multiplos de %d são:",f);
	for(int v=0;v<z;v++)
		printf("%d",x[v]);
}