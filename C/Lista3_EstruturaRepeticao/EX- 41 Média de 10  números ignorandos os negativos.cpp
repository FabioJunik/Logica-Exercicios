#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int n,s=0,q=0,c=1;
	float med;
	
	
	do
	{
		printf("Informe um n�mero");
		scanf("%d",&n);
		if(n>0)
		{
			q++;
			s=s+n;
		}
		c++;
	}
	while(c!=10);
	
	med=s/q;
	printf("A media dos n�meros �: %.2f\n",med);
}