//hh. Elabore um programa que guarde numa estrutura de dados adequada os dados de N funcion�rios de uma empresa: n�mero de funcion�rio e sal�rio. Imprima o n�mero dos funcion�rios com sal�rio superior a 1000�.
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int n, i;
	cout<<"quantos funcion�rios tem a empresa?\n";
	cin>>n;
	int **mat = new int*[n];
	for(i=0;i<n;i++){
		mat[i]=new int[2];
		cout<<"n�mero do "<<i+1<<"� funcion�rio: \n";
		cin>>mat[i][0];
		cout<<"qual o seu ordenado?\n";
		cin>>mat[i][1];
	}
	system ("cls");
	cout<<"n�mero dos funcion�rios com ordenado superior a 1000 EUR: \n";
	for(i=0;i<n;i++)
		if(mat[i][1]>1000)
			cout<<mat[i][0]<<"\n";
}
