/* Gerar um n�mero aleat�rio entre 1 e 20 permitindo de seguida ao utilizador fazer sucessivas tentativas at� acertar nesse n�mero. Em cada tentativa errada � mostrado ao utilizador uma das mensagens: 
�Tente um n�mero maior� ou �Tente um n�mero menor�. Quando o utilizador acertar no n�mero deve ser mostrado o n�mero de tentativas gastas pelo utilizador.*/
#include<stdio.h>
#include<stdlib.h>
int main(){
	int x =1+(rand()%20), n, cont=0;
	do{
		printf("escolha um n�mero aleatorio entre 1 e 20\n");
		scanf("%d", &n);
		cont++;
	}while(n!=x);
	printf("acertou! e so precisou de %d tentativas\n", cont);
	system("pause");
	return 0;
}
