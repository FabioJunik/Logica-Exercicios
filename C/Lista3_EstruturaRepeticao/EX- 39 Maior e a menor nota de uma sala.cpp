#include <stdio.h>
#include <locale.h>

main()
{
	int n,ma,me,a;
	
	setlocale(LC_ALL,"portuguese");
	
	printf("Quantos alunos a turma tem:");
	scanf("%d",&a);
	
	for(int c=1;c<=a;c++)
	{
		printf("Informe a %d nota",c);
		scanf("%d",&n);
		
		if(c==1)
			ma=me=n;
		if(ma<n)
			ma=n;
		if(me>n)
			me=n;
		if(c==a)
			printf("A Maior Nota é %d\nE A Menor Nota é %d",ma,me);
		
	}
}