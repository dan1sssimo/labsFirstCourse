#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;

void bubbleSort(int*, int);

int main(int argc, char* argv[])
{
    srand(time(NULL));
    setlocale(LC_ALL, "rus");
    int* sorted_array = new int[1024];
    for (int counter = 0; counter < 1024; counter++)
    {
        sorted_array[counter] = rand() % 100;
        printf("%d", sorted_array[counter]);
        printf("\t");
    }
    printf("\nВiдсортований масив\n");
    clock_t start = clock();
    bubbleSort(sorted_array, 1024);
    for (int counter = 0; counter < 1024; counter++)
    {
        printf("%d", sorted_array[counter]);
        printf("\t");
    }
    clock_t end = clock();
    double seconds = (double)(end - start) / CLOCKS_PER_SEC;
    printf("\nThe time of working: %f seconds\n", seconds);
    system("pause");
    return 0;
}

void bubbleSort(int* arrayPtr, int length_array)
{
    int temp = 0;
    for (int i = 0; i < length_array - 1; i++) {
        for (int j = 0; j < length_array - i - 1; j++) {
            if (arrayPtr[j] < arrayPtr[j + 1]) {
                temp = arrayPtr[j];
                arrayPtr[j] = arrayPtr[j + 1];
                arrayPtr[j + 1] = temp;
            }
        }
    }
}