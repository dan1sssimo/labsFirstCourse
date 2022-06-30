using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    //метод обміну елементів
    static void Swap(ref int a, ref int b)
    {
        var t = a;
        a = b;
        b = t;
    }

    static int[] ShellSort(int[] array)
    {
        //відстань між елементами, які порівнюються
        var d = (int)Math.Pow(3, array.Length) / 2;
        while (d >= 1)
        {
            for (var i = d; i < array.Length; i++)
            {
                var j = i;
                while ((j >= d) && (array[j - d] > array[j]))
                {
                    Swap(ref array[j], ref array[j - d]);
                    j = j - d;
                }
            }
            d = d / 2;
        }
        return array;
    }

    static void Main(string[] args)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Console.WriteLine("Сортування Шелла");
        Random rand = new Random();
        int[] s = new int[10];
        for (int i = 0; i < s.Length; i++)
        {
            s[i] = rand.Next(-10, 100);
            s[i] = Convert.ToInt32(s[i]);
        }
        Console.WriteLine("Впорядкований масив: {0}", string.Join(", ", ShellSort(s)));
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
        Console.ReadLine();
    }
}