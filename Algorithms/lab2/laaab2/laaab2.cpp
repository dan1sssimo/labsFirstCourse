#include <stdio.h>
#include <time.h>
#include <math.h>
#include <windows.h>
#define RAND_MAX 300 

short Checked(unsigned int array[], unsigned int num)
{
	short tmp = 0;
	for (int i = 0; i < 1000; i++)
	{
		if (array[i] == num)
		{
			tmp++;
		}
	}
	return tmp;
}

unsigned long next = 1;
int randomizing()
{
	next = next * 14807;
	return((unsigned int)(next / 65536) % RAND_MAX);
}


int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	unsigned int a = 69069, c = 1, len = 1000;
	unsigned int m = (pow(2, 32));
	unsigned int* values;
	values = (unsigned int*)malloc(sizeof(unsigned int) * len);
	for (int i = 0; i < len; i++)
	{
		values[i] = randomizing();
	}

	short frequency[1000];

	printf("Частота інтервалів випадкових чисел:\n");

	for (int i = 0; i < len; i++)
	{
		frequency[i] = Checked(values, values[i]);
		printf("Value №%d = %d\n", i, values[i]);
	}

	double statistic[1000];

	printf("Статистична ймовірність випадкових чисел:\n");

	for (int i = 0; i < len; i++) {
		statistic[i] = ((double)frequency[i] / len);
		printf("Value №%d = %0.4f\n", i, statistic[i]);
	}

	double mathExp = 0;

	for (int i = 0; i < len; i++)
	{
		mathExp += i * statistic[i];
	}

	printf("\nМатематичне очікування: %f", mathExp);

	double dyspersion = 0;
	for (int i = 0; i < len; i++)
	{
		dyspersion += pow((i - mathExp), 2) * statistic[i];
	}
	printf("\nДисперсія випадкових чисел: %f", dyspersion);
	printf("\nВідхилення випадкових чисел: %f\n", sqrt(dyspersion));
	system("pause");
}