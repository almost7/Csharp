//jj. Elabore um programa que guarde numa estrutura de dados adequada os dados de N alunos de uma turma: n�mero de aluno e m�dia final. Imprima o n�mero do aluno com melhor m�dia e respetiva m�dia.
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
		printf("qual a sua media?\n");
		scanf("%.2f", &mat[i][1]);
	}
	float melhorMedia=mat[0][1];
	int melhorAluno=mat[1][0];
	for(i=1; i<n; i++){
		if(mat[i][1]>melhorMedia){
			melhorMedia=mat[i][1];
			melhorAluno=mat[0][i];
		}
	}
	printf("o aluno %d foi o melhor com uma media de %.2f\n", melhorAluno, melhorMedia);
	system("pause");
	return 0;
}
