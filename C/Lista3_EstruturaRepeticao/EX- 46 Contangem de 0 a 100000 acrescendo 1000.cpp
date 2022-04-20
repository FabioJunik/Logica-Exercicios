#include <stdio.h>
#include <locale.h>

int main(int argc, char** argv)
{
	setlocale(LC_ALL,"portuguese");
	
	for(int c=0;c<=100000;c+=1000)
		printf("%d\n",c);
	return 0;
}