#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int f[50];
	
	for(int i=0;i<50;i++)
		f[i]=(i+i*5)%(i+1);

	for(int i=0;i<50;i++)
		printf("%d\n",f[i]);
		
}