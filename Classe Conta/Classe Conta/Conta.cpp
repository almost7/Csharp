#include "Conta.h"

Conta::Conta() {
	Titular = "sem nome";
	Numero = 0;
	Saldo = 0;
	Estado = -1;
}

Conta::Conta(string t, int n) {
	Titular = t;
	Numero = n;
	Saldo = 0;
	Estado = 1;
}

Conta::Conta(const Conta &c) {
	Titular = c.Titular;
	Numero = c.Numero;
	Saldo = c.Saldo;
	Estado = c.Estado;
}

void Conta::setTitular(string t) {
	Titular = t;
}

void Conta::setNumero(int n) {
	Numero = n;
}

/*void Conta::setSaldo(double s) {
	Saldo = s;
}

void Conta::setEstado(int e) {
	Estado = e;
}*/

string Conta::getTitular() {
	return Titular;
}

int Conta::getNumero() {
	return Numero;
}

double Conta::getSaldo() {
	return Saldo;
}

int Conta::getEstado() {
	return Estado;
}

string Conta::toString() {
	return "Conta: \nTitular: " + Titular + "\nNumero: " + to_string(Numero) + "\nSaldo: " + to_string(Saldo) + "\nEstado: " + to_string(Estado) + "\n";
}

int Conta::levantar(double s) {
	if (Saldo - s < 0)
		return -1;
	Saldo -= s;
	return 0;
}

int Conta::depositar(double s) {
	if (s < 0)
		return -1;
	Saldo += s;
	return 0;
}

void Conta::alterarEstado() {
	if (Estado == -1)
		Estado = 1;
	if (Estado == 1)
		Estado = -1;
}

double Conta::credito() {
	if (Saldo < 500)
		return 0;
	if (Saldo < 1000)
		return Saldo * 0.1;
	if (Saldo < 5000)
		return Saldo * 0.3;
	if (Saldo >= 5000)
		return Saldo * 0.5;
}