#include "Carro.h"
#include "Mota.h"

void main() {
	_tsetlocale(LC_ALL, "portuguese");
	Carro c1("34-DE-27", 1998, 45, 4,false);
	Mota m1("66-QH-24", 2015, 15, 3);;
	cout << "\nquanto pretende abastecer?\n";
	double litros;
	cin >> litros;
	if (c1.abastecer(litros))
		cout << "\nabastecimento realizado com sucesso, total final combustivel: " + to_string(c1.getsQuatCombustivel()) + "\n";
	else
		cout << "\nquantidade de combustivel não permitida\n";
	m1.abastecer(9);
	c1.registarSaida(30);
	m1.registarSaida(40);
	cout << c1.toString() + m1.toString();
	system("pause");
}