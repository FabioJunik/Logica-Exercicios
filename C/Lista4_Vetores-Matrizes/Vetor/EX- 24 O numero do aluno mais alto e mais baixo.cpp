#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

main()
{
	int n[10],pma,pme;
	float h[10],ma,me;
	
	setlocale(LC_ALL,"portuguese");
	
	for(int c=0;c<10;c++)
	{
		printf("Informe o n�mero e a altura do %d aluno:\n",c+1);
		scanf("%d%f",&n[c],&h[c]);
	}
	ma=me=h[0];
	for(int c=0;c<10;c++)
	{
		if(h[c]>ma)
		{
			ma=h[c];
			pma=n[c];
		}
		if(h[c]<me)
		{
			me=h[c];
			pme=n[c];
		}
	}
	
	printf("O n�mero do aluno mais alto � %d e a sua altura � %.2f\n",pma,ma);
	printf("O n�mero do aluno mais baixo � %d e a sua altura � %.2f\n",pme,me);
}