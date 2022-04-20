#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int v[10],c,lg,r,s,h;
	
	for(int k=0;k<10;k++)
	{
		printf("Informe o valor da posição[%d]:",k);
		scanf("%d",&v[k]);
	}
	
	for(int k=0;k<9;k++)
	{
		c=0;
		for(int i=k+1;i<10;i++)
		{
			if(v[k]==v[i])
			{
				c++;
				lg=true;
			}
			if(k==0 && c==1 && lg==true)
			{
				printf("O valor %d está repetido\n",v[k]);
				lg=false;
			}
			if(k>0)
			{
				r=1;
				s=0;
				do
				{
					h=k-r;
					if(v[k]==v[h])
						s++;
					r++;
				}
				while(h!=0);
				
				if(s==0 && lg==true && c==1)
				{
					printf("O valor %d esta repetido\n",v[k]);
					lg=false;
				}
			}
		}
	}
	
	system("pause");
	
}