#include "Contacto.h"

#pragma warning(disable: 4996)
time_t t3 = time(NULL);
tm* timePtr3 = localtime(&t3);

Contacto::Contacto() {
	id = 0;
	nome = "sem nome";
	telef = 0;
	eMail = "";
	dataNasc = Data();
}

Contacto::Contacto(int i, string n, int t, string e, Data &d) {
	id = i;
	nome = n;
	telef = t;
	eMail = e;
	dataNasc = d;
}

Contacto::Contacto(const Contacto &c) {
	this->id = c.id;
	this->nome = c.nome;
	this->telef = c.telef;
	this->eMail = c.eMail;
	this->dataNasc = c.dataNasc;
}

int Contacto::getId() {
	return id;
}

string Contacto::getNome() {
	return nome;
}

int Contacto::getTelef() {
	return telef;
}

string Contacto::getEmail() {
	return eMail;
}

void Contacto::setNome(string n) {
	nome = n;
}
void Contacto::setTelef(int t) {
	telef = t;
}
void Contacto::setEmail(string e) {

}
void Contacto::setData(int a, int m, int d) {
	dataNasc.setAno(a);
	dataNasc.setMes(m);
	dataNasc.setDia(d);
}
int Contacto::calcularIdade() {
	int year = timePtr3->tm_year + 1900;
	return year - dataNasc.getsAno();
}

