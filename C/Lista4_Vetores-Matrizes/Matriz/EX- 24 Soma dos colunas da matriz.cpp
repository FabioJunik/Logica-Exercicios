#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	
	int l,c;
	
	printf("Informe o extensão da linha :");
	scanf("%d",&l);
	printf("Informe o extensão da linha :");
	scanf("%d",&c);
	
	int mat[l][c],s=0,v[c];
	
	for(int n=0;n<c;n++)
	{
		for(int m=0;m<l;m++)
		{
			printf("Informe o valor da posição[%d-%d]:",n,m);
			scanf("%i",&mat[n][m]);
				s=s+mat[n][m];
		}
		v[n]=s;
		s=0;
	}
		
	printf("\n");	
	for(int n=0;n<c;n++)
		printf("%d  ",v[n]);
}