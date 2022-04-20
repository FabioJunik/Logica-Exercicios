#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int n,q;
	
	do
	{
		printf("Digite um número:");
		scanf("%d",&n);
	}
	while(n<=0);
	
	for(int c=1;c<=n;c++)
	{
		q=0;
		for(int k=1;k<=c;k++)
		{
			if(c%k==0)
				q++;
		}
		if(q==2)
			printf("%d\n",c);
	}
}