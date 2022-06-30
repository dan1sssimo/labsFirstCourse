using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
             System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            bool ok;
            int N, Z;
            double rez = 0, tmp;
            do
            {
                Write("Введіть кількість елементів масиву:");
                ok = int.TryParse(ReadLine(), out N);
                if (!ok) WriteLine("Помилка введення значення.Будь ласка повторіть введення раз!");
            } while (!ok);
            double[] mas = new double[N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                mas[i] = rnd.Next(-8541, 3531) / 1000.0;
                Write("{0,7}", mas[i]);
                if (i == N - 1)
                    Write("\t");

                if (i % 3 != 0)
                {
                    rez += (mas[i]);
                }
            }
            Write("\n");
            WriteLine("Сума елементів з індексами, які не діляться на 3: {0}", Round(rez, 3));
            for (int i = 1; i < N; i++)
            {
                tmp = mas[i];
                for (int j = i - 1; j >= 0 && mas[j] > tmp; j--)
                {
                    mas[j + 1] = mas[j];
                    mas[j] = tmp;
                }
            }
            for (int i = 0; i < N; i++)
                Write("{0,7}", mas[i]);
            Write("\t");

        }

    }
}
