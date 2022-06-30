#include <iostream>
#include <Windows.h>
#include <clocale>
#include <iomanip>
#include <time.h>

using namespace std;

struct List
{
    List() : Next(nullptr), Prev(nullptr) {}
    int info;
    List* Next, * Prev;
};

void InsertionSort(List* head)
{

    List* curr = nullptr, * prev = nullptr;
    for (curr = head->Next; curr->Next; curr = curr->Next)
    {
        int tmp = curr->info;
        for (prev = curr->Prev; prev && prev->info > tmp; prev = prev->Prev)
        {
            prev->Next->info = prev->info;
        }
        prev->Next->info = tmp;
    }
}

List* InsertElementIntoList(List* last, List* p)
{
    if (last != NULL || p != NULL)
    {
        p->Prev = last;
        p->Next = last->Next;
        last->Next = p;
        p->Next->Prev = p;
        return p;
    }
    else
        return NULL;
}

void CreateRandomList(List*& head, List*& tail, int n)
{
    head = new List;
    tail = new List;

    head->Next = tail;
    tail->Prev = head;

    srand(time(NULL));

    List* last;
    last = head;

    for (int i = 0; i < 100000; i++)
    {
        List* p = new List;
        p->info = rand() % 200 - 100;
        last = InsertElementIntoList(last, p);
    }
}

void PrintList(List* head, List* tail)
{
    List* p = head->Next;
    while (p != tail)
    {
        cout << setw(6) << p->info;
        p = p->Next;
    }
    cout << endl;
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    srand(time(0));
    float dd;
    clock_t start, finish;
    start = clock();
    List* head, * tail;
    CreateRandomList(head, tail, 10);
    cout << "Список: \n";
    PrintList(head, tail);
    InsertionSort(head);
    finish = clock();
    cout << "Відсортований список: \n";
    PrintList(head, tail);
    dd = (float)(finish - start) / CLOCKS_PER_SEC;
    printf("\nЧас виконання програми: %f секунд", dd);
    return 0;
}