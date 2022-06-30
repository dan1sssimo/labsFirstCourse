using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double  a, b, c, S1, S3,x1,x2,D;
            bool vubir = true;
            while (vubir == true)
            {
                do
                {
                    Console.Write("Введіть значення a = ");
                    vubir = double.TryParse(Console.ReadLine(), out a);
                    if (!vubir)
                        Console.WriteLine("  Помилка введення значення x. Будь-ласка повторіть введення значення ще раз!");
                } while (!vubir);
                do
                {
                    Console.Write("Введіть значення b = ");
                    vubir = double.TryParse(Console.ReadLine(), out b);
                    if (!vubir)
                        Console.WriteLine("  Помилка введення значення y. Будь-ласка повторіть введення значення ще раз!");
                } while (!vubir);

                do
                {
                    Console.Write("Введіть значення c = ");
                    vubir = double.TryParse(Console.ReadLine(), out c);
                    if (!vubir)
                        Console.WriteLine("  Помилка введення значення z. Будь-ласка повторіть введення значення ще раз!");
                } while (!vubir);
                D = (Math.Pow(b, 2.0)) - 4 * a * c;
                if (D == 0)
                { 
                    x1 = -b / (2 * a);
                    Console.WriteLine("x = {0:F3}", x1);
                }
                if (D < 0)
                {
                    Console.WriteLine("Розв'язків немає");

                }
                if (D > 0)
                {
                   
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("x1 = {0:F3}", x1);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("x2 = {0:F3}", x2);
                }
                Console.WriteLine("Продовжити ввід інформації - true, EXIT - false");
                vubir = bool.Parse(Console.ReadLine());
            }
        }
    }
}
