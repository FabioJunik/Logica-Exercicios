#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	int p,mat[5][4],ma,s=0;
	float med;
	
	for(int c=0;c<3;c++)
	{
		for(int l=0;l<5;l++)
		{
			if(c==0 && l==0)
				printf("Preenchendo a primeira coluna com o número de matricula:\n");
			if(c==1 && l==0)
				printf("Preenchendo a segunda coluna com a media das provas:\n");
			if(c==2 && l==0)
				printf("Preenchendo a terceira coluna com a média dos trabalhos:\n");
				
			printf("%d aluno:",l+1);
			scanf("%d",&mat[l][c]);
			
		}
	}
	
	for(int l=0;l<5;l++)
	{
		mat[l][3]=mat[l][2]+mat[l][1];
		s=s+mat[l][3];
	}
	
	ma=mat[0][3];
	p=mat[0][0];
	
	for(int l=0;l<5;l++)
	{
		if(ma < mat[l][3])
		{
			ma=mat[l][3];
			p=mat[l][0];
		}
	}	
	
	med=s/5;
	printf("A Média aritmetrica das notais finas é: %f\n",med);
	printf("O número da matricula do aluno com a maior nota final é %d\n",p);
	
	
	return 0;
}