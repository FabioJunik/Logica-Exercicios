#include <stdio.h>
#include <locale.h>

main()
{
	int c=-1,v[c],n=0,p=0;
	
	setlocale(LC_ALL,"portuguese");
	
	do
	{
		c++;
		printf("Informe o valor da posi��o[%d]:",c);
		scanf("%d",&v[c]);
		
		if(v[c]<0)
			n++;
		if(v[c]>0)
			p++;
		
	}
	while(v[c]!=0);
		
	printf("A Quantidade de n�meros negativos presentes na sequencia � %d\n",n);	
	printf("A Quantidade de n�meros positivos presentes na sequencia � %d\n",p);	
}