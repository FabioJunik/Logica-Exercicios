#include <stdlib.h>
#include <stdio.h>

int main()
{
	int a,b,c,d,e,f ;
    unsigned long int m ,n ;
	
	for(int j=100; j <= 999; j++)
	{
		for(int k=100; k <=999; k++)
		{
			m = j * k;
			n= m ;
			if( m <= 99999)
			{
				a= n/10000;
				n= n%10000;
				b= n/1000;
				n= n%1000;
				c= n/100;
				n= n%100;
				e= n%10;
				d= n/10;
				if(a==e && b==d)
					printf("%d\n",m );
			}
			else 
			{
					
				a= n/100000;
				n= n%100000;
				b= n/10000;
				n= n%10000;
				c= n/1000;
				n= n%1000;
				d= n/100;
				f= n%10;
				n= n%100;
				e= n/10;
				if(a==f && b==e && c==d)
					printf("%d\n",m );
				
			}	
			
		}
	}
	return 0;
}