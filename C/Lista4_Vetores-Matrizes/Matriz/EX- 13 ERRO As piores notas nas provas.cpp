#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	float mat[10][3],me;
	int n;
	
	for(int l=0;l<3;l++)
	{
		for(int c=0;c<10;c++)
		{
			printf("Informe a nota da %d do %d aluno:",l+1,c+1);
			scanf("%f",&mat[l][c]);
		}
		printf("-------------------------------------\n");
	}
	
	for(int l=0;l<3;l++)
	{
		me=mat[l][0];
		n=0;
		for(int c=0;c<10;c++)
		{
			if(mat[l][c]<me)
			{
				me=mat[l][c];
				n=c;
			}
		}
		printf("----------------------------------\n");
		printf("A pior nota da %d foi do aluno %d\n",l+1,n+1);
	}
	
	return 0;
}