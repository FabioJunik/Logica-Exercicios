#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	int m[5][5];
	
	for(int l=0;l<5;l++)
	{
		for(int c=0;c<5;c++)
		{
			if(l==c)
				m[l][c]=1;
			else
				m[l][c]=0;
		}
	}
	
	for(int l=0;l<5;l++)
	{
		for(int c=0;c<5;c++)
		{
			printf("%d   ",m[l][c]);
		}
		printf("\n");
	}
	
	
}