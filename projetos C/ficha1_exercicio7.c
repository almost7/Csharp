#include<stdio.h>
#include<stdlib.h>

int main(){
	float n1, n2, troco;
	printf("valor a pagar\n");
	scanf("%f", &n1);
	printf("valor pago pelo cliente\n");
	scanf("%f", &n2);
	troco=n2-n1;
	printf("valor a devolver ao cliente descontando gorjeta e %.2f euros\n", troco*0.9);
	system("pause");
	return 0;
}

