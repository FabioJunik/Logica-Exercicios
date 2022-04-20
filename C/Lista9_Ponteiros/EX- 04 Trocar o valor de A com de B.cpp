#include <stdio.h>

int *pa,*pb,k;

int  main()
{
	int a,b;
	pa=&a;
	pb=&b;
	int troca(int x,int y);
	printf("Type volue of a:");
	scanf("%d",&a);
		
	printf("Type volue of b:");
	scanf("%d",&b);
	
	printf("%d\n%d\n\n",a,b);
	
	troca(a,b);
	
	
	printf("%d\n%d\n",a,b);
}

int troca(int x,int y)
{
	k=*pa;
	*pa=*pb;
	*pb=k;
	
	return *pa,*pb;
}