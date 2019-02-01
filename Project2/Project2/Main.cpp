#include "Empresa.h"
#include "Pessoa.h"

#pragma warning(disable: 4996)
time_t t2 = time(NULL);
tm* timePtr2 = localtime(&t2);

int main() {
	_tsetlocale(LC_ALL, "portuguese");

	Contato c1;
	c1.setData(2005, 12, 24);
	c1.setData(2007, 0, 0);
	cout << "Este contato tem " + to_string(c1.calcularIdade()) + " anos\n";

	system("pause");

}