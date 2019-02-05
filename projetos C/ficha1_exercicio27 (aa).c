#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, i, maiorDif=0, aux=0;
	do{
	printf("quantos numeros tem o vector\n");
	scanf("%d", &n);
	}while(n<=0);
	int vec[n];
	for(i=0; i<n; i++){
		printf("insira o digito do vec[%d]\n", i);
		scanf("%d", &vec[i]);
	}
	for(i=0; i<n-1; i++){
		aux=abs(vec[i]-vec[i+1]);
		if(aux>maiorDif)
			maiorDif=aux;
	}
	printf("a maior diferenca entre os numeros do vector e de %d\n", maiorDif);
	system("pause");
	return 0;
}
