#include "Contato.h"

#pragma warning(disable: 4996)
time_t t3 = time(NULL);
tm* timePtr3 = localtime(&t3);

Contato::Contato() {
	id = 0;
	nome = "sem nome";
	telef = 0;
	eMail = "";
}

Contato::Contato(int i, string n, int t, string e) {
	id = i;
	nome = n;
	telef = t;
	eMail = e;
}

Contato::Contato(const Contato &c) {
	this->id = c.id;
	this->nome = c.nome;
	this->telef = c.telef;
	this->eMail = c.eMail;
}

int Contato::getId() {
	return id;
}

string Contato::getNome() {
	return nome;
}

int Contato::getTelef() {
	return telef;
}

string Contato::getEmail() {
	return eMail;
}

void Contato::setNome(string n) {
	nome = n;
}
void Contato::setTelef(int t) {
	telef = t;
}
void Contato::setEmail(string e) {

}

