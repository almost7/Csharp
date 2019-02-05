#include<stdio.h>
#include<stdlib.h>

int main(){
	int n1, n2, div;
	printf("insira o primeiro numero\n");
	scanf("%d", &n1);
	printf("insira o segundo numero\n");
	scanf("%d", &n2);
	div=n1/n2;
	printf("a divisao entre os dois numeros e %d\n", div);
	system("pause");
	return 0;
}
