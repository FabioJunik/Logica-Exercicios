#include <stdio.h>
#include <locale.h>

main()
{
	int n,s=0;
	float med;
	
	setlocale(LC_ALL,"portuguese");
	
	for(int c=1;c<11;c++)
	{
		printf("Informe o %d número",c);
		scanf("%d",&n);
		   	
		s=s+n;
		
		if(c==10)
		{
			med=s/10;
			printf("A media dos valores é %.2f",med);
		}
		
	}
}