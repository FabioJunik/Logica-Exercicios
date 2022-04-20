#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	
	int b,h=0,s,lg,c=0,k=0,j=0,n[c],m[k],l[j];
	
	printf("Informe o tamanho do vetor N:");
	scanf("%d",&c);
	for(int v=0;v<c;v++)
	{
		printf("Informe o valor da posição[%d]:",v);
		scanf("%d",&n[v]);
	}
	
	printf("Informe o tamanho do vetor M:");
	scanf("%d",&k);
	for(int v=0;v<k;v++)
	{
		printf("Informe o valor da posição[%d]:",v);
		scanf("%d",&m[v]);
	}	

	for(int v=0;v<k;v++)
	{
		b=0;
		for(int w=0;w<c;w++)
		{
			if(m[v]==n[w])
			{
				b++;
				lg=true;
			}
			if(v==0 && b==1 && lg==true)
			{
				l[j]=m[v];
				j++;
				lg=false;
			}
			if(v>0)
			{
				if(m[v]==n[w])
				{
					h=0;	
					s=0;
					do
					{
						if(l[h]==m[v])
							s++;			
						h++;
					}
					while(h<j);
				}
				
				if(s==0 && lg==true && b==1)
				{
					l[j]=m[v];
					j++;
					lg=false;
				}
			}
			
		}
		
	}
	
	for(int v=0;v<j;v++)
		printf("%d:",l[v]);
}