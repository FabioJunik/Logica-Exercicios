#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	
	int a,b,q,qp=0;
	
	printf("Digite dois n�meros:");
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
			qp++;
		
	}
	printf("Entre %d e %d existem %d n�meros primos",a,b,qp);
	
}