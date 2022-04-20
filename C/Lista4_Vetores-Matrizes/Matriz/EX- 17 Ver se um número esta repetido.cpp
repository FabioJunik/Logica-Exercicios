#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	
	int n,m,x;
	
	printf("Informe o valor de n:");
	scanf("%d",&n);
	printf("Informe o valor de m:");
	scanf("%d",&m);
	
	int mat[n][m];
	for(int l=0;l<n;l++)
	{
		for(int c=0;c<m;c++)
		{
			printf("Informe o valor da posição[%d-%d]:",l,c);
			scanf("%d",&mat[l][c]);
		}
	}
		
	for(int l=0;l<n;l++)
	{
		for(int c=0;c<m;c++)
		{
			printf("%d ",mat[l][c]);
			
		}
		printf("\n");
	}	
	
	do
	{
		printf("Digite um número:");
		scanf("%d",&x);
		for(int l=0;l<n;l++)
		{
			for(int c=0;c<m;c++)
			{
				if(x==mat[l][c])
				{
					printf("O número %d existe na posição[%d-%d]\n",x,l,c);
					l=n;
					c=m;
				}
			}
		}	
	}
	while(x>0);
	
	return 0;
}