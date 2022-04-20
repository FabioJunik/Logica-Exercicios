#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int a[10];
	
	
	for(int h=0;h<10;h++)
	{
		printf("Informe o valor da posicao '%d':",h);
		scanf("%d",&a[h]);
		if(a[h]<0)
			a[h]=0;
	}
	for(int h=0;h<10;h++)
		printf("%d\n",a[h]);
}