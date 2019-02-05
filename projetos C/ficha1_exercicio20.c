#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, idade, sup=0, i, a;
	printf("quantos alunos tem a turma\n");
	scanf("%d", &n);
	printf("qual a idade limite?\n");
	scanf("%d", &idade);
	for(i=0; i<n; i++){
		printf("qual a idade do aluno %d?\n", i+1);
		scanf("%d", &a);
		if(a>idade)
			sup++;
	}	
	printf("%.1f porcento dos alunos tem idade superior a idade indicada\n", ((float)sup/n)*100);
	system("pause");
	return 0;
}

