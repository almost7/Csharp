#include "Carro.h"

Carro::Carro() : Veiculo(){
	tejadilho = false;
}

Carro::Carro(string m, int a, double dep, double cons, bool t) : Veiculo(m, a, dep, cons) {
	tejadilho = t;
}

Carro::Carro(const Carro &c) : Veiculo(c.matricula, c.ano, c.totalDeposito, c.consumoMedio) {
	tejadilho = c.tejadilho;
}

void Carro::setTejadilho() {
	if (tejadilho)
		tejadilho = false;
	else
		tejadilho = true;
}

string Carro::toString() {
	if (tejadilho)
		return "\nCarro:\n" + Veiculo::toString() + "com tejadilho\n";
	return "\nCarro:\n" + Veiculo::toString() + "sem tejadilho\n";
}