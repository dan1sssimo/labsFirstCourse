#include <stdio.h>
#include <Windows.h>
#include <time.h>
union SetNumb
{
	signed short number;
	struct
	{
		unsigned char b0 : 1;
		unsigned char b1 : 1;
		unsigned char b2 : 1;
		unsigned char b3 : 1;
		unsigned char b4 : 1;
		unsigned char b5 : 1;
		unsigned char b6 : 1;
		unsigned char b7 : 1;
		unsigned char b8 : 1;
		unsigned char b9 : 1;
		unsigned char b10 : 1;
		unsigned char b11 : 1;
		unsigned char b12 : 1;
		unsigned char b13 : 1;
		unsigned char b14 : 1;
		unsigned char b15 : 1;
	}Finish;

};
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	SetNumb l;
	printf("Введіть число: ");
	scanf_s("%hhd", &l.number);

	if (l.Finish.b0 == 0)
	{
		printf("Число є позитивним(+)");
	}
	else
	{
		printf("Число є негативним(-)");
	}
}