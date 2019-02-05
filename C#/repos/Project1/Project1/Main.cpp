#include "Matrizes.h"

int main() {
	_tsetlocale(LC_ALL, "portuguese");

	int c = 3, l = 3, linha = 2, coluna = 1;
	int **mat = new int*[l];
	for (int i = 0; i<l; i++)
		mat[i] = new int[c];
	Matrizes::lerMatriz(l, c, mat);
	int **matA = new int*[l];
	for (int i = 0; i<l; i++)
		matA[i] = new int[c];
	Matrizes::lerMatriz(l, c, matA);
	int **matB = new int*[l];
	for (int i = 0; i<l; i++)
		matB[i] = new int[c];
	Matrizes::lerMatriz(l, c, matB);
	cout << "\n";
	system("pause");
	system("cls");
	cout << "confirmação se é quadrada   [1]=sim   [0]=não :  " << Matrizes::isQuad(l, c) << "\n";
	cout << "confirmação se é nula       [1]=sim   [0]=não :  " << Matrizes::isNula(l, c, mat) << "\n";
	cout << "confirmação se é identidade [1]=sim   [0]=não :  " << Matrizes::isIdentidade(l, c, mat) << "\n";
	cout << "confirmação se é escalar    [1]=sim   [0]=não :  " << Matrizes::isEscalar(l, c, mat) << "\n";
	system("pause");
	system("cls");
	int** matC = Matrizes::soma(l, c, matA, matB);
	cout << "matA + matB = \n";
	Matrizes::mostrarMatriz(l, c, matC);
	cout << "\n";
	system("pause");
	system("cls");
	int maiorElemLinha = Matrizes::maxElemLinha(c, matA, linha);
	cout << "o maior elemento da linha 2 da matA é:	" << maiorElemLinha << "\n";
	int maiorElemColuna = Matrizes::maxElemColuna(c, matA, coluna);
	cout << "o maior elemento da coluna 1 da matA é:	" << maiorElemColuna << "\n";
	system("pause");
	system("cls");
	int** matD = Matrizes::transposta(l, c, matA);
	cout << "a versão transposta da matA é :\n";
	Matrizes::mostrarMatriz(l, c, matD);
	cout << "\n";
	system("pause");
	system("cls");
	int* centro = Matrizes::centro(l, c, matA);
	cout << "o centro da matA é:\n";
	for (int i = 1; i<centro[0]; i++)
		cout << "[" << centro[i] << "]";
}
