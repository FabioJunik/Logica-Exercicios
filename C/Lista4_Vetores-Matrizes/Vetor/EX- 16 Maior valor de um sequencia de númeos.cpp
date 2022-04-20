#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int n,k=0,f[k],ma;
	
	do
	{	
		printf("Informe um valor:");
		scanf("%d",&n);
		
		if(n!=0)
		{
			f[k]=n;
			k++;
		}
	}
	while(n!=0);

	ma=f[0];

	for(int v=0;v<k;v++)
	{
		if(f[v]>ma)
			ma=f[v];
	}
	
	printf("O maior valor desta sequencia é %d\n",ma);
}