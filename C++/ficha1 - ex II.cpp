//ii. Elabore um programa que guarde numa estrutura de dados adequada os dados de N alunos de uma turma: n�mero de aluno e idade. Imprima o n�mero dos alunos com idade compreendida entre 16 e 20.
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int n, i;
	cout<<"quantos alunos tem a turma?\n";
	cin>>n;
	int **mat = new int*[n];
	for(i=0;i<n;i++){
		mat[i]=new int[2];
		cout<<"n�mero do "<<i+1<<"� aluno: \n";
		cin>>mat[i][0];
		cout<<"qual a sua idade?\n";
		cin>>mat[i][1];
	}
	system ("cls");
	cout<<"n�mero dos alunos com idade entre 16 e 20 anos: \n";
	for(i=0;i<n;i++)
		if(mat[i][1]>=16 && mat[i][1]<=20)
			cout<<mat[i][0]<<"\n";
}
