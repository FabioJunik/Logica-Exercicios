#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int n;
	
	printf("Digite um numero:\n");
	scanf("%d",&n);
	
	if (n%3==0 && n%5==0)
		printf("O nemero nao pode ser divisivel simultaniamente por 3 e 5 \n");
	else if( n % 3==0)
		printf("E divisivel por 3\n");
 		else if(n % 5==0)
			printf("E divisivel por 5\n");
	system("pause");
	return 0;
}