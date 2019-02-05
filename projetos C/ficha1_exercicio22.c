#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, contador=0, soma=0;
	while (contador<5 || soma<100){
		printf("insira um numero inteiro\n");
		scanf("%d", &n);
		contador++;
		soma=soma+n;
	}
	printf("terminou a leitura\n");
	system("pause");
	return 0;
}
