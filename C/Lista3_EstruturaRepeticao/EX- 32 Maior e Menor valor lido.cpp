#include <stdio.h>
#include <locale.h>

main()
{
	int n,ma,me;
	
	setlocale(LC_ALL,"portuguese");
	
	for(int c=1;c<11;c++)
	{
		printf("Informe o %d número",c);
		scanf("%d",&n);
		
		if(c==1)
			ma=me=n;
		if(ma<n)
			ma=n;
		if(me>n)
			me=n;
		if(c==10)
			printf("O Maior valor é %d\nE o Menor valor é %d",ma,me);
		
	}
}