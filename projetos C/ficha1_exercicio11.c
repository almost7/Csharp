#include<stdio.h>
#include<stdlib.h>

int main(){
	int horas, ext;
	printf("quantas horas trabalhou esta semana?\n");
	scanf("%d", &horas);
	ext=horas-36;
		if (horas <=36)
			printf("tem a receber %.1f euros esta semana\n",(float)horas*7.5 );
		else	
			printf("tem a receber %.1f euros esta semana\n",(float)ext*10+270);
	system("pause");
	return 0;
}
