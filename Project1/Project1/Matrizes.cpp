#include "Matrizes.h"

void Matrizes::lerMatriz(int l, int c, int** mat) {
	for (int i = 0; i<l; i++)
		for (int j = 0; j<c; j++) {
			cout << "insira elemento da matriz[" << i << "][" << j << "]\n";
			cin >> mat[i][j];
		}
}

void Matrizes::mostrarMatriz(int l, int c, int** mat) {
	for (int i = 0; i<l; i++) {
		cout << "\n";
		for (int j = 0; j<c; j++)
			cout << "[" << mat[i][j] << "]  ";
	}
}

int** Matrizes::criaMatNula(int l, int c) {
	int **mat = new int*[l];
	for (int i = 0; i<l; i++) {
		mat[i] = new int[c];
		for (int j = 0; j<c; j++)
			mat[i][j] = 0;
	}
	return mat;
}

bool Matrizes::isQuad(int l, int c) {
	if (l == c)
		return true;
	return false;
}

bool Matrizes::isNula(int l, int c, int** matA) {
	for (int i = 0; i<l; i++)
		for (int j = 0; j<c; j++)
			if (matA[i][j] != 0)
				return false;
	return true;
}

bool Matrizes::isIdentidade(int l, int c, int** matA) {
	int soma = 0;
	if (!isQuad(l, c))
		return false;
	else
		for (int i = 0; i<l; i++)
			if (matA[i][i] != 1)
				return false;
			else
				for (int j = 0; j<l; j++)
					for (int k = 0; k<c; k++)
						soma += matA[i][j];
	if (soma>l)
		return false;
	return true;
}

bool Matrizes::isEscalar(int l, int c, int** matA) {
	int soma = 0;
	if (!isQuad(l, c))
		return false;
	else
		for (int i = 0; i<l; i++)
			if (matA[i][i] != matA[0][0])
				return false;
			else
				for (int j = 0; j<l; j++)
					for (int k = 0; k<c; k++)
						soma += matA[i][j];
	if (soma>l*matA[0][0])
		return false;
	return true;
}

int** Matrizes::soma(int l, int c, int** matA, int** matB) {
	int **matC = new int*[l];
	for (int i = 0; i<l; i++)
		matC[i] = new int[c];
	for (int i = 0; i<l; i++)
		for (int j = 0; j<c; j++)
			matC[i][j] = matA[i][j] + matB[i][j];
	return matC;
}

int	Matrizes::maxElemLinha(int c, int** matA, int linha) {
	int maxElem = matA[linha][0];
	for (int i = 0; i<c; i++)
		if (matA[linha][i]>maxElem)
			maxElem = matA[linha][i];
	return maxElem;
}

int	Matrizes::maxElemColuna(int l, int** matA, int coluna) {
	int maxElem = matA[0][coluna];
	for (int i = 0; i<l; i++)
		if (matA[i][coluna]>maxElem)
			maxElem = matA[i][coluna];
	return maxElem;
}

int** Matrizes::transposta(int l, int c, int** matA) {
	int **matC = new int*[c];
	for (int i = 0; i<l; i++)
		matC[i] = new int[l];
	for (int i = 0; i<l; i++)
		for (int j = 0; j<c; j++)
			matC[j][i] = matA[i][j];
	return matC;
}

int* Matrizes::diagonalPrincipal(int l, int c, int** matA) {
	int* vec1 = new int[l];
	for (int i = 0; i<l; i++)
		vec1[i] = matA[i][i];
	return vec1;
}

int* Matrizes::centro(int l, int c, int** matA) {
	int* vec1 = new int[5];
	if (l % 2 == 0)
		if (c % 2 == 0) {
			vec1[0] = 5;
			vec1[1] = matA[l / 2][c / 2];
			vec1[2] = matA[l / 2 - 1][c / 2];
			vec1[3] = matA[l / 2][c / 2 - 1];
			vec1[4] = matA[l / 2 - 1][c / 2 - 1];
		}
		else {
			vec1[0] = 3;
			vec1[1] = matA[l / 2 - 1][c / 2];
			vec1[2] = matA[l / 2][c / 2];
		}
	else
		if (c % 2 == 0) {
			vec1[0] = 3;
			vec1[1] = matA[l / 2][c / 2];
			vec1[2] = matA[l / 2][c / 2 - 1];
		}
		else {
			vec1[0] = 2;
			vec1[1] = matA[l / 2][c / 2];
		}
		return vec1;
}