#include "Recta.h"

Recta::Recta() {//construtor vazio
	p1.setX(0);
	p1.setY(0);
	p2.setX(0);
	p2.setY(0);
}

Recta::Recta(const Ponto &a, const Ponto &b) {//construtor por parâmetro
	p1 = a;
	p2 = b;
}

Recta::Recta(const Recta &r) {//construtor cópia
	this->p1 = r.p1;
	this->p2 = r.p2;
}

void Recta::setP1(const Ponto &p1) {//modificadores
	this->p1 = p1;
}

void Recta::setP2(const Ponto &p2) {//modificadores
	this->p2 = p2;
}

Ponto Recta::getP1() {//selectores
	return p1;
}
Ponto Recta::getP2() {//selectores
	return p2;
}

string Recta::toString() {// Criação do to string para passagem da informação na consola
	return "Recta: (" + p1.toString() + ", " + p2.toString() + ")";
}

Ponto Recta::pontoMedio() {
	Ponto pM;
	pM.setX((p1.getX() + p2.getX()) / 2);
	pM.setY((p1.getY() + p2.getY()) / 2);
	return pM;
}