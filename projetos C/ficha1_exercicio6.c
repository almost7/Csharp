#include<stdio.h>
#include<stdlib.h>

int main(){
	float valor, final;
	printf("insira o valor sem IVA\n");
	scanf("%f", &valor);
	final=valor*1.25;
	printf("tem a pagar %.2f ja com IVA a 25\n", final);
	system("pause");
	return 0;
}

