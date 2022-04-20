#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int a, m , me;
	
	
	printf("Informe um numero");
	scanf("%d",&a);
	m =a;
	me=a;
	while(a!=0) 
	{
		printf("Informe um numero");
		scanf("%d",&a);
		if(a > m )
			m =a;
		if(a!=0)
		{
			if(a < me)
				me = a;
		}
	}
	printf("o maior:%d\n",m );
	printf("o menor:%d\n",me);
	system ("pause");
	return 0;
}