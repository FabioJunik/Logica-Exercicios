#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	char palavra1[]={'F','i','c','a',' '};
	char palavra2[]={'E','m',' '};
	char palavra3[]={'C','a','s','a'};
		
	char novapalavra[12];	
		
	void concatenar(char palavra1[],char palavra2[],char palavra3[],char novapalavra[]);	

	concatenar(palavra1,palavra2,palavra3,novapalavra);
	
	for(int c=0;c<12;c++)
		printf("%c ",novapalavra[c]);
	
	printf("\n");

	return 0;	
}

void concatenar(char palavra1[],char palavra2[],char palavra3[],char novapalavra[])
{
	for(int c=0;c<5;c++)
		novapalavra[c]=palavra1[c];
	for(int c=0,n=5;c<3;c++,n++)
		novapalavra[n]=palavra2[c];
	for(int c=0,n=8;c<4;c++,n++)
		novapalavra[n]=palavra3[c];
}