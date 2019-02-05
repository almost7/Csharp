#include "Data.h"
#pragma once

class Contato {
private:
	int id;
	string nome;
	int telef;
	string eMail;

public:
	Contato();
	Contato(int i, string n, int t, string e);
	Contato(const Contato &c);
	int getId();
	string getNome();
	int getTelef();
	string getEmail();
	void setNome(string n);
	void setTelef(int t);
	void setEmail(string e);
}; 
