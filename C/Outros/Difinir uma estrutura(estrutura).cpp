#include <stdio.h>


int main()
{
	struct horario
	{
		int hora;
		int minuto;
		int segundo;
	};
	
	struct horario agora;
	
	agora.hora=15;
	agora.minuto=8;
	agora.segundo= 56;
	
	printf("%d:%d:%d\n",agora.hora,agora.minuto,agora.segundo);
	
	return 0;
}