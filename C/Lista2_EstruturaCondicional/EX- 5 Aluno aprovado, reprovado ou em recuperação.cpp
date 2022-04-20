#include <stdio.h>
#include <stdlib.h>

int main()
{
	float n1,n2,n3,m;
	
	printf("Informe os valores das tr%cs notas\n",131);
	scanf("%f%f%f",&n1,&n2,&n3);
	m = (n1*2+n2*3+n3*5)/(2+3+5);
	printf("MEDIA FINAL: %.2f\n",m);
	if (m<2.9)
	{
		printf("ALUNO REPROVADO\n");
	}
	else
		if(m<=4.9 && m>= 3)
		{
			printf("ALUNO EM RECUPERACAO\n");
		}
	else
	{
		printf("ALUNO APROVADO\n");
	}
	system ("pause");
	return 0;
}

