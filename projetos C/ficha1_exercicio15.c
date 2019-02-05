#include<stdio.h>
#include<stdlib.h>

int main(){
	int cargo;
	float salario, aumento;
	printf("qual o codigo do seu cargo?\n");
	scanf("%d", &cargo);
	printf("qual o seu salario?\n");
	scanf("%f", &salario);
	switch (cargo){
	case 101:
		aumento=salario*0.25;
		break;
	case 102:
		aumento=salario*0.2;
		break;
	case 103:
		aumento=salario*0.15;
		break;
	default:
		aumento=salario*0.1;				
	}
	printf("recebe %.2f euros e tera um aumento de %.2f euros passando a receber %.2f euros.\n", salario, aumento, salario+aumento);
	system("pause");
	return 0;
}
