#pragma once
#include <iostream>
#include <string>
#include <windows.h>
#include <tchar.h>
#include <ctime>

using namespace std;

class Veiculo {
protected:
	string matricula;
	int ano;
	double totalKm;
	double totalDeposito;
	double quatCombustivel;
	double consumoMedio;


public:
	Veiculo();
	Veiculo(string m, int a, double dep, double cons);
	Veiculo(const Veiculo &v);
	void setMatricula(string m);
	//void setTotalKm(int a);
	bool setTotalDeposito(double dep);
	//bool setQuatCombustivel(double dep);
	bool setConsumoMedio(double cons);
	string getsMatricula();
	int getsAno();
	double getsTotalKm();
	double getsTotalDeposito();
	double getsQuatCombustivel();
	double getsConsumoMedio();	
	string toString();
	bool abastecer(double l);
	bool registarSaida(double km);
}; 

