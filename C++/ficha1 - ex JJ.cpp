//jj. Elabore um programa que guarde numa estrutura de dados adequada os dados de N alunos de uma turma: n�mero de aluno e m�dia final. Imprima o n�mero do aluno com melhor m�dia e respetiva m�dia.
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
		cout<<"n�mero do "<<i+1<<"� aluno: \n";
		cin>>mat[i][0];
		cout<<"qual a sua m�dia final?\n";
		cin>>mat[i][1];
		if(mat[i][1]>melhorMedia){
			melhorMedia=mat[i][1];
			melhorAluno=mat[i][0];
		}
	}
	system ("cls");
	cout<<"O aluno com a melhor m�dia foi o aluno "<<melhorAluno<<" com uma m�dia de "<<melhorMedia;
}
