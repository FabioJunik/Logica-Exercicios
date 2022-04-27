#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int p1,p2,s;
	
	for(int c=1000;c<=9999;c++)
	{
		p1=c/100;
		p2=c%100;
		s=p1+p2;
		if(s*s==c)
			printf("%d\n",c);
		
	}
	return 0;
}