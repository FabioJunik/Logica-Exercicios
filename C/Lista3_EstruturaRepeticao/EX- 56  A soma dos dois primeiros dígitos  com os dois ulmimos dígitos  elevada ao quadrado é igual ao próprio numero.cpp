#include <stdio.h>
#include <locale.h>

int main(int argc, char** argv)
{
	setlocale(LC_ALL,"portuguese");
	
	int a,b,n;
	
	for(int c=1000;c<9999;c++)
	{
		a=c/100;
		b=c%100;
		n=(a+b)*(a+b);
		
		if(n==c)
			printf("%d\n",c);		
	}
	
	return 0;
}