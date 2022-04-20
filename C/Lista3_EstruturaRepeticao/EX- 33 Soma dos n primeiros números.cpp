#include <stdio.h>
#include <locale.h>

main()
{
	int n,s=0;
	
	setlocale(LC_ALL,"portuguese");
	
	printf("Informe um número");
	scanf("%d",&n);
	
	for(int c=1;c<=n;c++)
		s=s+c;

	printf("A soma dos primeiros %d número é %d",n,s);
}