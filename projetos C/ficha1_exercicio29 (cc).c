//cc. Dado um vector de N elementos indique quantos são múltiplos de 3.

#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, i, cont=0;
	do{
		printf("quantos elementos tem o vector?\n");
		scanf("%d", &n);
	}while(n<=0);
	int vec[n];
	for(i=0; i<n; i++){
		printf("insira o numero do vec[%d]\n", i);
		scanf("%d",&vec[i]);
		if(vec[i]%3==0)
			cont++;
	}
	printf("%d numeros sao multiplos de 3\n", cont);
	system("pause");
	return 0;
}
