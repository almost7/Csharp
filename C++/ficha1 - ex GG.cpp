//gg. Elabore um programa que lê duas matrizes, A e B, de LA e LB linhas e CA e CB colunas, respetivamente, cada uma preenchida com valores inteiros e insira o resultado da soma das matrizes A e B numa nova matriz C. 
//(Somar todos os elementos correspondentes)
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int a, b, i, j;
	cout<<"insira nº de linhas das matrizes:\n";
	cin>>a;
	cout<<"insira nº de colunas das matrizes:\n";
	cin>>b;
	int **matA =new int*[a];
	cout<<"insira dados da matriz A:\n";
	for(i=0;i<a;i++){
		matA[i]=new int[b];
		for(j=0;j<b;j++){
		cout<<"valor da linha "<<i+1<<" coluna "<<j+1<<"\n";
		cin>>matA[i][j];
		}
	}
	int **matB =new int*[a];
	int **matC =new int*[a];
		cout<<"insira dados da matriz B:\n";
	for(i=0;i<a;i++){
		matB[i]=new int[b];
		matC[i]=new int[b];
		for(j=0;j<b;j++){
		cout<<"valor da linha "<<i+1<<" coluna "<<j+1<<"\n";
		cin>>matB[i][j];
		matC[i][j]=(matA[i][j]+matB[i][j]);
		}
	}
	cout<<"Resultado da soma das matrizes:\n";
	for(i=0;i<a;i++){
		cout<<"\n";
		for(j=0;j<b;j++)
			cout<<"	["<<matC[i][j]<<"]";
	}
}
