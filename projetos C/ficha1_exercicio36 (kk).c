// kk. Elabore um programa que lê uma matrizes MAT de L e C colunas, preenchida com valores inteiros e insira a diagonal da matriz num vector VEC .
#include<stdio.h>
#include<stdlib.h>
int main (){
	int l, c, i, j;
	printf("quantas linhas tem a matriz quadrada?\n");
	scanf("%d", &l);
	int mat[l][l], vec[l];
	for(i=0; i<l; i++){
		for(j=0; j<l; j++){
			printf("insira o %d digito da %d linha:\n", j+1, i+1);
			scanf("%d", &mat[i][j]);
		}
	}
	printf("a diagonal desta matriz e:\n");
	for(i=0; i<l; i++){
		vec[i]=mat[i][i];
		printf("%d, ", vec[i]);
	}	
	system("pause");
	return 0;
}
