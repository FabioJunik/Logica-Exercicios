#include <stdio.h>


int main(int argc, char** argv)
{
	struct funcionario 
	{
		char nome[10];
		int idade;
		char sexo;
		char data[10];
		int codigo;
		char cargo[30];
		float salario;
	};
	
	struct funcionario f;
	
	printf("Qual é o nome do funcionario:");
	scanf("%s",&f.nome);
	
	printf("Idade:");
	scanf("%d",&f.idade);
	
	printf("Sexo:");
	scanf("%c",&f.sexo);
	
	printf("Data de nascimento[dd/mm/aa]:");
	scanf("%s",&f.data);
	
	printf("Codigo do setor onde trabalha:");
	scanf("%d",&f.codigo);
	
	printf("Cargo que ocupa:");
	scanf("%s",&f.cargo);
	
	printf("E seu salario:");
	scanf("%f",&f.salario);
	

	
	printf("Qual é o nome do funcionario: %s\n",f.nome);
	
	printf("Idade: %d\n",f.idade);
	
	printf("Sexo: %c\n",f.sexo);
	
	printf("Data de nascimento[dd/mm/aa]: %s\n",f.data);
	
	printf("Codigo do setor onde trabalha: %d\n",f.codigo);
	
	printf("Cargo que ocupa: %s\n",f.cargo);
	
	printf("E seu salario: %.2f\n",f.salario);
	
			
	return 0;
}