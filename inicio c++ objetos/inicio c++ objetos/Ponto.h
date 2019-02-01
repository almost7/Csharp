#include <iostream>
#include <string>
#include <windows.h>
#include <tchar.h>
#include <math.h>

using namespace std;

class Ponto{
private:
	int x;
	int y;
public:
	Ponto();
	Ponto(int a, int b);
	Ponto(const Ponto &p);
	void setX(int a);
	void setY(int b);
	int getX();
	int getY();
	string toString();
	double distEntre2Pontos(const Ponto &p);
};