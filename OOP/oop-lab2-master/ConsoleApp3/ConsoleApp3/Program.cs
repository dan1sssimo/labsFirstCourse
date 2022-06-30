using System;

using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Консольна програма для розрахунку loooooong рівняння
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double S1, S2, rez, x, y, z;
            bool vubir = true;
            while (vubir == true)
            {
                Console.WriteLine("Введіть значення 'x'");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Введіть значення 'x'");
                }
                x = Convert.ToDouble(x);

                Console.WriteLine("Введіть значення 'y'");
                while (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Введіть значення 'y'");
                }
                y = Convert.ToDouble(y);

                Console.WriteLine("Введіть значення 'z'");
                while (!double.TryParse(Console.ReadLine(), out z))
                {
                    Console.WriteLine("Введіть значення 'z'");
                }
                z = Convert.ToDouble(z);

                if ((z - Math.Abs(x + y)) > 1 || ((z - Math.Abs(x + y)) < -1))
                {
                    Console.WriteLine("Помилка введення значення x та y!!!\nПри використанні данних значень x та y функція 'SIN' не буде належати проміжку [-1;1]");
                }
                if (10 * (Math.Pow(x, 1 / 3.0) + Math.Pow(x, y + 2.0)) < 0)
                {
                    Console.WriteLine("Помилка введення значення x та y!!!");
                }

                S1 = Math.Sqrt(10 * (Math.Pow(x, 1 / 3.0) + Math.Pow(x, y + 2.0)));
                S2 = Math.Asin(z - Math.Abs(x + y));
                rez = S2 * S2;
                Console.WriteLine("r = {0:F3}", rez);


                Console.WriteLine("Продовжити ввід інформації - true, EXIT - false");
                vubir = bool.Parse(Console.ReadLine());
            }
        }
    }
}
