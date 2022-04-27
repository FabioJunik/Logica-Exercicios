#include<stdio.h>
#include<stdlib.h>
#include<locale.h>

main(){
	setlocale(LC_ALL,"portuguese");
	
	int a=1,p=1,b=1;
	
	do{
		while(p <1000){
			p=(a*a+b*b)*2;
			b++;
		}
		b=1;
		a++;
		
	}while(p!=1000);
	
	printf("P =%d\n",p);
	printf("A =%d\n",a);
	printf("B =%d\n",b);
	printf("C= %d",a*a+b*b);
	system("pause");
}