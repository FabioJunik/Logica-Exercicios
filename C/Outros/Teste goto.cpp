#include <stdio.h>

main()
{
	int c=0;
	
	cont:
		printf("%d\n",c);
		c++;
		if(c<=10000)
			goto cont;
}