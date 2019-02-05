//ee. Elabore um programa que lê um vector VEC_ORIGINAL de N elementos e os reescreva num outro vector VEC_ORDENADO por ordem crescente.
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int a, i, j, aux;
	cout<< "indique o tamanho do vector:\n";
	cin>> a;
	int *vecA = new int[a];
	for(i=0;i<a;i++){
		cout<< "insira o "<<i+1<<"º número:\n";
		cin>> vecA[i];
	}
	for(i=0;i<a-1;i++){
		for(j=i+1;j<a;j++){
			if(vecA[i]>vecA[j]){
			aux=vecA[i];
			vecA[i]=vecA[j];
			vecA[j]=aux;
			}	
		}
	}
	for(i=0;i<a;i++)
		cout<<vecA[i]<<"	";
}
