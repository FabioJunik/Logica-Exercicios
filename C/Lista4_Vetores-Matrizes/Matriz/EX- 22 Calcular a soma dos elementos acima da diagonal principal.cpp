#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	
	int l;
	
	printf("Informe o extensão da matriz quadrada :");
	scanf("%d",&l);
	
	int mat[l][l],s=0;
	
	for(int n=0;n<l;n++)
	{
		for(int m=0;m<l;m++)
		{
			printf("Informe o valor da posição[%d-%d]:",n,m);
			scanf("%i",&mat[n][m]);
			
			if(n<m)
				s=s+mat[n][m];
		}
	}
	
	printf("A soma dos valores acima da diagonal principal é %i",s);
		
}