#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int n=0,c[n],f,z=0,x[z];
	
	printf("Digite um n�mero:");
	scanf("%d",&n);
	
	for(int v=0;v<n;v++)
	{
		printf("Informe o valor da posi��o[%d]:",v);
		scanf("%d",&c[v]);
	}
	
	printf("Digite um n�mero:");
	scanf("%d",&f);
	for(int v=1;v<=f;v++)
	{
		if(f%v==0)
		{
			x[z]=v;
			z++;
		}
	}
	
	printf("Os multiplos de %d s�o:",f);
	for(int v=0;v<z;v++)
		printf("%d",x[v]);
}