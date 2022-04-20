#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int h,cod;
	float con,kwh, ma,me,med,q,t1,t2,t3;
	
	printf("Informe o numero total de habitantes");
	scanf("%d",&h);
	printf("Informe o volor do kwh");
	scanf("%f",&kwh);
	q=0;
	t1=0;
	t2=0;
	t3=0;
	ma=0;
	me=0;
	for(int c=0;c<h;c++)
	{
		printf("Informe o consumo do mes e codigo do consumidor do habitante numero %d:",c+1);
		scanf("%f%d",&con,&cod);
		q = q+con;
		switch (cod)
		{
			case 1:
				t1=t1+con;
				break;
			case 2:
				t2=t2+con;
				break;
			case 3:
				t3=t3+con;
				break;
			default:
				printf("codigo invalido\n");
		}
		if (c==0)
			ma=me=con;
		if(con > ma)
			ma = con;
		if(con < me)
			me = con;	
	}
	med= q / h ;
	printf("O maior consumo foi :%.2f\n",ma);
	printf("O menor consumo foi :%.2f\n",me);
	printf("A media do consumo foi :%.2f\n",med);
	printf("O total de consumo da categoria 1 e :%.2f\n",t1);
	printf("O total de consumo da categoria 2 e :%.2f\n",t2);
	printf("O total de consumo da categoria 3 e :%.2f\n",t3);
	return 0;
}