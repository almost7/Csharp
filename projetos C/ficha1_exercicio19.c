#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, contador=0, soma=0;
	printf("insira um numero, para terminar insira o numero 0\n");
	scanf("%d", &n);
	while (n !=0){
		contador++;
		soma=soma+n;
		printf("insira um numero, para terminar insira o numero 0\n");
		scanf("%d", &n);
	}
	printf("a soma dos numeros inseridos e %d e a media e %d\n", soma, soma/contador);
	system("pause");
	return 0;
}
