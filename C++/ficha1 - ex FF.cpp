//Elabore um programa que dada uma matriz Q de L linhas e C colunas, preenchida com valores inteiros, indique se estamos na presença de uma matriz quadrada.
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int a, b, i;
	cout<<"insira a\n";
	cin>>a;
	cout<<"insira b\n";
	cin>>b;
	int **mat =new int*[a];
	for(i=0;i<a;i++){
		mat[i]=new int[b];
	}
	if(a==b)
		cout<<"a matriz é quadrada";
	else
		cout<<"a matriz não é quadrada";
}
