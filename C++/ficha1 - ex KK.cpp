// kk. Elabore um programa que lê uma matrizes MAT de L e C colunas, preenchida com valores inteiros e insira a diagonal da matriz num vector VEC .
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int a, b, i, j;
	cout<<"insira nº de linhas da matriz:\n";
	cin>>a;
	cout<<"insira nº de colunas da matriz:\n";
	cin>>b;
	int **mat =new int*[a];
	for(i=0;i<a;i++){
		mat[i]=new int[b];
		for(j=0;j<b;j++){
		cout<<"valor da linha "<<i+1<<" coluna "<<j+1<<"\n";
		cin>>mat[i][j];
		}
	}
	cout<<"a diagonal dessa matriz:\n";
	for(i=0;i<a;i++)
		cout<<mat[i][i]<<"	";
}
