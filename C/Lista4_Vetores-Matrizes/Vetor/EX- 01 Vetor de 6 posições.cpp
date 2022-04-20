#include <stdio.h>
#include <stdlib.h>

int main()
{
	int r[6],s;
	
	r[0]=1;
	r[1]=0;
	r[2]=5;
	r[3]=-2;
	r[4]=-5;
	r[5]=7;
	
	s=r[0]+r[1]+r[5];
	
	r[4]=100;
	
	printf("%d\n",r[0]);
	printf("%d\n",r[1]);
	printf("%d\n",r[2]);
	printf("%d\n",r[3]);
	printf("%d\n",r[4]);
	printf("%d\n",r[5]);
	printf("A soma de primeiro, segondo e o sexto valor sera %d\n",s);
}