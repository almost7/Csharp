//aa. Dado um vector de K elementos determine a maior diferença entre dois elementos consecutivos.

#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int k, i, maiorDif=0;
	cout<< "indique o tamanho do vector:\n";
	cin>> k;
	int *vec = new int[k];
	for(i=0;i<k;i++){
		cout<< "insira o "<<i+1<<"º número:\n";
		cin>> vec[i];
	}
	//cout<<abs(vec[0]-vec[1]);
	for(i=0;i<k-1;i++)
		if(abs(vec[i]-vec[i+1])>maiorDif)
			maiorDif=abs(vec[i]-vec[i+1]);
	cout<< "a maior diferença é de: "<<maiorDif;
}
