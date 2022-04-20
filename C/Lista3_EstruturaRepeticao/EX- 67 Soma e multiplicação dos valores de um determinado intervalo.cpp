#include <stdio.h>
#include <stdlib.h>

int main()
{
	int i,j,s=0,m=1;
	
	
	printf("Informe o intervalo :\n");
	scanf("%d%d",&i,&j);
	
	if(i<j)
	{
		for(;i<=j;i++)
		{
			if(i%2==0)
				s=s+i;
			else
				m=m*i;
		}
	}
	else
	{
		for(;j<=i;j--)
		{
			if(i%2==0)
				s=s+i;
			else
				m=m*i;
		}		
	}
	printf("A soma dos valores pares deste intervalo sera %d\n",s);
	printf("A multiplicacao dos valores impares deste intervalo e %d\n",m);
}