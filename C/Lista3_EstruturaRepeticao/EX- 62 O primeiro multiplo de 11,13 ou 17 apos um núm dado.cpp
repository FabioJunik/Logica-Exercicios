#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int n,c;
	
	printf("Digite um n�mero");
	scanf("%d",&n);
	
	c=n-1;
	do
	{
		c++;
		if(c%11==0||c%13==0||c%17==0)
		{
			printf("O primeiro multiplo de 11,13 ou 17 � %d\n",c);
			c=0;
		}
	}
	while(c!=0);
	
}