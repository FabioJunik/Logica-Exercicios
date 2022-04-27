#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	
	void escrever(int y[3][3]);
	
	int m[3][3] = {1,2,3,4,5,6,7,8,9};
	
	escrever(m);
}
void escrever(int y[][3])
{
	for(int l=0;l<3;l++)
	{
		for(int c=0;c<3;c++)
			printf("%d  ",y[l][c]);
		printf("\n");
	}
}