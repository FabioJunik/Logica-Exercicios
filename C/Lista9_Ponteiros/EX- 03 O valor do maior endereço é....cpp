#include <stdio.h>


int main(int argc, char** argv)
{
	int y,x,*px,*py;
	
	px=&x;
	py=&y;
	
	printf("Type two number:");
	scanf("%d%d",&x,&y);
	
	if(px>py)
		printf("The number of the biggest addrees  is %d\n",*px);
	else
		printf("The number of the biggest addrees  is %d\n",y);
	return 0;
}