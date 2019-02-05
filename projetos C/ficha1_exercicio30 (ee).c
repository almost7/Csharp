//ee. Elabore um programa que lê um vector VEC_ORIGINAL de N elementos e os reescreva num outro vector VEC_ORDENADO por ordem crescente.

#include<stdio.h>
#include<stdlib.h>
int main(){
	int n, i, j, aux=0;
	do{
		printf("quantos elementos tem o vec_original?\n");
		scanf("%d", &n);
	}while(n<0);
	int vec[n];
	for(i=0; i<n; i++){
		printf("qual o %d digito?\n", i+1);
		scanf("%d", &vec[i]);
	}
	for(i=0; i<n-1; i++){
		for(j=i+1; j<n; j++){
			if(vec[i]>vec[j]){
				aux=vec[i];
				vec[i]=vec[j];
				vec[j]=aux;
			}
		}
	}
	for(i=0; i<n; i++){
		printf("%d, ", vec[i]);
	}
	system("pause");
	return 0;
}
