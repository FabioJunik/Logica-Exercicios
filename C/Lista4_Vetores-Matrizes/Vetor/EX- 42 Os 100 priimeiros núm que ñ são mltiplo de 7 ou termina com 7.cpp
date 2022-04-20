#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int f[100],c=0,k=1,r;
	
	while(c<100)
	{
		r=(k-7)%10;   	
		if(k%7!=0 && r!=0 )
		{
			f[c]=k;
			c++;
		}
		k++;
	}
	
	for(c=0;c<100;c++)
		printf("[%d]\n",f[c]);
}