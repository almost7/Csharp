#include<stdio.h>
#include<stdlib.h>

int main(){
	int n, i, maiores=0;
	do{
	printf("quantos numeros tem o vector\n");
	scanf("%d", &n);
	}while(n<=0);
	int vec[n], vnm[n];
	for(i=0; i<n; i++){
		printf("insira o digito do vec[%d]\n", i);
		scanf("%d", &vec[i]);
	}
	for(i=1; i<n-1; i++){
		if(vec[i]>vec[i-1] && vec[i]>vec[i+1]){
		vnm[maiores]=vec[i];
		i++;
		maiores++;
		}
	}
	printf("%d dos numeros sao maiores que os seus pares:\n", maiores); 
	for(i=0; i<maiores; i++){
		printf("%d,",vnm[i]);
	}
	printf("\n");
	system("pause");
	return 0;
}
