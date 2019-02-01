#include "Contato.h"

time_t t2 = time(NULL);
tm* timePtr2 = localtime(&t2);

int main() {
	_tsetlocale(LC_ALL, "portuguese");

	Contato c1;
	cout<<c1.calcularIdade();

	system("pause");

}