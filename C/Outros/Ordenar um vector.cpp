#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int b[11],a;
	
	for(int k=0;k<11;k++)
	{
		printf("Informe o valor da posicao |%d|",k);
		scanf("%d",&b[k]);
	}
	for(int k=0;k<10;k++)
	{
		for(int y=k+1;y<11;y++)
		{
			if(b[k]>b[y])
			{
				a=b[k];
				b[k]=b[y];
				b[y]=a;
			}
		}
	}
	for(int k=0;k<11;k++)
		printf("-%d-",b[k]);
	return 0;
}