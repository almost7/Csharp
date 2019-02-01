#include <iostream>
#include <string>
#include <windows.h>

using namespace std;

void menu {
	string Menu[3] = {"numero", "outra opcao", "saida"};
	int pointer = 0;
	system("cls");
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
	cout << "Main Menu\n\n";
	for (int i = 0; i < 3; ++i) {
		if (i == pointer)
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 11);
			cout << Menu[i] << endl;
	}
	else {
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << Menu[i] << endl;
	}
	GetAsyncKeyState(VK_RETURN);
}


int main()
{

	while (pointer=!3) {
		
		GetAsyncKeyState(VK_RETURN)
		while (true)
		{
			if (GetAsyncKeyState(VK_UP) != 0)
			{
				pointer -= 1;
				if (pointer == -1)
				{
					pointer = 1;
				}
				break;
			}
			else if (GetAsyncKeyState(VK_DOWN) != 0)
			{
				pointer += 1;
				if (pointer == 3)
				{
					pointer = 0;
				}
				break;
			}
			else if (GetAsyncKeyState(VK_RETURN) != 0)
			{
				switch (pointer)
				{
				case 0:
				{
					int number;
					cout << "\nEnter number --> ";
					cin >> number;
					cout << "\nThe number is ";
					cout << number;
					Sleep(1000);
					GetAsyncKeyState(VK_RETURN);
				} break;
				case 1: {
				cout << "\nsem opção certa ";
				} break;
				case 2:
					return 0;
				break;
			}
		}

		Sleep(150);
	}

	return 0;
}