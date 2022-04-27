#include <stdio.h>
#include <locale.h>


main()
{
	setlocale(LC_ALL,"portuguese");
	float SomaDosNumeros(float n1,float n2);
	
	float a,b,soma;
	
	printf("Digite dois números:");
	scanf("%f%f",&a,&b);
	
	soma=SomaDosNumeros(a,b);
	printf("A soma é :%f",soma);
}

float SomaDosNumeros(float n1,float n2)
{
	float absoluto(float x);
	
	if(n1<0)
		n1=absoluto(n1);
	if(n2<0)
		n2=absoluto(n2);
	
	return n1+n2;
}

float absoluto(float x)
{
	return x*-1;
}