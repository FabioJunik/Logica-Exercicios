#include <stdio.h>
#include<stdlib.h>
main(){
	 int n,s=0,m=0,h=0;
	
	 printf("Digte o numero em segundos: ");
	 scanf("%d",&n);
	 
	 if(n<60)
	 	printf("%d:%d:%d",h,m,n);
	 else if(n>=60 && n<3600)
	 {
		 m=n/60;
		 s=n%60;
		 printf("%d:%d:%d",h,m,s);
	 }
	 else if(n>=3600)
	 {
	 	h=n/3600;
	 	m=(n%3600)/60;
	 	s=(n%m);
	 	printf("%d:%d:%d",h,m,s);
	 }
	 	
}