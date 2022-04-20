#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int c,d;
	
	d=1;
	c=1;
	while(d <=5)
	{
		if(c%3==0)
		{
			d=d+1;
			printf("%d",c);
		}
		c++;
	}
	system("pause");
	return 0;
}