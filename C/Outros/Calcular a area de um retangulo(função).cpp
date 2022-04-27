#include <stdio.h>

main()
{
	float CalcularAriaRetan( float altura,float base);
	
	float area=CalcularAriaRetan( 20.0,10.0);
	
	printf("A Area do retangulo eh: %f\n",area);
}

float CalcularAriaRetan( float altura,float base)
{
	float area=base*altura;
	
	return area;
}