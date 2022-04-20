#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
	int op,n1,n2;
	
	printf("Informe dois números\n");
	scanf("%d%d",&n1,&n2);
	printf("ESCOLHA UMA DAS OPCOES\n");
	printf("--------------------------------\n");
	printf("1- Soma de 2 numeros\n");
	printf("2- Diferença entre 2 numeros\n");
	printf("3- Produto entre 2 numeros\n");   	
	printf("4- Divisao de 2 numeros\n");
	scanf("%d",&op);
	if (op==1)
	{
		printf("A soma dos dois numeros =%d\n", n1+n2);
	}	
	else
    {
    	if (op==2)
		{
			printf("A diferença é %d\n",n1-n2);
	    }
		else
		{
			if(op==3)
			{
                printf("O produto dos 2 numeros =%d\n ",n1*n2);	
				system("color 70"); 
	  	    }	
			else
			{	
				if(op == 4)
				{ 
					if(n2 != 0)
			   	   		printf("a divisao sera %.2f\n", n1/n2);
			   	   	else
						  {
							  printf("E impossivel dividir\n");
						  }
				}
				else
				{
					printf("Numero invalido \n");
				}
			}
	
		}	
	} 	
	system("Pausa");
	return 0;
}