#include <stdio.h>
#include <locale.h>

int main()
{
	int c[10],x=1;
	
	setlocale(LC_ALL,"portuguese");
	
	for(int k=0;k<10;k++)
	{
		printf("Informe o valor da posição[%d]:",k);
		scanf("%d",&c[k]);
	}
	
	for(int k=0;k<9;k++)
	{
		for(int j=k+1;j<10;j++)
		{
            if(c[k]==c[j])
			{
 	 	       	printf("O valor %d esta repetido\n",c[k]);	
				break;		
			}			
		}
	}
}