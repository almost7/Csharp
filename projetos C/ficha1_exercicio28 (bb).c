//bb. Elabore um programa que l� um vector de N elementos e calcule a m�dia dos elementos �mpares.

#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, i;
	float soma=0, cont=0;
	printf("quantos numeros tem o vector\n");
	scanf("%d", &n);
	int vec[i];
	for(i=0; i<n; i++){
		printf("insira o valor do vec[%d]: \n", i);
		scanf("%d", &vec[i]);
	}
	for(i=0; i<n; i++){
		if(vec[i]%2==1){
			soma=soma+vec[i];
			cont++;
		}
	}
	printf("a media dos elementos impares e %.2f \n", soma/cont);
	system("pause");
	return 0;
}
