#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
	int a,b=1;
	float r,c;
	
	do
	{
		for(a=1; a<=1000;a++)
		{
			c= sqrt(pow(a,2)+pow(b,2));
			r= a+b+c;
		if(r==1000)
		{
			break;
			}
		}
		b++;
	}
	while(r!=1000);
	printf("%d+%d+%d=1000\n",a,b,c);
	
}