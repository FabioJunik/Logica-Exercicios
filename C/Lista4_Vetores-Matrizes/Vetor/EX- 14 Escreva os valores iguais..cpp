#include <stdio.h>
#include <stdlib.h>
#include <locale.h>


main()
{
	setlocale(LC_ALL,"portuguese");
	int vet[10],num,logico,igp,h,r,cont;
	   
	for(int i=0;i<10;i++)
	{
		printf("Informe o valor da posição[%d]:",i);
		scanf("%d",&vet[i]);
	}	
	
	for(int i=0;i<9;i++)
	{
		cont=0;
		for(int j=i+1;j<10;j++)
		{
			if(vet[i]==vet[j])
			{
				cont++;
				logico=true;
			}
			if(i==0 && cont==1 && logico==true)
			{
				printf("O número %d esta repetido\n",vet[i]);
				logico=false;
			}
			
			if(i>0)
			{
				r=1;
				igp=0;
				do
				{
					h=i-r;
					if(vet[i]==vet[h])
						igp++;
					r++;
				}
				while(h!=0);
				
				if(cont==1 && igp==0 && logico==true)
				{
					printf("O número %d está repetido\n",vet[i]);
					logico=false;
				}
			}
		}
	}
	
}