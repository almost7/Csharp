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
	cout << "número de conta: \n";
	cin >> num;
	c1.setNumero(num);
	c1.alterarEstado();
	system("cls");
	do {
		cout << "\nBanco Bom\n\nEscolha a sua opção: \n\n[1] Levantamentos\n[2] Depósitos\n[3] Créditos\n[4] Estado da conta\n[0] Sair\n";
		cin >> escolha;
		system("cls");
		cout << "\n";
		switch (escolha) {
		case 1:
			cout << "o seu saldo atual é :" + to_string(c1.getSaldo()) + "\nvalor a levantar: \n";
			double levantamento;
			cin >> levantamento;
			if (c1.levantar(levantamento) == -1)
				cout << "Saldo insuficiente para o levantamento!";
			else
				cout << "Levantamento realizado com sucesso!";
			break;
		case 2:
			cout << "O seu saldo atual é :" + to_string(c1.getSaldo()) + "\nvalor a depositar: \n";
			double deposito;
			cin >> deposito;
			if (c1.depositar(deposito) == 0)
				cout << "Depósito realizado com sucesso!";
			else
				cout << "Depósito com valor inválido!";
			break;
		case 3:
			cout << "Aprovado crédito até: " + to_string(c1.credito()) + "\n";
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