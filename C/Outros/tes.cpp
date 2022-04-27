#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int  main()
{
	int p,e,d;
	
	
	printf("Qual é o valor do produto");
	scanf("%d",&p);
	e= p*50/100;
	d= p-e;
	printf("o valor do produto com o desconto com 12 sera= %i ",d);
	return 0;
}

