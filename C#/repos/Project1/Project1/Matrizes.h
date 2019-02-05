#include <iostream>
#include <string>
#include <windows.h>
#include <tchar.h>

using namespace std;

class Matrizes {
private:

public:
	static void lerMatriz(int l, int c, int** mat);
	static void mostrarMatriz(int l, int c, int** mat);
	static int** criaMatNula(int l, int c);
	static bool isQuad(int l, int c);
	static bool isNula(int l, int c, int** matA);
	static bool isIdentidade(int l, int c, int** matA);
	static bool isEscalar(int l, int c, int** matA);
	static int** soma(int l, int c, int** matA, int** matB);
	static int	maxElemLinha(int c, int** matA, int linha);
	static int	maxElemColuna(int l, int** matA, int coluna);
	static int** transposta(int l, int c, int** matA);
	static int* diagonalPrincipal(int l, int c, int** matA);
	static int* centro(int l, int c, int** matA);
};

