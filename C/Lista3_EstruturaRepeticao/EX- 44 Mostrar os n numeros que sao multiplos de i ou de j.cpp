#include <stdio.h>
#include <stdlib.h>

int main()
{
	int r=1,c=1,i,j,n;
	
	printf("Digite dois valores");
	scanf("%d%d",&i,&j);
	printf("Diz quantos mutiplos queres achar");
	scanf("%d",&n);
	
	while(c <=n)
	{
		if(r%j==0 || r%i==0)
		{
			printf("%d\n",r);
			c++;		
		}
		r++;	
	}
}