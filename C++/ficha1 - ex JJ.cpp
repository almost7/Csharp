//jj. Elabore um programa que guarde numa estrutura de dados adequada os dados de N alunos de uma turma: número de aluno e média final. Imprima o número do aluno com melhor média e respetiva média.
#include <iostream>
#include <windows.h>
#include <tchar.h>
#include <string>
#include <cmath>

using namespace std;

int main(){
	_tsetlocale(LC_ALL, "portuguese");
	
	int n, i, melhorAluno=0;
	float melhorMedia=0;
	cout<<"quantos alunos tem a turma?\n";
	cin>>n;
	float **mat = new float*[n];
	for(i=0;i<n;i++){
		mat[i]=new float[2];
		cout<<"número do "<<i+1<<"º aluno: \n";
		cin>>mat[i][0];
		cout<<"qual a sua média final?\n";
		cin>>mat[i][1];
		if(mat[i][1]>melhorMedia){
			melhorMedia=mat[i][1];
			melhorAluno=mat[i][0];
		}
	}
	system ("cls");
	cout<<"O aluno com a melhor média foi o aluno "<<melhorAluno<<" com uma média de "<<melhorMedia;
}
