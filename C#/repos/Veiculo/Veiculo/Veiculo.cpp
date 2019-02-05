#include "Veiculo.h"


Veiculo::Veiculo() {
	matricula = "sem matricula";
	ano = 2000;
	totalKm = 0;
	totalDeposito = 60;
	quatCombustivel = 0;
	consumoMedio = 6;
}

Veiculo::Veiculo(string m, int a, double dep, double cons) {
	matricula = m;
	ano = a;
	totalKm = 0;
	if(!setTotalDeposito(dep)) totalDeposito = 60;
	quatCombustivel = 0;
	if(!setConsumoMedio(cons)) consumoMedio = 6;
}

Veiculo::Veiculo(const Veiculo &v) {
	this->matricula = v.matricula;
	this->ano = v.ano;
	this->totalKm = v.totalKm;
	this->totalDeposito = v.totalDeposito;
	this->quatCombustivel = v.quatCombustivel;
	this->consumoMedio = v.consumoMedio;
}

void Veiculo::setMatricula(string m) {
	matricula = m;
}

bool Veiculo::setTotalDeposito(double dep) {
	if (dep < 10 || dep > 150)
		return false;
	totalDeposito = dep;
	return true;
}

bool Veiculo::setConsumoMedio(double cons) {
	if (cons < 1 || cons > 20)
		return false;
	consumoMedio = cons;
	return true;
}

string Veiculo::getsMatricula() {
	return matricula;
}

int Veiculo::getsAno() {
	return ano;
}

double Veiculo::getsTotalKm() {
	return totalKm;
}

double Veiculo::getsTotalDeposito() {
	return totalDeposito;
}

double Veiculo::getsQuatCombustivel() {
	return quatCombustivel;
}

double Veiculo::getsConsumoMedio() {
	return consumoMedio;
}

string Veiculo::toString() {
	return "Dados do veiculo: \nmatricula: " + matricula + "\nano: " + to_string(ano) + "\ntotal kms: " + to_string(totalKm) + "\ntotal deposito: " + to_string(totalDeposito) + "\ncombustivel: " + to_string(quatCombustivel) + "\nconsumo medio: " + to_string(consumoMedio) + "\n";
}

bool Veiculo::abastecer(double l) {
	if (l < 0 || l + quatCombustivel > totalDeposito)
		return false;
	quatCombustivel += l;
	return true;
}

bool Veiculo::registarSaida(double km) {
	double gasto = (km*consumoMedio) / 100;
	if (km < 0 || quatCombustivel<gasto)
		return false;
	totalKm += km;
	quatCombustivel -= gasto;
	return true;
}

