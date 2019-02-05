#pragma once
#include "Contato.h"

class Pessoa {
private:
	Data dataNasc;

public:
	Pessoa	dataNasc();
	Pessoa	dataNasc(Data &d);
	Pessoa	dataNasc();

	int calcularIdade();
};