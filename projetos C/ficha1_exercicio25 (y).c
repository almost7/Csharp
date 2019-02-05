#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, i, maior=0, menor=0, posMaior=0, posMenor=0;
	do{
	printf("quantos numeros tem o vector\n");
	scanf("%d", &n);
	}while(n<=0);
	int vec[n];
	for(i=0; i<n; i++){
		printf("vec[%d]: ", i);
		scanf("%d", &vec[i]);
	}
	maior=vec[0];
	posMaior=0;
	menor=vec[0];
	posMenor=0;
	for(i=1; i<n; i++){
		if(vec[i]>maior){
			maior=vec[i];
			posMaior=i;
		}
		else{
			if(vec[i]<menor){
				menor=vec[i];
				posMenor=i;
			}
		}
	}
	printf("\n O numero maior e o %d na %d posiçao e o menor e o %d na %d posição\n",maior, posMaior, menor, posMenor);	
	system("pause");
	return 0;
}
