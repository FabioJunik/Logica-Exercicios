#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	
	int fatorial(int x);
	
	int n,res;
	
	printf("Digite um número:");
	scanf("%d",&n);
	
	res=fatorial(n);
	
	printf("O fatorial de %d é %d\n",n,res);
	return 0;
}

int fatorial(int x)
{
	int res;
	if(x==0)
		res=1;
	else
		res=x *fatorial(x-1);

	return res;
}