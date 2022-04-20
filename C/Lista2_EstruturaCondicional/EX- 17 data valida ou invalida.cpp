#include <stdio.h>
#include <stdlib.h>

 main()
 {
 	int ano, mes, dia;
 	system("color v3");
 	printf("Informe o dia, mes e o ano: ");
 	scanf("%d%d%d",&dia,&mes,&ano);
 	
 	if(dia <= 0 || dia >31 || mes <= 0 || mes>12 )
 	{
 		printf("\nData invalida\n");
 	}
 	else
 	{
 		if (mes==1 || mes==3 || mes==5 || mes==7 || mes==9 || mes ==11)
 		{
 			if(dia > 31)
 			{
 				printf("Data invalida\n");
 			}
 			else
 			{
 				printf("Data Valida\n");
 			}
 		}
 		if (mes==4 || mes==6 || mes==8 || mes==10 || mes==12)
 		{ 	
 			if (dia >30)
 			{
 			  printf("Data invalida\n");
 			}
 			else
 			{
 				printf("Data Valida\n");
 			}
 			
 		}
 		else
		{ 
		 	if(ano%4==0 || ano%400==0 && ano%100!=0)
 		 	{
 				if(mes==2 && dia>28)
 				{
 					printf("Data invalida\n");
 				}
 				else
 				{
 					printf("Data valida\n");
 				}
 			}
 			else 
 			{
 				if (mes==2 && dia >29)
 				{
 					printf("Data Invalida\n");
 				}
 				else
 				{
 					printf("Data valida\n");
 				}
			}
		}
 	}
 		
 	system ("pause");
 	
 }
