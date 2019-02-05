#include<stdio.h>
#include<stdlib.h>

int main(){
	int n1, ant, suc;
	printf("insira um numero\n");
	scanf("%d", &n1);
	ant=n1-1;
	suc=n1+1;
	printf("o seu antecessor e o %d e o seu sucessor e o %d\n", ant, suc);
	system("pause");
	return 0;
}
