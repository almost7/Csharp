#pragma once
#include "Veiculo.h"
class Carro : public Veiculo {
private:
	bool tejadilho;

public:
	Carro();
	Carro(string m, int a, double dep, double cons, bool t);
	Carro(const Carro &c);	
	void setTejadilho();
	string toString();
};