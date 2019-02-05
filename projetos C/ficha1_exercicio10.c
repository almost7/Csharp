#include<stdio.h>
#include<stdlib.h>

int main(){
	float nO, nE, nF;
	printf("qual a nota do exame Oral?\n");
	scanf("%f", &nO);
	printf("Qual o nota do exame Escrito?\n");
	scanf("%f", &nE);
		if(((nO*0.3)+(nE*0.7))>=10)
			printf("tirou %.2f, aprovado!\n",(nO*0.3)+(nE*0.7));
		else
			printf("tirou %.2f, reprovado!\n",(nO*0.3)+(nE*0.7));
	system("pause");
	return 0;
}
