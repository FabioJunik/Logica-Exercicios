#include <stdio.h>
#include <stdlib.h>


	main()
{
	int vg,v1,v2,v3;
	int g1,g2,g3,t;
	
	
	printf ("Informe o quantia ganha\n");
	scanf("%d",&vg);
	printf("Informe a quantia dada por cada um dos jogadores\n");
	scanf("%i%d%i",&v1,&v2,&v3);
	t = v1+v2+v3;
	g1= (100*v1/t)*vg/100;
	g2= (100*v2/t)*vg/100;
	g3= (100*v3/t)*vg/100;
	printf("O 1%c jogador ficara com %d \n",167,g1);
	printf("O 2%c jogador ficara com %d \n",167,g2);
	printf("O 3%c jogador ficara com %d \n",167,g3);
	system("pause");
}
