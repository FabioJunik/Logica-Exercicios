#include <stdio.h>
#include <stdlib.h>

int main()
{
	int x,y,z;
	char op;
	
	printf("Informe o valor de X, Y e Z:\n");
	scanf("%d%d%d",&x,&y,&z);
 	printf("(a) Geometrica\n");
 	printf("(b) Ponderada\n");
 	printf("(c) Harmonica\n");
 	printf("(d) Aritmetica\n");
	printf("Informe a opcao desejada\n");
 	scanf("%c",&op);
 	
 	switch(op)
 	{
		case 'b':
			printf("%.2f",(x+2*y+3*z)/6);	
        break;
    	case 'c':
    		printf("%.2f",1/(1/x+1/y*1/z));
 		break;
 		case 'd':
 			printf("%.2f",(x+y+z)/3);
    	break;
	    default :
    		printf("\n OPCAO INVALIDA\n");
 		break;

	}
	system("pause");
	return 0;
}