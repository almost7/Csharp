#include <iostream>
#include <string>
#include <windows.h>
#include <tchar.h>

using namespace std;

class Conta {
private:
	string Titular;
	int Numero;
	double Saldo;
	int Estado;

public:
	Conta();
	Conta(string t, int n);
	Conta(const Conta &c);
	void setTitular(string t);
	void setNumero(int n);
	//void setSaldo(double s);
	//void setEstado(int e);
	string getTitular();
	int getNumero();
	double getSaldo();
	int getEstado();
	string toString();
	int levantar(double s);
	int depositar(double s);
	void alterarEstado();
	double credito();
}; 
