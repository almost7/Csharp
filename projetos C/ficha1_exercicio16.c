#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, i;
	float nota, soma=0;
	printf("quantos alunos tem a turma?\n");
	scanf("%d",&n);
	for(i=0; i<n; i++){
		printf("insira a nota do %d aluno\n",i+1);
		scanf("%f",&nota);
		soma=soma+nota;
	} 
	printf("A media da turma e de %.2f\n",soma/n);
	system("pause");
	return 0;
}

