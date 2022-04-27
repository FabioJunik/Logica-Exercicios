#include <stdio.h>
#include <locale.h>


struct horario
{
	int hora;
	int min;
	int seg;
};

int main()
{
	setlocale(LC_ALL,"portuguese");
	

	struct horario vect[5];
	void receber(struct horario v[]);
	void escrever(struct horario v[]);
	
	receber(vect);
	escrever(vect);
	
	return 0;
}

void receber(struct horario v[])
{
	for(int i=0;i<5;++i)
	{
		printf("Informe o %d horario(hh:mm:ss):",i+1);
		scanf("%d:%d:%d",&v[i].hora,&v[i].min,&v[i].seg);
	}
}
void escrever(struct horario v[])
{
	for(int i=0;i<5;i++)
		printf("O %d horario é %d:%d:%d\n",i+1,v[i].hora,v[i].min,v[i].seg);
}