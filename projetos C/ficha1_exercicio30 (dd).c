//dd. Dados dois vectores VEC1 e VEC2, escreva no ecrã os elementos comuns aos dois vectores.

#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, j, i, aux=0, similar=0, k, l;
	do{
		printf("qual o numero de elementos do vector 1?\n");
		scanf("%d",&n);
	}while (n<0);
	do{
		printf("qual o numero de elementos do vector 2?\n");
		scanf("%d",&j);
	}while (j<0);
	int vec1[n], vec2[j], vec3[n];
	for(i=0; i<n; i++){
		printf("qual o %d digito do vec1?\n", i);
		scanf("%d",&vec1[i]);
	}
	for(i=0; i<j; i++){
		printf("qual o %d digito do vec2?\n", i);
		scanf("%d",&vec2[i]);
	}
	for(i=0; i<n; i++){
		similar=0;
		for(k=0; k<i; k++){
			if(vec1[i]==vec1[k]){ //confirma se o elemento atual é igual aos anteriores
				similar=1; //caso positivo ativa marcador
				k=i; //k=i para terminar a pesquisa pois "i" é o fim da lista.
			}
		}
		if(similar==0) // não encontrou similares no mesmo vector
			for(l=0; l<j; l++){
				if(vec1[i]==vec2[l]){
					vec3[aux]=vec2[l];
					aux++; //este auxiliar permite que os numeros associados ao vec3 sigam a ordem correta em incrementos de 1
					l=j;
				}
			}
	}
	for(i=0; i<aux; i++){
		printf("%d, ", vec3[i]);
	}
	system("pause");
	return 0;
}
