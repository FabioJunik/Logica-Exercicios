#include <stdio.h>
#include <stdlib.h>

main(){
	int n, c=1;
	
	printf("Digite a quantidade das linhas :");
	scanf("%d",&n);
	
	for(int l=1;l<=n;l++){
		int i=1;
		while(i<=l)
		{
			printf("%d ",c);
			i++;
			c++;
		}
		printf("\n");
	}
	
}