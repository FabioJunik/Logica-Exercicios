#include <stdio.h>
#include <locale.h>
main()
{
	int n,a=0,b=1,soma=0;
	
	printf("Digite um numero: ");
	scanf("%d",&n);
	 
 	printf("%d %d ",a,b);
 	while(soma<=n+1){
		 soma=a+b;
		 a=b;
		 b=soma;
		 printf("%d ",soma);
	 }
	
	 printf("\n");
}