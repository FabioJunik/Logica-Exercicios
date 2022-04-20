#include <stdio.h>
#include <locale.h>

int main(int argc, char** argv)
{
	setlocale(LC_ALL,"portuguese");
	int matr[3],nota[3],s=0;
	char res[3][10], gab[10];
	float p[3];
	
	
	for(int l=0;l<10;l++)
	{
		printf("Qual é a resposta certa da %d questão:",l+1);
		scanf("%c",&gab[l]);
	}
	printf("\n");
	for(int l=0;l<3;l++)	
	{
		printf("Qual é matriluca do %d aluno:",l+1);
		scanf("%d",&matr[l]);
		for(int c=0;c<10;c++)
		{
			printf("Qual foi a %d resposta do %d aluno:",c+1,l+1);
			scanf("%c",&res[l][c]);
			
			if(res[l][c]==gab[c])
				s++;
		}
		nota[l]=s;
		p[l]=nota[l]*7/10;
		s=0;
	}

	
	for(int l=0;l<3;l++)	
	{
		printf("\nAs respostas do %d aluno com a matricula de %d são :\n",l+1,matr[l]);
		for(int c=0;c<10;c++)
			printf("%c",res[l][c]);
		
		printf("\nNOTA = %d\n",nota[l]);
		printf("PERCENTUAL = %.2f\n",p[l]);
	}
	
	return 0;
}