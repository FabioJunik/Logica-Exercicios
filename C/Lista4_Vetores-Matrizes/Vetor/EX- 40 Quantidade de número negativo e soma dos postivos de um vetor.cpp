#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int f[10],q=0,s=0;
	
	for(int c=0;c<10;c++)
	{
		printf("Informe o valor da posi��o[%d]:",c);
		scanf("%d",&f[c]);
		
		if(f[c]>0)
			s=s+f[c];
		if(f[c]<0)
			q++;
	}
	
	printf("A Soma dos n�meros positivos �: %d\n",s);
	printf("A quantidade de valores negativo �: %d\n",q);
	
	
}