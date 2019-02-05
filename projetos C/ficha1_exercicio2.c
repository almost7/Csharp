#include<stdio.h>
#include<stdlib.h>

int main(){
	int n1, n2, n3;
	float media;
	printf("insira o primeiro numero\n");
	scanf("%d", &n1);
	printf("insira o segundo numero\n");
	scanf("%d", &n2);
	printf("insira o terceiro numero\n");
	scanf("%d", &n3);
	media=(float) (n1+n2+n3)/3;
	printf("a media dos 3 numeros introduzidos e %f\n", media);
	system("pause");
	return 0;
}
