#include <stdio.h>

int main(int argc, char** argv)
{
	struct alunos
	{
		char nome[10];
		char matricula[10];
		float n1;
		float n2;
		float n3;
	};
	
	struct alunos a[5][5];
	
	for(int k=0;k<5;k++)
	{
		printf("Enter the name,enrollment, grade1, grade2 and grade 3 of the %d student\n",k+1);
		for(int j=0;j<5;j++)
		{		
			if(j==0)
			{
				printf("Enter the name of the %d student",k+1);
				scanf("%s",&a[k][j].nome);
			}
			if(j==1)
			{
				printf("Enter the enrollment");
				scanf("%s",&a[k][j].matricula);
			}
			if(j==2)
			{
				printf("Enter the grade 1");
				scanf("%f",&a[k][j].n1);
			}			
			if(j==3)
			{
				printf("Enter the grade 2");
				scanf("%f",&a[k][j].n2);
			}			
			if(j==4)
			{
				printf("Enter the grade 3");
				scanf("%f",&a[k][j].n3);
			}			
		}
	}
	float maior,med[5],mamed,memed;
	
	maior=a[0][2].n1;
	mamed=memed=med[0]=(a[0][2].n1+a[0][3].n2+a[0][4].n3)/3;
	
	
	for(int k=0;k<5;k++)
	{
		if(a[k][2].n1>maior)
			maior=a[k][2].n1;
		
		med[k]=(a[k][2].n1+a[k][3].n2+a[k][4].n3)/3;
		
		if(med[k]>mamed)
			mamed=med[k];
		if(med[k]<memed)
			memed=med[k];
	}
	
	
	for(int k=0;k<5;k++)
	{
		printf("%d student\n",k+1);
		for(int j=0;j<5;j++)
		{		
			if(j==0)
			{
				printf("%s\n",&a[k][j].nome);
			}
			if(j==1)
			{
				printf("%s\n",&a[k][j].matricula);
			}
			if(j==2)
			{
				printf("%.2f\n",&a[k][j].n1);
			}			
			if(j==3)
			{
				printf("%.2f\n",&a[k][j].n2);
			}			
			if(j==4)
			{
				printf("%.2f\n",&a[k][j].n3);
			}			
		}
		if(med[k]>=6)
			printf("ALUNO: APROVADO\n");
		else
			printf("ALUNO: REPROVADO\n");
	}
		

	return 0;
}