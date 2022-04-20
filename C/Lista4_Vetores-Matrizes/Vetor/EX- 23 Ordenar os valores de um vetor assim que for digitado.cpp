#include <stdio.h>
#include <locale.h>

main()
{
	int j[10],a;
	
	setlocale(LC_ALL,"portuguese");
	
	for(int k=0;k<10;k++)
	{
		printf("Valor para a posição|%d|:",k);
		scanf("%d",&j[k]);
		
		for(int c=0;c<k;c++)
		{
			if(j[k]<j[c])
			{
				a=j[k];
				j[k]=j[c];
				j[c]=a;	
			}
		}
			
	}
	
	for(int k=0;k<10;k++)
		printf("%d\n",j[k]);
}