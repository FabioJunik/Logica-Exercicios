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
		printf("Digite um n�mero:");
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
	printf("A quantidades de n�meros digitados � %d\n",q);
	printf("A soma dos n�meros �: %d\n",s);
	printf("A media dos n�meros �: %.2f\n",med);
	printf("A media dos n�meros pares �: %.2f\n",medp);
	printf("O maior n�mero � %d\n",ma);
	printf("O menor n�mero � %d\n",me);
}