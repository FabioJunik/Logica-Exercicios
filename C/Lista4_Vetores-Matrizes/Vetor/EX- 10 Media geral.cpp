#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	float n[15],s=0,med;
	
	for(int c=0;c<15;c++)
	{
		printf("Qual eh a nota do %d aluno",c+1);
		scanf("%f",&n[c]);
		s=s+n[c];
	}
	med=s/15;
 	
	printf("A media geral eh %.2f",med);
	
	return 0;
}