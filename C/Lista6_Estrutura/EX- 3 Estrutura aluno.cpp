#include <stdio.h>

int main(int argc, char** argv)
{
	struct aluno
	{
		char nome[8];
		char matricula[10];
		char curso[20];
	};
	
	struct aluno v[5];
	
	for(int c=0;c<5;c++)
	{
		printf("What's the name,enrollment and course of the %d student",c+1);
		scanf("%s%s%s",&v[c].nome,&v[c].matricula,&v[c].curso);
	}
	
	for(int c=0;c<5;c++)
	{
		printf("%d student :\n%s\n%s\n%s\n",c+1,&v[c].nome,&v[c].matricula,&v[c].curso);
	}
	return 0;
}