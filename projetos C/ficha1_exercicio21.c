#include<stdio.h>
#include<stdlib.h>

int main(){
	int num, cont=0, max, flag=0;
	printf("insira um numero\n");
	scanf("%d", &num);
	while (cont<5){
		printf("insira um numero\n");
		scanf("%d", &num);
		if(num%2==1)
			cont++;
		else
			if(num>max || flag==0){
				max=num;
				flag=1;
			}
	}
	if(flag==0)
		printf("nao foi inserido nenhum par\n");
	else
		printf("o maior numero par inserido foi o %d\n", max);	
	system("pause");
	return 0;
}
