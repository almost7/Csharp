#pragma once
#include "Veiculo.h"
class Mota : public Veiculo {
private:

public:
	Mota();
	Mota(string m, int a, double dep, double cons);
	Mota(const Mota &c);
	string toString();
};