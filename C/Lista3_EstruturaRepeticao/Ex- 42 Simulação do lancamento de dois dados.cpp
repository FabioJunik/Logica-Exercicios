#include <stdio.h>
#include <stdlib.h>

int main()
{
	int n,d1,d2;
	
	printf("Quantas vezes iras jirar os dados\n");
	scanf("%d",&n);
	
	for(int t=1;t<=n;t++)
	{   
		d1= 1+(rand()%100);
		d2= 1+(rand()%100);
		
		printf("Na %d vezes ",t);
		if(d1>d2)
		{
			printf("D1 e maior\n");
			printf("D1=%d D2=%d\n",d1,d2);
		}
		else if(d1<d2)
		{
			printf("D2 e maior\n");
			printf("D1=%d D2=%d\n",d1,d2);
		}
		else
		{
			printf("Os o valores sao iguais\n");
			printf("D1=%d D2=%d\n",d1,d2);
		}
	}
}