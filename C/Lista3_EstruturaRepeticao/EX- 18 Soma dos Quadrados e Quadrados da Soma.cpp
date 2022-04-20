#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char** argv)
{
	int sq=0,s=0;
	
	
	for(int k=1;k<=100;k++)
	{
		sq =  pow (k,2) + sq;
		s = s+k;
	}
	printf("A soma dos quadrados e =%d\n", sq);
	printf("O quadrado da soma e =%d\n", s*s);
	printf("A diferenca entre o soma dos quadrado e o quadrado da soma e =%d", sq-s*s);
	return 0;
}