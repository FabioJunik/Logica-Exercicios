#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int n,c=1,ma,me,s=0,q=0,sp=0,qp=0;
	float med,medp;
	
	
	do
	{
		printf("Digite um número:");
		scanf("%d",&n);
		
		if(n!=0)
		{
			q++;
			s=s+n;
			if(n%2==0)
			{
				sp=sp+n;
				qp++;
		    }	
			if(c==1)
				ma=me=n;
			if(n>ma)
				ma=n;
			if(n<me)
				me=n;
		}	
		c++;
	}
	while(n!=0);
	
	med=s/q;
	medp=sp/qp;
	printf("A quantidades de números digitados é %d\n",q);
	printf("A soma dos números é: %d\n",s);
	printf("A media dos números é: %.2f\n",med);
	printf("A media dos números pares é: %.2f\n",medp);
	printf("O maior número é %d\n",ma);
	printf("O menor número é %d\n",me);
}