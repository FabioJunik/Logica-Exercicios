#include <stdio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");

	int  v[10]={5,1,3,9,0,7,2,4,8,6};
	
	void ordenar(int m[],int n);
	
	ordenar(v,10);
	
	for(int i=0;i<10;i++)
	{
		printf("%d",v[i]);
	}	
	return 0;
}

void ordenar(int m[],int n)
{
	int a;
	for(int i=0;i<9;i++)
	{
		for(int j=i+1;j<10;j++)
		{
			if(m[i]>m[j])
			{
				a=m[i];
				m[i]=m[j];
				m[j]=a;
			}
		}
	}
}