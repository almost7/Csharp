#include "Recta.h"

int main() {
	_tsetlocale(LC_ALL, "portuguese");

	Ponto p1(1, 1);
	Ponto p2(5, 5);
	Recta r1(p1, p2);
	Ponto p4(p1);
	cout << p1.distEntre2Pontos(p2)<<"\n";
	Ponto p3(r1.pontoMedio());
	cout <<p3.toString() << "\n";
	system("pause");
}