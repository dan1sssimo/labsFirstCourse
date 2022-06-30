#include <iostream>
#include <chrono>
#include <math.h>
#include <time.h>
int factorial(long float i)
{
	if (i == 0)
		return 1;
	else return
		i * factorial(i - 1);
}
int main()
{
	long float a = 0, b = 50, h = 1, x;
	long float y = 1;
	int ok = 0;
	printf("Vuberit funkziu:");
	scanf_s("%d", &ok);
	switch (ok)
	{
	case 1: {
		clock_t start = clock();
		for (x = a; x < b + h; x += h)
		{
			y = x;
			printf("x=%.3f, y=%.3f\n", x, y);
		}
		clock_t end = clock();
		double seconds = (double)(end - start) / CLOCKS_PER_SEC;
		printf("The time of working: %f seconds\n", seconds);
		break;
	}
	case 2: {
		clock_t start = clock();
		for (x = a; x < b + h; x += h)
		{
			y = log(x);
			printf("x=%.3f, y=%.3f\n", x, y);
		}
		clock_t end = clock();
		double seconds = (double)(end - start) / CLOCKS_PER_SEC;
		printf("The time of working: %f seconds\n", seconds);
		break;
	}
	case 3: {
		clock_t start = clock();
		for (x = a; x < b + h; x += h)
		{
			y = x * log(x);
			printf("x=%.3f, y=%.3f\n", x, y);
		}
		clock_t end = clock();
		double seconds = (double)(end - start) / CLOCKS_PER_SEC;
		printf("The time of working: %f seconds\n", seconds);
		break;
	}
	case 4: {
		clock_t start = clock();
		for (x = a; x < b + h; x += h)
		{
			y = pow(x, 2);
			printf("x=%.3f, y=%.3f\n", x, y);
		}
		clock_t end = clock();
		double seconds = (double)(end - start) / CLOCKS_PER_SEC;
		printf("The time of working: %f seconds\n", seconds);
		break;
	}
	case 5: {
		clock_t start = clock();
		for (x = a; x < b + h; x += h)
		{
			y = pow(2, x);
			printf("x=%.3f, y=%.3f\n", x, y);
		}
		clock_t end = clock();
		double seconds = (double)(end - start) / CLOCKS_PER_SEC;
		printf("The time of working: %f seconds\n", seconds);
		break;
	}
	case 6: {
		clock_t start = clock();
		for (x = a; x < b + h; x += h)
		{
			y = factorial(x);
			printf("x=%.3f, y=%.3f\n", x, y);
		}
		clock_t end = clock();
		double seconds = (double)(end - start) / CLOCKS_PER_SEC;
		printf("The time of working: %f seconds\n", seconds);
		break;
	}

	}


}