using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    //простий варіант сортування підрахунком
    static int[] CountingSort(int[] array)
    {
        //пошук мінімального та максимального значень
        var min = array[0];
        var max = array[0];
        foreach (int element in array)
        {
            if (element > max)
            {
                max = element;
            }
            else if (element < min)
            {
                min = element;
            }
        }

        //поправка
        var correctionFactor = min != 0 ? -min : 0;
        max += correctionFactor;

        var count = new int[max + 1];
        for (var i = 0; i < array.Length; i++)
        {
            count[array[i] + correctionFactor]++;
        }

        var index = 0;
        for (var i = 0; i < count.Length; i++)
        {
            for (var j = 0; j < count[i]; j++)
            {
                array[index] = i - correctionFactor;
                index++;
            }
        }

        return array;
    }
    //метод для отримання масиву заповненого випадковими числами
    static int[] GetRandomArray(int arraySize, int minValue, int maxValue)
    {
        var random = new Random();
        var randomArray = new int[arraySize];
        for (var i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = random.Next(minValue, maxValue);
        }

        return randomArray;
    }

    static void Main(string[] args)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        var arr = GetRandomArray(10, -10, 40);
        Console.WriteLine("Вхiднi данi: {0}", string.Join(", ", arr));
        Console.WriteLine("Впорядкований масив: {0}", string.Join(", ", CountingSort(arr)));
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
        Console.ReadLine();

    }
}