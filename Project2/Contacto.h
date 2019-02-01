#include "Data.h"

class Contacto {
private:
	int id;
	string nome;
	int telef;
	string eMail;
	Data dataNasc;
public:
	Contacto();
	Contacto(int i, string n, int t, string e, Data &d);
	Contacto(const Contacto &c);
	int getId();
	string getNome();
	int getTelef();
	string getEmail();
	void setNome(string n);
	void setTelef(int t);
	void setEmail(string e);
	void setData(int a, int m, int d);
	int calcularIdade();
};