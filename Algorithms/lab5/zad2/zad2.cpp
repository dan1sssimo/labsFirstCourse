#include <stdio.h>
#include <windows.h>
#include <time.h>

void fill_array(int n, int* arr);
void sort_insertion(int n, int* arr);
void sort_selection(int n, int* arr);
void main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	srand(time(NULL));
	int amount;

	printf("Оберіть кількість елементів в масиві для сортування: ");
	scanf_s("%d", &amount);
	int* arr1 = new int[amount], * arr2 = new int[amount], * arr3 = new int[amount], * arr4 = new int[amount];


	printf("Сортування бульбашкою.\n");
	clock_t start, finish;

	printf("Сортування вставками.\n");
	start = clock();

	fill_array(amount, arr2);
	sort_insertion(amount, arr2);

	finish = clock();


	double duration2 = (double)(finish - start) / CLOCKS_PER_SEC;
	printf("Час виконання: %2f\n", duration2);



	printf("Сортування вибором.\n");
	start = clock();

	fill_array(amount, arr3);
	sort_selection(amount, arr3);

	finish = clock();


	double duration3 = (double)(finish - start) / CLOCKS_PER_SEC;
	printf("Час виконання: %2f\n", duration3);
}

void fill_array(int n, int* arr)
{
	int a = -1000, b = 1000;
	for (int i = 0; i < n; i++)
		arr[i] = a + rand() % (b - a + 1);
}

void sort_insertion(int n, int* arr)
{
	int tmp;
	for (int i = 0; i < n; i++)
	{
		tmp = arr[i];
		for (int j = i - 1; j >= 0 && arr[j] > tmp; j--)
		{
			arr[j + 1] = arr[j];
			arr[j] = tmp;
		}
	}
}

void sort_selection(int n, int* arr)
{
	int mini, tmp;
	for (int i = 0; i < n - 1; i++)
	{
		mini = i;
		for (int j = i + 1; j < n; j++)
		{
			if (arr[j] < arr[mini])
				mini = j;
			tmp = arr[i];
			arr[i] = arr[mini];
			arr[mini] = tmp;
		}
	}
}