#include <stdio.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL,"portuguese");
	int h,m,s,dh,dm,ds;
	
	printf("Informe a hora de inicio:");
	scanf("%d",&h);
	printf("Minuto:");
	scanf("%d",&m);
	printf("Segundo:");
	scanf("%d",&s);
	
	printf("Informe o tempo de duração:\n");
	printf("Hora:");	
	scanf("%d",&dh);
	printf("Minuto:\n");
	scanf("%d",&dm);
	printf("Segundo:");
	scanf("%d",&ds);
	
	printf("A experiencia ira terminar as %d:%d:%d\n",h+dh,m+dm,s+ds);
	
}