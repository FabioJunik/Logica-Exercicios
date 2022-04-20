#include <stdio.h>
#include <stdlib.h>

int main()
{
	int a,b,c,ma,me,m;
	 
 	printf("Informe os tres numeros: \n");
 	scanf("%d%d%d",&a,&b,&c);
 	
 	if (a > b && a > c)
	{
		ma = a;
	}
	else
	{
		if(b > a && b > c)
		{
			ma = b;
		}
		else
		{
			ma = c;
		}
	}	
	if (a < b && a < c)
	{
		me = a;
	}
	else
	{
		if(b < a && b < c)
		{
			me = b;
		}
		else
		{
			me = c;
		}	
		
	}	
		
	if (a != ma && a != me)
    {
		m= a;
	}
	else
	{
		if (b != ma && b != me)
		{
			m= b;
		}
		else
		{
			if(c != ma && c != me)
            {
				m =c;
			}
			
		}
	}
	printf("%d - %d - %d\n",me,m,ma);
	
	system("pause");
	
	return 0;
}