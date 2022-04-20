#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	float mat[3][6],si=0,s=0,med,a;
	
	for(int l=0;l<3;l++)
	{
		for(int c=0;c<6;c++)
		{
			printf("Informe o valor da posição[%d-%d]:",l,c);
			scanf("%f",&mat[l][c]);
			if(c%2==1)
				si=mat[l][c]+si;
			if(c==1 ||c==3)
				s=mat[l][c]+s;

			if(c==5)
				mat[l][c]=mat[l][1]+mat[l][2];
		}
	}
	med=s/6;
	
	printf("A soma de todos elementos da coluna impar é: %.2f\n",s);
	printf("A média dos elementos da 2 e 4 coluna é: %.2f\n",med);
	for(int l=0;l<3;l++)
	{
		for(int c=0;c<6;c++)
		{
			printf("%.1f  ",mat[l][c]);
		}
		printf("\n");
	}	
	
	return 0;
}