/* Gerar um número aleatório entre 1 e 20 permitindo de seguida ao utilizador fazer sucessivas tentativas até acertar nesse número. Em cada tentativa errada é mostrado ao utilizador uma das mensagens: 
“Tente um número maior” ou “Tente um número menor”. Quando o utilizador acertar no número deve ser mostrado o número de tentativas gastas pelo utilizador.*/
#include<stdio.h>
#include<stdlib.h>
int main(){
	int x =1+(rand()%20), n, cont=0;
	do{
		printf("escolha um número aleatorio entre 1 e 20\n");
		scanf("%d", &n);
		cont++;
	}while(n!=x);
	printf("acertou! e so precisou de %d tentativas\n", cont);
	system("pause");
	return 0;
}
