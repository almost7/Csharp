//hh. Elabore um programa que guarde numa estrutura de dados adequada os dados de N funcionários de uma empresa: número de funcionário e salário. Imprima o número dos funcionários com salário superior a 1000€.
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int n, i;
	cout<<"quantos funcionários tem a empresa?\n";
	cin>>n;
	int **mat = new int*[n];
	for(i=0;i<n;i++){
		mat[i]=new int[2];
		cout<<"número do "<<i+1<<"º funcionário: \n";
		cin>>mat[i][0];
		cout<<"qual o seu ordenado?\n";
		cin>>mat[i][1];
	}
	system ("cls");
	cout<<"número dos funcionários com ordenado superior a 1000 EUR: \n";
	for(i=0;i<n;i++)
		if(mat[i][1]>1000)
			cout<<mat[i][0]<<"\n";
}
