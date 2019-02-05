#include "Conta.h"

int main() {
	_tsetlocale(LC_ALL, "portuguese");

	string tit;
	int num, escolha;
	Conta c1;
	cout << "titular :\n";
	//cin >> tit;
	std::getline(std::cin, tit);
	c1.setTitular(tit);
	cout << "n�mero de conta: \n";
	cin >> num;
	c1.setNumero(num);
	c1.alterarEstado();
	system("cls");
	do {
		cout << "\nBanco Bom\n\nEscolha a sua op��o: \n\n[1] Levantamentos\n[2] Dep�sitos\n[3] Cr�ditos\n[4] Estado da conta\n[0] Sair\n";
		cin >> escolha;
		system("cls");
		cout << "\n";
		switch (escolha) {
		case 1:
			cout << "o seu saldo atual � :" + to_string(c1.getSaldo()) + "\nvalor a levantar: \n";
			double levantamento;
			cin >> levantamento;
			if (c1.levantar(levantamento) == -1)
				cout << "Saldo insuficiente para o levantamento!";
			else
				cout << "Levantamento realizado com sucesso!";
			break;
		case 2:
			cout << "O seu saldo atual � :" + to_string(c1.getSaldo()) + "\nvalor a depositar: \n";
			double deposito;
			cin >> deposito;
			if (c1.depositar(deposito) == 0)
				cout << "Dep�sito realizado com sucesso!";
			else
				cout << "Dep�sito com valor inv�lido!";
			break;
		case 3:
			cout << "Aprovado cr�dito at�: " + to_string(c1.credito()) + "\n";
			break;
		case 4:
			cout << c1.toString();
			system("pause");
			break;
		default:
			break;
		}
	} while (escolha != 0);
	system ("pause");
}