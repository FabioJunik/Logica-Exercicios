#include<stdio.h>
#include<stdlib.h>
#include<locale.h>

main(){
	setlocale(LC_ALL,"portuguese");
	int n,f=1,i=0;
	
	do
	{
		printf("Digite um número:");
		scanf("%d",&n);
		f=1;
		if(n>0)
		{
			for(int c=1;c<=n;c++)
			f=f*c;
	
			printf("O factorial de %d é: %d\n",n,f);
		}
		if(n==0)
			printf("O factorial de 0 é 1\n");
		
		if(n%2==1)
			i++;
		else
			i=0;
	}while(i!=3);
	system("pause");
}