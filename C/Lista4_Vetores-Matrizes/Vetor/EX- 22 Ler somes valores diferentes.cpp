#include <stdio.h>
#include <locale.h>

main()
{
	int l[10],c=0;
	
	setlocale(LC_ALL,"portuguese");
	
	while(c<10)
	{
		printf("Informe o valor da posição[%d]:",c);
		scanf("%d",&l[c]);
		
			for(int k=0;k<c;k++)
			{
				if(l[c]==l[k])	
				{
					do
					{
						printf("Informe outro valor para posição[%d]:",c);
						scanf("%d",&l[c]);
						k=0;
					}
					while(l[c]==l[k]);
				}
			}

		c++;
	}
	
	for(int c=0;c<10;c++)
		printf("%d\n",l[c]);
}