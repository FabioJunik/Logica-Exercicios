#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	float s;
	int tt;
	
	printf("Informe o salario actual");
	scanf("%f",&s);
	printf("Ïnforme o tempo de trabalho");
	scanf("%d",&tt);
	
	if(s>0 && s<=500)
	{
		if(tt<1)
			printf("o salario rejustado sem bonus sera :%.2f\n",(s*25/100)+s);
		else if(tt >=1 && tt<4)
			printf("o salario rejustado com bonus de 100 sera :%.2f\n",(s*25/100)+s+100);
		else if(tt >=4 && tt<7)
			printf("o salario rejustado com bonus de 200 sera :%.2f\n",(s*25/100)+s+200);
		else if(tt >=7 && tt<11)
			printf("o salario rejustado com bonus de 300 sera :%.2f\n",(s*25/100)+s+300);
		else if(tt > 10)
			printf("o salario rejustado com bonus de 500 sera :%.2f\n",(s*25/100)+s+500);
	}
	else if(s>500 && s<=1000)
	{
		if(tt<1)
			printf("o salario rejustado sem bonus sera :%.2f\n",(s*20/100)+s);
		else if(tt >=1 && tt<4)
			printf("o salario rejustado com bonus de 100 sera :%.2f\n",(s*20/100)+s+100);
		else if(tt >=4&&tt <7)
			printf("o salario rejustado com bonus de 200 sera :%.2f\n",(s*20/100)+s+200);
		else if(tt >=7 && tt<11)
			printf("o salario rejustado com bonus de 300 sera :%.2f\n",(s*20/100)+s+300);
		else if(tt > 10)
			printf("o salario rejustado com bonus de 500 sera :%.2f\n",(s*20/100)+s+500);
	}
	else if(s>100 && s<=1500)
	{
		
		if(tt<1)
			printf("o salario rejustado sem bonus sera :%.2f\n",(s*15/100)+s);
		else if(tt >=1 && tt<4)
			printf("o salario rejustado com bonus de 100 sera :%.2f\n",(s*15/100)+s+100);
		else if(tt >=4 && tt<7)
			printf("o salario rejustado com bonus de 200 sera :%.2f\n",(s*15/100)+s+200);
		else if(tt >=7 && tt<11)
			printf("o salario rejustado com bonus de 300 sera :%.2f\n",(s*15/100)+s+300);
		else if(tt > 10)
			printf("o salario rejustado com bonus de 500 sera :%.2f\n",(s*15/100)+s+500);
	}
	else if(s>1500 && s<=2000)
	{
		
		if(tt<1)
			printf("o salario rejustado sem bonus sera :%.2f\n",(s*10/100)+s);
		else if(tt >=1 && tt<4)
			printf("o salario rejustado com bonus de 100 sera :%.2f\n",(s*10/100)+s+100);
		else if(tt >=4 && tt<7)
			printf("o salario rejustado com bonus de 200 sera :%.2f\n",(s*10/100)+s+200);
		else if(tt >=7 && tt<11)
			printf("o salario rejustado com bonus de 300 sera :%.2f\n",(s*10/100)+s+300);
		else if(tt > 10)
			printf("o salario rejustado com bonus de 500 sera :%.2f\n",(s*10/100)+s+500);
	}
	else if(s>2000)
	{
		
		if(tt<1)
			printf("o salario sem reajuste e sem bonus sera :%.2f\n",s);
		else if(tt >=1 && tt<4)
			printf("o salario sem rejuste com bonus de 100 sera :%.2f\n",s+100);
		else if(tt >=4 && tt<7)
			printf("o salario sem rejuste com bonus de 200 sera :%.2f\n",s+200);
		else if(tt >=7 &&tt <11)
			printf("o salario sem rejuste com bonus de 300 sera :%.2f\n",s+300);
		else if(tt > 10)
			printf("o salario sem rejuste com bonus de 500 sera :%.2f\n",s+500);
	}
	system("pause");
	return 0;
}