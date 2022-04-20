#include <stdio.h>
#include <locale.h>

int main(int argc, char** argv)
{
	setlocale(LC_ALL,"portuguese");
	
	long int c,pr=1,a=0,r,s=0;
	
	for(;pr<4000000;)
	{
		r=pr+a;
		a=pr;
		pr=r;
		if(r%2==0)
		   	s=s+r;
	}
	printf("%d:\n ",s);
	
	return 0;
}