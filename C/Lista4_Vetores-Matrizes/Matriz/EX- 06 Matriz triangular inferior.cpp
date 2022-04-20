#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	float m[4][4],l;
	
	for(int c=0;c<4;c++)
	{
		for(int k=0;k<4;k++)
		{
			l=l+0.08;
			m[c][k]=l;
		}
	}
	
	for(int c=0;c<4;c++)
	{
		for(int k=0;k<4;k++)
		{	
			printf("%.2f    ",m[c][k]);
		}
		printf("\n");
	}
	
	printf("\n\n");
	for(int c=0;c<4;c++)
	{
		for(int k=0;k<4;k++)
		{
			if(c<k)
				m[c][k]=0;
			
			if(c>k)
				printf("%.2f    ",m[c][k]);
		}
		printf("\n");
	}
	
	
}