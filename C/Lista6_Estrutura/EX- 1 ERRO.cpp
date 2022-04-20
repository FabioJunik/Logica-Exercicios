#include <stdio.h>


int main(int argc, char** argv)
{
	struct horario
	{
		int hora;
		int min;
		int seg;   	
	};
	
	struct data
	{
		int dia;
		char mes[10];
		int ano;
	};
	
	struct compromisso
	{
		struct data ndata;
		struct horario nhorario;
		

		char mens[20];
	};
	
	struct horario h;
	struct data d;
	struct compromisso c;
	
	printf("Difine the first time(hh:mm:ss): ");
	scanf("%d:%d:%d",&h.hora,&h.min,&h.seg);
	
	printf("Difine the first date(dd/mm/aa):");
	scanf("%d%s%d",&d.dia,&d.mes,&d.ano);
	
	printf("-----YOUR COMMITMENT--------\n");
	
	printf("Difine the date of your commitment(dd/mm/aa):");
	scanf("%d%d%d",&c.di,&c.m,&c.a);
	
	printf("Difine the time of your commitment(hh:mm:ss): ");
	scanf("%d:%d:%d",&c.h,&c.m,&c.s);
	printf("What's your commitment");
	printf("%s",&c.mens);
	
	return 0;
}