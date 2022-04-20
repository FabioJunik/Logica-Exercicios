#include <stdio.h>
#include <stdlib.h>

int main()
{
	int v,c100=0,c50=0,c20=0,c10=0,c5=0,c2=0,c1=0;
	
	printf("Qual e o valor que o senhor quer destrocar? :");
	scanf("%d",&v);
	
	do
	{
		if(v>99)
		{
			v =v-100;
			c100++;
		}
		else if(v>49)
        {
			v =v-50;
			c50++;
		}
		else if(v>19)
        {
			v =v-20;
			c20++;
		}
		else if(v>9)
        {
			v =v-10;
			c10++;
		}
		else if(v>4)
        {
			v =v-5;
			c5++;
		}
		else if(v>1)
        {
			v =v-2;
			c2++;
		}
		else
        {
			v =v-1;
			c1++;
		}		
		
	}
	while(v!=0);

	printf("Para destrocar o valor do senhor seram necessarias :\n");
	printf("%d notas de 100\n",c100); 
	printf("%d notas de 50\n",c50);
	printf("%d notas de 20\n",c20);
	printf("%d notas de 10\n",c10);
	printf("%d notas de 5\n",c5);
	printf("%d notas de 2\n",c2);
	printf("%d notas de 1\n",c1);

	return 0;
}