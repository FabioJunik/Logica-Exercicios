#include <stdio.h>
#include <stdlib.h>

int main()
{
	int code, ht,ch=0,cm=0,sb;
	float sl,meh,mem ,sh=0,sm=0;
	char se;
	
	do
	{
		printf("Informe o codigo:");
		scanf("%i",&code);
		if(code==99999)
			break;
		else
		{
			printf("O sexo:");
			scanf("%s",&se);
			printf("E o total de horas trabalhadas:");
			scanf("%i",&ht);
		
			sb = ht*30;
			if(se=='m')
			{
				sl= sb-(sb*10/100);
				ch= ch+1;
				sh= sh+sl;
			}
			else
			{
				sl= sb-(sb*5/100);
				cm= cm+1;
				sm= sm+sl;	
		    }
		
			printf("Codigo %d\nSalio Liquido=%.2f\nSalario Bruto=%d\n",code,sl,sb);
			printf("------------------------\n");
		}
	}
	while(code!=99999);
	meh = sh/ch;
	mem = sm/cm;
	printf("A media dos Salarios liquidos dos professores do sexo Masculino eh %.2f\n",meh);
	printf("E com sexo femenino eh %.2f",mem);
}