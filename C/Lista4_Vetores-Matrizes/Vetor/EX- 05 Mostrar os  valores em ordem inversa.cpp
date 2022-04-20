#include <stdio.h>
#include <stdint.h>

int main(int argc, char** argv)
{
	int t[6],y=0,a=1;
	
	while(y <=5)
	{
			printf("Informe o valor da posicao[%d]:",y);
			scanf("%d",&t[y]);
			y++;
	}
	
	for(int y=5;y >=0;y--)
		printf("%d\n",t[y]);
	
}