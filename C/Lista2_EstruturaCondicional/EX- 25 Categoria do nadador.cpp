#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int I;
	
	printf("Informe a idade do nadador\n");
	scanf("%d",&I);	
	printf("Voce pertence a categoria ");
	
	switch(I)
	{
	case 5 ... 7:
		printf("Infantil A\n");
		break;
	case 8 ... 10:
		printf("Infantil B\n");
		break;
	case 11 ... 13:
		printf("Juvenil A\n");
		break;
	case 14 ... 17:
		printf("Juvenil B\n");
		break;
	case 18 ... 75:
		printf("Senior\n");
		break;
	default:
		printf("Com esta idade nao pode nadar");
		break;
	}
	return 0;
	system("pause");
}