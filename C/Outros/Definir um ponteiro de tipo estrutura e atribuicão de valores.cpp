#include <stdio.h>


int main(int argc, char** argv)
{
	
	struct horario
	{
		int hora;
		int min;
		int seg;
	};
	
	struct horario agora,*depois;
	
	depois=&agora;
	
	depois->hora=14;
	depois->min=45;
	depois->seg=0;
	
	printf("%d:%d:%d\n",agora.hora,agora.min,agora.seg);
	return 0;
}