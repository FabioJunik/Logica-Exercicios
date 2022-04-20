#include <stdio.h>
#include <stdlib.h>

int main()
{
	int q=0,qm;
	float n,m;
	
	printf("Informe a quantidade de valores que seram lidos");
	scanf("%d",&qm);
	
	for(int y=1;y<=qm;y++)
	{
		printf("Digite o %d numero",y);
		scanf("%f",&n);
		
		
		if(y==1)
			m=n;
		else if(n>m)	
		{
		    m=n;
			q=0;	
		}
		if(m==n)
			q++;	
	}
	printf("O maior valor foi %.2f e se repetiu %d vezes\n",m,q);
}