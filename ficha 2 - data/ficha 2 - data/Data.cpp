#include "Data.h"
#pragma warning(disable: 4996)
time_t t = time(NULL);
tm* timePtr = localtime(&t);

Data::Data() {								//construtor vazio
	Ano = 2000;
	Mes = 1;
	Dia = 1;
}

Data::Data(int a, int m, int d) {			//construtor por parâmetro
	if(!setAno(a))
		Ano = 2000;
	if (!setMes(m))
		Mes = 1;
	if (!setDia(d))
		Dia = 1;
}

Data::Data(const Data &d) {					//construtor cópia
	Ano = d.Ano;
	Mes = d.Mes;
	Dia = d.Dia;
}

bool Data::setAno(int a) {					//modificadores
	if (a >1900 && a <= (timePtr->tm_year + 1900))
		Ano = a;
		return true;
	return false;
}

bool Data::setMes(int m) {					//modificadores
	if (m >= 1 && m <= 12)
		if (Ano == (timePtr->tm_year + 1900) && m > (timePtr->tm_mon + 1))
			return false;
	if (m < 1)
		return false;
	Mes = m;
	return true;
}

bool Data::setDia(int d) {					//modificadores
	if (d < 1 || d >31)
		return false;
	if (Ano == (timePtr->tm_year + 1900) && Mes == (timePtr->tm_mon + 1) && d > (timePtr->tm_mday))
		return false;
	if ((d > 30) && (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11))
		return false;
	if ((d > 31) && (Mes == 1 || Mes == 3 || Mes == 5 || Mes == 7 || Mes == 8 || Mes == 10 || Mes == 12))
		return false;
	if ((d == 29 && Mes == 2) && (Ano % 400 == 0 || Ano % 4 == 0 && Ano % 100 != 0)) {
		Dia = d;
		return true;
	}
	if (d > 28 && Mes == 2)
		return false;
	else {
		Dia = d;
		return true;
	}
}

int Data::getsAno() {						//selectores
	return Ano;
}

int Data::getsMes() {						//selectores
	return Mes;
}

int Data::getsDia() {						//selectores
	return Dia;
}

string Data::toString() {					// Criação do to string para passagem da informação na consola
	return "Data =" + to_string(Ano) + "," + to_string(Mes) + "," + to_string(Dia)+ "\n\n";
}

int Contato::calcularIdade() {
	int year = timePtr->tm_year + 1900;
	return year - dataNasc.getsAno();
}