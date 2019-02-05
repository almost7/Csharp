#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, i, neg=0;
	float nota;
	printf("quantos alunos tem a turma?\n");
	scanf("%d",&n);
	for(i=0; i<n; i++){
		printf("insira a nota do %d aluno\n",i+1);
		scanf("%f",&nota);
			if(nota<10)
				neg++;
	} 
	printf("A turma teve %d negativas\n",neg);
	system("pause");
	return 0;
}

