//ff. Elabore um programa que dada uma matriz Q de L linhas e C colunas, preenchida com valores inteiros, indique se estamos na presença de uma matriz quadrada.
#include<stdio.h>
#include<stdlib.h>
int main (){
	int c, l;
	printf("quantas linhas tem a matriz?\n");
	scanf("%d",&l);
	printf("quantas colunas tem a matriz?\n");
	scanf("%d",&c);
	if(c==l)
		printf("a matriz e` quadrada.\n");	
	else
		printf("a matriz nao e` quadrada.\n");	
	system("pause");
	return 0;
}


