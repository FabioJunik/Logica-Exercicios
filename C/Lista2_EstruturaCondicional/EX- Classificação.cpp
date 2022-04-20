#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	float p, a;
	
	printf("Informe o peso e a altura da pessoa");
	scanf("%f%f",&p,&a);
	
	printf("A categoria sera:");
	
	if (a<1.20)
	{
		if(p >0 && p <61)
			printf("A\n");
		else if(p > 60 && p < 91)
			printf("D\n");
		else
			printf("G\n");
	}
	else if (a >= 1.20 && a < 1.71)
	{
			if(p >0 && p <61)
			printf("B\n");
		else if(p > 60 && p < 91)
			printf("E\n");
		else
			printf("H\n");
	}
	else
	{
			if(p >0 && p <61)
			printf("C\n");
		else if(p > 60 && p < 91)
			printf("F\n");
		else
			printf("I\n");
	}
	system("pause");
	return 0;
}