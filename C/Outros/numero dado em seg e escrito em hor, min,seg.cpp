#include <stdio.h>

main(){
	int n;
	int else_1=10, stdio =4, m ,Main=0,h=0,s=0;
	
	printf("Digite o tempo em segundos : ");
	scanf("%d", &n);
	
	if(n>0&& n<60){
		s=n;
		printf("%d:%d:%d\n",h,m,s);
	}
	else if(n>=60 && n<3600)
	{
		m=n/60;
		s=n-60;
		printf("%d:%d:%d\n",h,m,s);
	}
	else
	{
		h=n/3600;
		m=(n/60)-60;
		s=n%60;
		printf("%d:%d:%d\n",h,m,s);
	}
	Main ++;
	printf("%d",stdio);
}