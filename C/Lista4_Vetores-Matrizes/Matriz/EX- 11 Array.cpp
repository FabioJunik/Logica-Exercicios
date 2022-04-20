#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	
	void  array(int v[],int mat[3][3]);
	
	int mat[3][3],v[3];
	
	for(int l=0;l<3;l++)
	{
		for(int c=0;c<3;c++)
		{
			printf("Informe o valor da posição[%d-%d]:",l,c);
			scanf("%d",&mat[l][c]);
		}
	}
	
	array(v,mat);
	
	for(int c=0;c<3;c++)
		printf("%d:",v[c]);
	printf("\n");
	return 0;
}

void  array(int v[],int m[][3])
{
	int s=0;
	
	for(int l=0;l<3;l++)
	{
		for(int c=0;c<3;c++)
			s=s+m[c][l];
		v[l]=s;
		s=0;
	}	
}