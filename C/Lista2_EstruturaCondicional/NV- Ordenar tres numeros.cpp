#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int a,b,c;
	
	printf("Informe o valor");
	scanf("%d%d%d",&a,&b,&c);
	
	if(a>b && b>c)
		printf("%d-%d-%d",c,b,a);
	else if (a>c && c>b)
		printf("%d-%d-%d",b,c,a);
	else if(b>c && c>a)
		printf("%d-%d-%d",a,c,b);
	else if(c>b && b>a)
		printf("%d-%d-%d",a,b,c);
	return 0;
	system("pause");
}
