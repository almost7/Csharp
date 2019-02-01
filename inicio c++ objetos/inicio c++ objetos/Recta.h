#include <iostream>
#include <string>
#include <windows.h>
#include <tchar.h>
#include "Ponto.h"

using namespace std;

class Recta {
private:
	Ponto p1;
	Ponto p2;
public:
	Recta();
	Recta(const Ponto &p1, const Ponto &p2);
	Recta(const Recta &r);
	void setP1(const Ponto &p1);
	void setP2(const Ponto &p2);
	Ponto getP1();
	Ponto getP2();
	string toString();
	Ponto pontoMedio();
};
