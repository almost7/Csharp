//ii. Elabore um programa que guarde numa estrutura de dados adequada os dados de N alunos de uma turma: número de aluno e idade. Imprima o número dos alunos com idade compreendida entre 16 e 20.
#include<stdio.h>
#include<stdlib.h>
int main (){
	int n, i;
	printf("quantos alunos tem a turma?\n");
	scanf("%d", &n);
	int mat[n][2];
	for(i=0; i<n; i++){
		printf("numero de aluno %d:\n", i+1);
		scanf("%d", &mat[i][0]);
		printf("qual a sua idade?\n");
		scanf("%d", &mat[i][1]);
	}
	printf("alunos com idade entre 16 e 20 anos:\n");
	for(i=0; i<n; i++){
		if(mat[i][1]>=16 && mat[i][1]<=20){
			printf("\n aluno %d\n",mat[i][0]);
		}
	}
	system("pause");
	return 0;
}
