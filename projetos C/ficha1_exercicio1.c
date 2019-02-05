#include<stdio.h>
#include<stdlib.h>

int main(){
	int n1, n2, pro;
	printf("insira o primeiro numero\n");
	scanf("%d", &n1);
	printf("insira o segundo numero\n");
	scanf("%d", &n2);
	pro=n1*n2;
	printf("o produto de %d com %d e %d\n", n1, n2, pro);
	system("pause");
	return 0;
}

