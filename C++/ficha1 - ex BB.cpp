//bb. Elabore um programa que l� um vector de N elementos e calcule a m�dia dos elementos �mpares.

#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int k, i, contador=0;
	float soma=0;
	cout<< "indique o tamanho do vector:\n";
	cin>> k;
	int *vec = new int[k];
	for(i=0;i<k;i++){
		cout<< "insira o "<<i+1<<"� n�mero:\n";
		cin>> vec[i];
		if(vec[i]%2==1){
			contador++;
			soma+=vec[i];
		}
	}
	cout<< "\na m�dia dos valores impares �: "<<soma/contador;
}
