#include <stdio.h>
#include <Windows.h>
#include <time.h>

struct Datetime
{
    unsigned char day : 6;
    unsigned char weekday : 3;
    unsigned char month : 6;
    unsigned char year : 8;
    unsigned char hour : 5;
    unsigned char min : 6;
    unsigned char sec : 6;
} datetime;

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    int time1 = sizeof(tm);
    printf("Розмір структури без використання побітових полів  = %d\n", time1);
    int time2 = sizeof(Datetime);
    printf("Розмір структури з використанням побітових полів  = %d\n", time2);
    printf("1 = %d\n2 = %d\n", time1, time2);
    unsigned short day;
    printf("Введіть день (0-31):");
    scanf_s("%hhd", &day);
    datetime.day = day;
    unsigned short weekday;
    scanf_s("%hhd", &weekday);
    datetime.weekday = weekday;





    unsigned short month;
    printf("Введіть місяць (0-12):");
    scanf_s("%hhd", &month);
    datetime.month = month;
    unsigned short year;
    printf("Введіть рік (0-99):");
    scanf_s("%hhd", &year);
    datetime.year = year;
    unsigned short hour;
    printf("Введіть час (0-23):");
    scanf_s("%hhd", &hour);
    datetime.hour = hour;
    printf("Введіть хвилини (0-59):");
    unsigned short min;
    scanf_s("%hhd", &min);
    datetime.min = min;
    printf("Введіть секунди (0-60):");
    unsigned short sec;
    scanf_s("%hhd", &sec);
    datetime.sec = sec;
    printf("Дата: %hhd . %hhd . %hhd\n\n", day, month, year);
    printf("Час: %hhd : %hhd : %hhd\n", hour, min, sec);
}