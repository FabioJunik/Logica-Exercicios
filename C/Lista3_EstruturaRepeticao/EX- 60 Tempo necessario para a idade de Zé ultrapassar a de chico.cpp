#include <stdio.h>

int main(int argc, char** argv)
{
	int a=0;
	float ic=1.50,iz=1.10;
	
	
	while(ic>=iz)
	{
		ic+=0.02;
		iz+=0.03;
		a++;
	}
	
	printf("It will be necessary %i years for the height of zé to exceed that of chico\n",a);
	return 0;
}