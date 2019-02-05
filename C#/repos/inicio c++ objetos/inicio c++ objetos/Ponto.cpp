#include "Ponto.h"

Ponto::Ponto(){//construtor vazio
	x = 0; 
	y = 0;
}

Ponto::Ponto(int a, int b){//construtor por parâmetro
	x = a;
	y = b;
}

Ponto::Ponto(const Ponto &p){//construtor por cópia
	x = p.x;
	y = p.y;
}

void Ponto::setX(int a) {//modificadores
	x = a;
}

void Ponto::setY(int b) {//modificadores
	y= b;
}

int Ponto::getX() {//selectores
	return x;
}
int Ponto::getY() {//selectores
	return y;
}

string Ponto::toString() {
	return "Ponto: (" + to_string(x) + ", " + to_string(y) + ").";
}

double Ponto::distEntre2Pontos(const Ponto &p) {
	return sqrt(pow((x - p.x), 2)) + (pow((y - p.y), 2));
}