#include<stdio.h>
#include<stdlib.h>

int main(){
	int x, y, aux=0, i;
	printf("insira o primeiro numero\n");
	scanf("%d", &x);
	printf("insira o ultimo numero\n");
	scanf("%d", &y);
	if(y<x){
		aux=x;
		x=y;
		y=aux;
	}
	if(x%2!=0)
		x++;
	for(i=x; i<y; i=i+2){
		printf("%d\n", i);
	}
	system("pause");
	return 0;
}

