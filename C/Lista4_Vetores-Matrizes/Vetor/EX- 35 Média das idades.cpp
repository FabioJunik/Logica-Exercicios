#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int n,s=0,q=0;
	float med;
	
	
	do
	{
		printf("Informe a idade");
		scanf("%d",&n);
		if(n!=0)
		{
			q++;
			s=s+n;
		}
	}
	while(n!=0);
	
	med=s/q;
	printf("A media das idades é: %.2f\n",med);

}