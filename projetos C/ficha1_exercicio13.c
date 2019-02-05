#include<stdio.h>
#include<stdlib.h>

int main(){
	int n;
	do{
	printf("insira um numero entre 1 e 7\n");
	scanf("%d", &n);
	}
	while (n <1 || n>7);
	switch (n){
	case 1:
		printf("Domingo\n");
		break;
	case 2:
		printf("Segunda\n");
		break;
	case 3:
		printf("Terca\n");
		break;
	case 4:
		printf("Quarta\n");
		break;
	case 5:
		printf("Quinta\n");
		break;
	case 6:
		printf("Sexta\n");
		break;
	case 7:
		printf("Sabado\n");
		break;
	default:
		printf("numero incorreto\n");			
	}
	system("pause");
	return 0;
}
