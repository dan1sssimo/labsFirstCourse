using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;//щоб не писати Math
using static System.Console;// щоб не писати Console
namespace Arrays2DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture =
           (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            bool ok;
            int M, N;
            int count = 0;
            double tmp;
            do
            {
                Write("Введіть кількість рядків масиву:");
                ok = int.TryParse(ReadLine(), out N);
                if (!ok) WriteLine("Помилка введення значення.Будь ласка повторіть введення ще раз!");
            } while (!ok);
            do
            {
                Write("Введіть кількість стовпчиків масиву:");
                ok = int.TryParse(ReadLine(), out M);
                if (!ok) WriteLine("Помилка введення значення.Будь ласка повторіть введення ще раз!");
            } while (!ok);
            double[,] arr = new double[N, M];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-108005, 5103) / 1000.0;
                    Write("{0,9}", arr[i, j]);
                }
                WriteLine();
            }
            // - elementi
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)
                    {
                        count++;
                        break;
                    }
                }
            }
            WriteLine("Кількість рядків, які не містять жодного від’ємного елемента :{0}\n",(arr.GetLength(0) - count));
            for (int i = 0; i < N / 2; i++)
                for (int j = 0; j < M; j++)
                {
                    tmp = arr[i, j];
                    arr[i, j] = arr[M - i - 1, j];              
                    arr[M - i - 1, j] = tmp;
                }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    Write("{0,9}", arr[i, j]);
                WriteLine();
            }
        }
    }
}
