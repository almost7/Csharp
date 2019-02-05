//gg. Elabore um programa que lê duas matrizes, A e B, de LA e LB linhas e CA e CB colunas, respetivamente, cada uma preenchida com valores inteiros e insira o resultado da soma das matrizes A e B numa nova matriz C.
#include<stdio.h>
#include<stdlib.h>
int main (){
	int l1, l2, c1, c2, i, j;
	do{
	printf("para que se possam somar matrizes o numero de colunas e linhas tem que ser iguais nas duas!\n");	
	printf("quantas linhas tem a matriz 1?\n");
	scanf("%d", &l1);
	printf("quantas linhas tem a matriz 2?\n");
	scanf("%d", &l2);
	printf("quantas colunas tem a matriz 1?\n");
	scanf("%d", &c1);
	printf("quantas colunas tem a matriz 2?\n");
	scanf("%d", &c2);
	}while (l1!=l2 || c1!=c2);
	int matA[l1][c1], matB[l2][c2], matC[l1][c1];
	printf("para a primeira matriz:\n");
	for(i=0; i<c1; i++){
		for(j=0; j<c1; j++){
			printf("insira o %d digito da %d linha:\n", j+1, i+1);
			scanf("%d", &matA[i][j]);
		}
	}
	printf("para a segunda matriz:\n");
	for(i=0; i<c1; i++){
		for(j=0; j<c1; j++){
			printf("insira o %d digito da %d linha:\n", j+1, i+1);
			scanf("%d", &matB[i][j]);
		}
	}
	for(i=0; i<c1; i++){
		for(j=0; j<c1; j++){
			matC[i][j]=matA[i][j]+matB[i][j];
			printf("%d ",matC[i][j]);
		}
		printf("\n\n");
	}
	system("pause");
	return 0;
}
