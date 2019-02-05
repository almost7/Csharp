#include "Mota.h"

Mota::Mota() : Veiculo() {
	
}

Mota::Mota(string m, int a, double dep, double cons) : Veiculo(m, a, dep, cons) {
}

Mota::Mota(const Mota &c) : Veiculo(c.matricula, c.ano, c.totalDeposito, c.consumoMedio) {
}

string Mota::toString() {
	return  "\nMota:\n" + Veiculo::toString();
}