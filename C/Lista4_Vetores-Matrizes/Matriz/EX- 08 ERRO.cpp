#include <stdio.h>
#include <locale.h>

int main(int argc, char** argv)
{
	setlocale(LC_ALL,"portuguese");
	char mat[5][5],r[5];
	int	p[5],q;
	
	for(int l=0;l<5;l++)
	{
		for(int c=0;c<5;c++)
		{
			printf("Qual é a %d resposta do %d aluno:\n",c+1,l+1);
			scanf("%c",&mat[l][c]);
		}
	}
	
	for(int l=0;l<5;l++)
	{
		printf("Qual é a resposta certa da %d questão:",l+1);
		scanf("%c",&r[l]);
	}
	
	for(int l=0;l<5;l++)
	{
		q=0;
		for(int c=0;c<5;c++)
		{
			if(mat[l][c]==r[c])
				q++;
		}
		p[l]=q++;
	}
	
	for(int c=0;c<5;c++)
		printf("A Nota do %d aluno é %d\n",c+1,p[c]);
	
	
	
return 0;
}