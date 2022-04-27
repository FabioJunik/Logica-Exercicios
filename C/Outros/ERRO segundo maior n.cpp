#include <stdio.h>
#include <stdlib.h>

main(){
	int m1,n,m2,j=0;
	
	for(int c=0;c<5;c++){
		scanf("%d",&n);
		if(c==0)
		{		
			m1=n;
			m2=n;
		}
		else if(n>m1)
		{		
			m1=n;
		}
	    if(m2>n && j==0)
		{
			m2=n;
			j=1;
		}
		else if(n!=m1 && n>m2)
			m2=n;
	}
	
	printf("m1=%d\nm2=%d\n",m1,m2);
}




