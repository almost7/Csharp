#include<stdio.h>
#include<stdlib.h>

int main(){
	int eC, idade;
	printf("qual o estado civil? insira 0 para solteiro ou 1 para casado\n");
	scanf("%d",&eC);
	printf("qual a idade?\n");
	scanf("%d",&idade);
	switch (eC){
		case 0:
			if(idade <25)
				printf("Grupo 1\n");
			else
				printf("Grupo 2\n");
			break;
		case 1:
			if(idade <34)
				printf("Grupo 2\n");
			else
				printf("Grupo 4\n");		
			break;
		default:
			printf("Outro\n");
	}
	system("pause");
	return 0;
}

