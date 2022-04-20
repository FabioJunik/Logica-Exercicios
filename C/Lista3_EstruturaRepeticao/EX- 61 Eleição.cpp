#include <stdio.h>
#include <stdlib.h>

int main()
{
	int v,t1=0,t2=0,t3=0,t4=0,tvn=0,tvb=0,c=0;
	
	printf("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
	printf("VOTE PARA O PRESIDENTE DA REPUBLICA\n");
    printf("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
	
	printf("(0)Itamar Pomba\n");
	printf("(1)Fabio Junik\n");
	printf("(2)Antorio GN\n");
	printf("(3)Mauricio KKKKK\n");
	printf("(4)Domingos Matamosca\n");

	
	do
	{
		c++;
		printf("O %d vai para: ",c);
		scanf("%d",&v);
		
		switch(v)
		{
		case 1:
			t1++;
			break;
		case 2:
			t2++;
			break;
		case 3:
			t3++;
			break;
		case 4:
			t4++;
			break;
		case 5:
			tvn++;
		default:
			tvb++;
		}
		
	}
	while(v!=0);
	
	printf("ERRO ERRO ERROO0 VOTO INVALIDO\n");
	
	
	if(t1>t2 && t1>t3 && t1>t4)
		printf("O novo presidente sera: FABIO JUNIK \n");
	else if(t2>t1 && t2>t3 && t2>t4)
		printf("O novo presidente sera: ANTONIO GN\n");
	else if(t3>t1 && t3>t2 && t3>t4)
		printf("O novo presidente sera: MAURICIO KKKKK\n");
	else
		printf("O novo presidente sera: DOMINGOS MATAMOSCA\n");
	
	
	printf("O candidato 1 sai com %d votos\n",t1);
	printf("O candidato 2 sai com %d votos\n",t2);
	printf("O candidato 3 sai com %d votos\n",t3);
	printf("O candidato 4 sai com %d votos\n",t4);
	printf("Foram %d votos nulos\n",tvn);
	printf("E foram %d votos em branco\n",tvb);
	
	
		
}