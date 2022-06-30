#include <iostream>
#include <iostream>
#include <time.h>
int fibonacci(int number)
{
    if (number == 0)
        return 0;
    if (number == 1)
        return 1;
    return fibonacci(number - 1) + fibonacci(number - 2);
}

int main()
{
    int m = 0;
    printf("Vvedit chuslo m:");
    scanf_s("%d", &m);
    clock_t start = clock();
    for (int i = m; i <= 40; i++)
        printf("%d\n", fibonacci(i));
    clock_t end = clock();
    double seconds = (double)(end - start) / CLOCKS_PER_SEC;
    printf("The time of working: %f seconds\n", seconds);

    return 0;
}