#include<stdio.h>
#include<stdlib.h>
#include<string.h>
main(){
	int n1,n2;
	int p;
	int d1,d2,d3,d4,d5,d6;
	
	for(int c=100;c<=999; c++){
		for(int f=100;f<=999;f++){
			int m;
			m= c*f;
			if(m <=99999)
			{
				d1=m%10;
				d2=(m/10)%10;
				d3=(m/100)%10;
				d4=(m/1000)%10;
				d5=(m/10000)%10;
				if(d1==d5 && d2==d4){
					n1=c;
					n2=f;
					p=m;
				}
			}
			else
			{
				
				d1=m%10;
				d2=(m/10)%10;
				d3=(m/100)%10;
				d4=(m/1000)%10;
				d5=(m/10000)%10;
				d6=(m/100000)%10;
				if(d1==d6 && d2==d5 && d3==d4 ){
					n1=c;
					n2=f;
					p=m;
				}
			}
		}
	}
	
	printf("%d * %d= ",n1,n2);
	printf(" %d\n",p);
}