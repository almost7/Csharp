#include<stdio.h>
#include<stdlib.h>

int main(){
	int n1;
	printf("insira um numero\n");
	scanf("%d", &n1);
	if (n1%2==0){
		printf("o numero e par\n");
	}
	else{
		printf("o numero e impar\n");
	}
	system("pause");
	return 0;
}

