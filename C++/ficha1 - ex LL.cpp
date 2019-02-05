//ll. Elabore um programa que lê uma matriz MAT de L e C colunas, preenchida com valores inteiros e mostre o centro da matriz.
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>
#include <iomanip>

/* 
precisa da biblioteca: <iomanip>
cout<< fixed << setprecision(2) << variavel; (isto define as casas decimais a 2 = exemplo: 3.14)     
OU      
cout<< setprecision(2) << variavel (isto define as casas totais a 2 = exemplo: 3.1)
*/


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
	system ("cls");
	if(a%2==0){
		if(b%2==0){
			cout<<"O centro da matriz é composto por 4 valores:\n\n"; 
			cout<<"["<<mat[a/2-1][b/2-1]<<"] "<<"["<<mat[a/2-1][b/2]<<"]\n";
			cout<<"["<<mat[a/2][b/2-1]<<"] "<<"["<<mat[a/2][b/2]<<"]";			
		}
		else{
			cout<<"O centro da matriz é composto por 2 valores:\n\n"; 
			cout<<"["<<mat[a/2-1][b/2]<<"]\n";
			cout<<"["<<mat[a/2][b/2]<<"]";
		}
	}
	else{
		if(b%2==0){
			cout<<"O centro da matriz é composto por 2 valores:\n\n"; 			
			cout<<"["<<mat[a/2][b/2-1]<<"] "<<"["<<mat[a/2][b/2]<<"]\n";
		}
		else{
			cout<<"O centro da matriz é composto por 1 valor:\n\n"; 			
			cout<<"["<<mat[a/2][b/2]<<"]";
		}
	}
}
