using System;

using System.Text;

namespace Task_2
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
            double S, S2, rez, x, y, z,e,S1,S3;
            bool vubir = true;
            while (vubir == true)
            {
                do
                {
                    Console.Write("Введіть значення x = ");
                    vubir = double.TryParse(Console.ReadLine(), out x);
                    if (!vubir)
                        Console.WriteLine("  Помилка введення значення x. Будь-ласка повторіть введення значення ще раз!");
                } while (!vubir);
                do
                {
                    Console.Write("Введіть значення y = ");
                    vubir = double.TryParse(Console.ReadLine(), out y);
                    if (!vubir)
                        Console.WriteLine("  Помилка введення значення y. Будь-ласка повторіть введення значення ще раз!");
                } while (!vubir);
     
                do
                {
                    Console.Write("Введіть значення z = ");
                    vubir = double.TryParse(Console.ReadLine(), out z);
                    if (!vubir)
                        Console.WriteLine("  Помилка введення значення z. Будь-ласка повторіть введення значення ще раз!");
                } while (!vubir);
                do
                {
                    Console.Write("Введіть значення e = ");
                    vubir = double.TryParse(Console.ReadLine(), out e);
                    if (!vubir)
                        Console.WriteLine("  Помилка введення значення e. Будь-ласка повторіть введення значення ще раз!");
                } while (!vubir);

                e = Convert.ToDouble(e);
                S = Math.Pow(2,-x);
                S1 =Math.Sqrt(x+Math.Pow(Math.Abs(y),0.25));
                S2 =Math.Pow(Math.Pow(e,(x-1)/Math.Sin(z)),1.0/3.0);
                S3 = S * S1 * S2;
                Console.WriteLine("r = {0:F3}", S3);
                Console.WriteLine("Продовжити ввід інформації - true, EXIT - false");
                vubir = bool.Parse(Console.ReadLine());
            }
        }
    }
}
