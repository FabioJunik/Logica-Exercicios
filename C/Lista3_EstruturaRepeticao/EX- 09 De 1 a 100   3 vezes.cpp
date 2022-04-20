#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int c=1;
	
	for(; c<=100;c++)
		printf("%d\n",c);
	c=1;
	while(c<=100)
	{
		printf("%d\n",c);
		c++;
	}
	c=1;
	do
	{
		printf("%d\n",c);
		c++;
	}
	while(c<=100);
	return 0;
}