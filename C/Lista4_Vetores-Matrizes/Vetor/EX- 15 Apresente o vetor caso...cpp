#include <stdio.h>
#include <locale.h>

int main()
{
	float q[5];
	int n;
	
	setlocale(LC_ALL,"portuguese");
	
	for(int f=0;f<5;f++)
	{
		printf("Informe o valor da posição[%d]:",f);
		scanf("%f",&q[f]);
	}
	
	do
	{
		printf("Digite um numero:");
		scanf("%d",&n);
		
		switch(n)
		{
			case 0:
				break;
			case 1:
				for(int f=0;f<5;f++)
					printf("%.2f\n",q[f]);
				break;
			case 2:
				for(int f=4;f>=0;f--)
					printf("%.2f\n",q[f]);
				break;
			default:
				printf("O codigo é invalido\n");
		}
	} 
	while(n!=0);
}