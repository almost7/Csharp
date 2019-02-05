#include<stdio.h>
#include<stdlib.h>

int main(){
	int base, alt, area;
	printf("insira a base do triangulo\n");
	scanf("%d", &base);
	printf("insira a altura do triangulo\n");
	scanf("%d", &alt);
	area=(base*alt)/2;
	printf("a area do triangulo e %d\n", area);
	system("pause");
	return 0;
}
 
