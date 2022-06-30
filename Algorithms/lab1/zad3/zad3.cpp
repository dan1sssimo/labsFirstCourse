#include <stdio.h>
#include <Windows.h>
#include <time.h>
union TwoNum
{
	float num;
	struct
	{
		unsigned short b0 : 1;
		unsigned short b1 : 1;
		unsigned short b2 : 1;
		unsigned short b3 : 1;
		unsigned short b4 : 1;
		unsigned short b5 : 1;
		unsigned short b6 : 1;
		unsigned short b7 : 1;
		unsigned short b8 : 1;
		unsigned short b9 : 1;
		unsigned short b10 : 1;
		unsigned short b11 : 1;
		unsigned short b12 : 1;
		unsigned short b13 : 1;
		unsigned short b14 : 1;
		unsigned short b15 : 1;
		unsigned short b16 : 1;
		unsigned short b17 : 1;
		unsigned short b18 : 1;
		unsigned short b19 : 1;
		unsigned short b20 : 1;
		unsigned short b21 : 1;
		unsigned short b22 : 1;
		unsigned short b23 : 1;
		unsigned short b24 : 1;
		unsigned short b25 : 1;
		unsigned short b26 : 1;
		unsigned short b27 : 1;
		unsigned short b28 : 1;
		unsigned short b29 : 1;
		unsigned short b30 : 1;
		unsigned short b31 : 1;

	}RecordTwoNum;
	struct
	{
		unsigned short a0 : 8;
		unsigned short a1 : 8;
		unsigned short a2 : 8;
		unsigned short a3 : 8;
	}FourINDNum;
};
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	TwoNum Record;
	float numb;
	printf("Введіть число: ");
	scanf_s("%f", &numb);
	Record.num = numb;
	printf("Значенння побітово\n");
	printf("%d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d", Record.RecordTwoNum.b31, Record.RecordTwoNum.b30, Record.RecordTwoNum.b29, Record.RecordTwoNum.b28, Record.RecordTwoNum.b27, Record.RecordTwoNum.b26, Record.RecordTwoNum.b25, Record.RecordTwoNum.b24, Record.RecordTwoNum.b23, Record.RecordTwoNum.b22, Record.RecordTwoNum.b21, Record.RecordTwoNum.b20, Record.RecordTwoNum.b19, Record.RecordTwoNum.b18, Record.RecordTwoNum.b17, Record.RecordTwoNum.b16, Record.RecordTwoNum.b15, Record.RecordTwoNum.b14, Record.RecordTwoNum.b13, Record.RecordTwoNum.b12, Record.RecordTwoNum.b11, Record.RecordTwoNum.b10, Record.RecordTwoNum.b9, Record.RecordTwoNum.b8, Record.RecordTwoNum.b7, Record.RecordTwoNum.b6, Record.RecordTwoNum.b5, Record.RecordTwoNum.b4, Record.RecordTwoNum.b3, Record.RecordTwoNum.b2, Record.RecordTwoNum.b1, Record.RecordTwoNum.b0);
	printf("\nРозділене число %0.1f на 4 окремих байта\n", numb);
	printf("%d %d %d %d", Record.FourINDNum.a0, Record.FourINDNum.a1, Record.FourINDNum.a2, Record.FourINDNum.a3);
	if (Record.RecordTwoNum.b31 == 0)
	{
		printf("\nЗнак: 0 (+)\n");
	}
	else
	{
		printf("\nЗнак: 1 (-)\n");
	}
	printf("Cтепінь\n%d%d%d%d%d%d%d%d\n", Record.RecordTwoNum.b30, Record.RecordTwoNum.b29, Record.RecordTwoNum.b28, Record.RecordTwoNum.b27, Record.RecordTwoNum.b26, Record.RecordTwoNum.b25, Record.RecordTwoNum.b24);
	printf("Мантиса\n%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d%d\n", Record.RecordTwoNum.b22, Record.RecordTwoNum.b21, Record.RecordTwoNum.b20, Record.RecordTwoNum.b19, Record.RecordTwoNum.b18, Record.RecordTwoNum.b17, Record.RecordTwoNum.b16, Record.RecordTwoNum.b15, Record.RecordTwoNum.b14, Record.RecordTwoNum.b13, Record.RecordTwoNum.b12, Record.RecordTwoNum.b11, Record.RecordTwoNum.b10, Record.RecordTwoNum.b9, Record.RecordTwoNum.b8, Record.RecordTwoNum.b7, Record.RecordTwoNum.b6, Record.RecordTwoNum.b5, Record.RecordTwoNum.b4, Record.RecordTwoNum.b3, Record.RecordTwoNum.b2, Record.RecordTwoNum.b1, Record.RecordTwoNum.b0);
}