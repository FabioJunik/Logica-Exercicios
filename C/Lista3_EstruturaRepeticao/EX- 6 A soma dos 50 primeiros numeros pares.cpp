#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int s=0;
	
	for(int y=0;y<=50;y=y+2)
		s=s+y;
	printf("A soma dos 50 numeros pares eh %d\n", s);
	
	system("pause");	
	return 0;
}