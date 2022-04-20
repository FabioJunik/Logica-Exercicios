#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int code,q;
	
	system("color 70");
	printf("--------------MENU------------\n");
	printf("| Especificacao |Codigo|preco|\n");
	//printf("------------------------------\n")
	printf("|Cachorro quente|  100 | 1.20|\n");
	printf("| Bauru Simples |  101 | 1.30|\n");
	printf("| Bauru com ovo |  102 | 1.50|\n");
	printf("|  Humburguer   |  103 | 1.20|\n");
	printf("| Cheeseburguer |  104 | 1.70|\n");
	printf("|      Suco     |  105 | 2.20|\n");
	printf("| Refrigerante  |  106 | 1.00|\n");
	printf("------------------------------\n");
	printf(" Informe o codigo e a quantidade :\n");
	scanf("%d%d",&code,&q);
	printf("O preco a pagar sera :\n");
	switch(code)
	{
	case 100:
		printf("%.2f",(1.20*q));
		break;
	case 101:
		printf("%.2f",(1.30*q));
		break;
	case 102:
		printf("%.2f",(1.50*q));
		break;
	case 103:
		printf("%.2f",(1.20*q));
		break;
	case 104:
		printf("%.2f",(1.70*q));
		break;
	case 105:
		printf("%.2f",(2.20*q));
		break;
	case 106:
		printf("%.2f",(1.00*q));
		break;
	default:
		printf("Codigo invalido");
		break;
	}
	
	return 0;
	system("pause");
}