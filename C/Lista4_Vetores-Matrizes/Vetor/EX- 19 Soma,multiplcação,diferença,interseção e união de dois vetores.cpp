#include <stdio.h>
#include <locale.h>

main()
{
	int x[5],y[5],q=0;
	
	setlocale(LC_ALL,"portuguese");
	
	printf("Preenchendo o Vetor X\n");
	for(int k=0;k<5;k++)
	{
		printf("Informe o valor da posi��o[%d]:",k);
		scanf("%d",&x[k]);
	}
	
	printf("\nPreenchendo o Vetor Y\n");
	for(int k=0;k<5;k++)
	{
		printf("Informe o valor da posi��o[%d]:",k);
		scanf("%d",&y[k]);
	}
	
	printf("\n");
	for(int k=0;k<5;k++)
		printf("A Soma dos valores da posi��o [%d] � %d\n",k,x[k]+y[k]);
	
	printf("\n");
	for(int k=0;k<5;k++)
		printf("A Multiplica��o dos valores da posi��o [%d] � %d\n",k,x[k]*y[k]);
		
	printf("\nOs Valores que existem em X que n�o existem em Y s�o: ");
	for(int k=0;k<5;k++)
	{
		for(int c=0;c<5;c++)
		{
			if(x[k]!=y[c])
				q++;
		}
		if(q==5)
			printf("-%d-",x[k]);
		q=0;
	}
	
	printf("\nOs elementos que exite em X que tambem exitem em Y s�o:");
	for(int k=0;k<5;k++)
	{
		for(int c=0;c<5;c++)
		{
			if(x[k]==y[c])
			{
				printf("-%d-",x[k]);
				break;
			}
		}
	}
	
	printf("\nA uni�o entre os valores de X com Y �:");
	for(int k=0;k<5;k++)
		printf("-%d-",x[k]);
	for(int k=0;k<5;k++)
	{
		for(int c=0;c<5;c++)
		{
			if(y[k]!=x[c])
				q++;
		}
		if(q==5)
			printf("-%d-",y[k]);
		q=0;
	}
	
		
}