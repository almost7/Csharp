//dd. Dados dois vectores VEC1 e VEC2, escreva no ecrã os elementos comuns aos dois vectores.

#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int a, b, i, j, k, flag=0;
	cout<< "indique o tamanho do vector:\n";
	cin>> a;
	int *vecA = new int[a];
	cout<< "indique o tamanho do vector:\n";
	cin>> b;
	int *vecB = new int[b];
	for(i=0;i<a;i++){
		cout<< "insira o "<<i+1<<"º número:\n";
		cin>> vecA[i];
	}
	for(i=0;i<b;i++){
		cout<< "insira o "<<i+1<<"º número:\n";
		cin>> vecB[i];	
	}	
	for(i=0;i<a-1;i++){
		flag=0;
		for(j=0;j<i;j++){
			if(vecA[i]==vecA[j]);
			flag=1;
			j=i;
		}
		if(flag==0);
		for(k=0;k<b;k++){
			if(vecA[i]==vecB[k]){
				cout<<vecA[i]<<"	";
				k=b;
			}
		}
	}	
	
}
