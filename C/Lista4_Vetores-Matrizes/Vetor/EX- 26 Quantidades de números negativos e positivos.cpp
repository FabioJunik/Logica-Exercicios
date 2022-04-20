#include <stdio.h>
#include <locale.h>

main()
{
	int c=-1,v[c],n=0,p=0;
	
	setlocale(LC_ALL,"portuguese");
	
	do
	{
		c++;
		printf("Informe o valor da posição[%d]:",c);
		scanf("%d",&v[c]);
		
		if(v[c]<0)
			n++;
		if(v[c]>0)
			p++;
		
	}
	while(v[c]!=0);
		
	printf("A Quantidade de números negativos presentes na sequencia é %d\n",n);	
	printf("A Quantidade de números positivos presentes na sequencia é %d\n",p);	
}