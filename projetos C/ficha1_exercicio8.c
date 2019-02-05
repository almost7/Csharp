#include<stdio.h>
#include<stdlib.h>

int main(){
	int n1, uni, dez, cent;
	printf("insira um numero de 3 digitos\n");
	scanf("%d", &n1);
	uni=n1%10;
	dez=(n1/10)%10;
	cent=n1/100;
	printf("numero das centenas %d, das dezenas %d, das unidades %d\n", cent, dez, uni);
	system("pause");
	return 0;
}

