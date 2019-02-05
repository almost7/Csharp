//cc. Dado um vector de N elementos indique quantos são múltiplos de 3.

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
		cout<< "insira o "<<i+1<<"º número:\n";
		cin>> vec[i];
		if(vec[i]%3==0)
			contador++;
	}	
	cout<< "\quantodade de múltiplos de 3: "<<contador;
}
