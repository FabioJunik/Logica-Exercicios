#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	
	int a,b,q,s=0;
	
	printf("Digite dois números:");
	scanf("%d%d",&a,&b);
	
	for(int w=a;w<=b;w++)
	{
		q=0;
		for(int v=1;v<=w;v++)
		{
			if(w%v==0)
				q++;
		}
		if(q==2)
			s=s+w;
		
	}
	printf("A soma dos números primos entre %d e %d é %d",a,b,s);
	
}