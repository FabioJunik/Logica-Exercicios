#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int f[8],x,y;
	
	for(int c=0;c<8;c++)
	{
		printf("Informe o valor da posi��o[%d]:",c);
		scanf("%d",&f[c]);
	}
	
	printf("Digite dois n�meros :\n");
	scanf("%d%d",&x,&y);
	
	printf("A soma da posi��o %d com a posi��o %d � %d\n",x,y,f[x]+f[y]);
	
}