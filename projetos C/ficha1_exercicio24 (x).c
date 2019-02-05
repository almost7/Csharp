#include<stdio.h>
#include<stdlib.h>

int main(){
	int a[100], n, i;
	printf("quantos numeros tem o vector\n");
	scanf("%d", &n);
	for(i=0; i<n; i++)
		scanf("%d", &a[i]);
	printf("\n");
	for(i=(n-1); i>-1; i--)
		printf("%d, ",a[i]);	
	system("pause");
	return 0;
}
