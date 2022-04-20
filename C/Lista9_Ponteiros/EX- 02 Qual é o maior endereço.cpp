#include <stdio.h>


int main(int argc, char** argv)
{
	int y,x,*px,*py;
	
	px=&x;
	py=&y;
	
	printf("%d\n",px);
	printf("%d\n",py);
	
	if(px>py)
		printf("The biggest addrees is x\n");
	else
		printf("The biggest addrees is y\n");
	return 0;
}