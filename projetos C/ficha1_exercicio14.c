#include<stdio.h>
#include<stdlib.h>

int main(){
	float saldo;
	printf("qual o saldo medio do ultimo ano?\n");
	scanf("%f", &saldo);
		if (saldo>601)
			printf("credito aprovado de %.2f euros referente ao saldo medio de %.2f euros.\n",saldo*0.4,saldo);
		else
			if(saldo>400)
			printf("credito aprovado de %.2f euros referente ao saldo medio de %.2f euros.\n",saldo*0.3,saldo);
			else
				if(saldo>200)
				printf("credito aprovado de %.2f euros referente ao saldo medio de %.2f euros.\n",saldo*0.2,saldo);
				else
					if(saldo<=200)
					printf("impossibilidade de aprovar credito.\n");
	system("pause");
	return 0;
}
