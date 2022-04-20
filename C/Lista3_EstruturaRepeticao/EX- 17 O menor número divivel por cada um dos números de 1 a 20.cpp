#include <stdio.h>
#include <locale.h>

int main(int argc, char** argv)
{
	setlocale(LC_ALL,"portuguese");
	
	int k=0,q,c;
	
	do
	{
		c=1;
		q=0;
		k++;	
		while(c<21)
		{
			if(k%c==0)
		  	   	q++;	   			
		   	c++;
		}
	}
	while(q!=20);	
	
	printf("O menor número divivel por cada um dos números de 1 a 20 é %d\n",k);
	return 0;
}