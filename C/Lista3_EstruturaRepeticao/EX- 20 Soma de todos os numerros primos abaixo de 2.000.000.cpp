#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	int q;
    int s=0;
	
	for(int r=1;r<=20;r++)
	{
		q=0;
		for(int u=1;u <=r;u++)
		{
			if(r%u==0)
				q=q+1;
		}
		if(q==2)
			s=s+r;
	}
	printf("%d",s);
	return 0;
	system("pause");
}