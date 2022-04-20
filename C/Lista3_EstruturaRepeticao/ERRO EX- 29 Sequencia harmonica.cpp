#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n;
	float Hn=1;
	
	printf("Informe um numero");
	scanf("%d",&n);
	
	for (int k =2;k <=n;k ++)
		Hn = Hn + (1/k);	

	printf("O valor da seria Harmonica sera =%.2f\n", Hn);
	
	system("pause");
	return 0;
}