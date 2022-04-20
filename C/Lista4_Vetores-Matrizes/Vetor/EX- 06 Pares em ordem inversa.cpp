#include <stdio.h>
#include <stdint.h>

int main(int argc, char** argv)
{
	int t[6],y=0,a=1;
	
	while(y <=5)
	{
		if(a==1)
		{
			printf("Informe o valor da posicao[%d]:",y);
			scanf("%d",&t[y]);
		}
		if(t[y]%2==0)
		{
			y++;
			printf("Informe o valor da posicao[%d]:",y);
			scanf("%d",&t[y]);
		}
		else
		{
			printf("VALOR INVALIDO\n");
			printf("Por favor informe novamente o valor da posicao[%d]\n",y);
			scanf("%d",&t[y]);
		}
		a++;
	}
	
	for(int y=5;y >=0;y--)
		printf("%d\n",t[y]);
	
}