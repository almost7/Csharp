//hh. Elabore um programa que guarde numa estrutura de dados adequada os dados de N funcion�rios de uma empresa: n�mero de funcion�rio e sal�rio. Imprima o n�mero dos funcion�rios com sal�rio superior a 1000�.
#include<stdio.h>
#include<stdlib.h>
int main (){
	int n, i;
	printf("quantos empregados tem a empresa?\n");
	scanf("%d", &n);
	int mat[n][2];
	for(i=0; i<n; i++){
		printf("numero de funcionario %d:\n", i+1);
		scanf("%d", &mat[i][0]);
		printf("o seu salario:\n");
		scanf("%d", &mat[i][1]);
	}
	for(i=0; i<n; i++){
		if(mat[i][1]>=1000){
			printf("\nfuncionario %d\n",mat[i][0]);
		}
	}
	system("pause");
	return 0;
}
