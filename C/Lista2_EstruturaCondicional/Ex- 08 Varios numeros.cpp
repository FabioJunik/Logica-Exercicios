#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n,c,s,sp,q,qp,ma,me;
	float medp,med;
	
	sp=0;
	s=0;
	qp=0;
	q=0;
	c=1;
	
	do
	{
		printf("Informe o %d numero",c);
		scanf("%d",&n);
		if(n==0)
			break;
		else{
		q=q+1;
		s=s+n;
		if(n%2==0)
		{
			qp=qp+1;
			sp=sp+n;
		}
		if(c==1)
			ma=me=n;
		if(n>ma)
			ma=n;
		if(n<me)
			me=n;
		c++;
		}
	}
	while(n!=0);
		
	printf("A quantidade de valores digitados foi de :%d\n ",q);
	printf("A soma dos valores digitado e:%d\n",s);
	med=s/q;
	printf("A media dos valores e:%.2f\n",med);
	printf("O maior numero digitado foi:%d\n",ma);
	printf("O menor numero digitado foi:%d\n",me);
	medp=sp/qp;
	printf("A media dos numeros pares e:%.2f\n",medp);
	system("pause");		
	return 0;
}