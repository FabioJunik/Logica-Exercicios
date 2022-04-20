#include <stdio.h>


int main(int argc, char** argv)
{
	float b,h,a;
	
	do
	{
		printf("Enter the height and base value");
		scanf("%f%f",&h,&b);
		
		if(h>0 && b>0)
		{
			a=h*b/2;
			printf("the value of the triangle area is %.3f",a);
		}
	}
	while(h <=0 && b <=0);
	return 0;
}