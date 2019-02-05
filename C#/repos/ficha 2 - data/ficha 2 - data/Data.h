#pragma once
#include <iostream>
#include <string>
#include <windows.h>
#include <tchar.h>
#include <ctime>


using namespace std;

class Data {
private:
	int Ano;
	int Mes;
	int Dia;
public:
	Data();
	Data(int a, int m, int d);
	Data(const Data &d);
	bool setDia(int d);
	bool setMes(int m);
	bool setAno(int a);
	int getsDia();
	int getsMes();
	int getsAno();
	string toString();
	int calcularIdade();
};