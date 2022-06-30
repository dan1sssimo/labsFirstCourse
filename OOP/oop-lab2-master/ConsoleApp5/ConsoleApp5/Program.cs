using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double N, K, n = 0, result = 0;
            Console.WriteLine("Vvedit N");
            while (!double.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Zminna 'N' moje prujnatu tilki chuslovi znachennya!");
                Console.WriteLine("Vvedit znachennya 'N'");
            }
            N = Convert.ToDouble(N);
            Console.WriteLine("Vvedit K");
            while (!double.TryParse(Console.ReadLine(), out K))
            {
                Console.WriteLine("Zminna 'K' moje prujnatu tilki chuslovi znachennya!");
                Console.WriteLine("Vvedit znachennya 'K'");
            }
            K = Convert.ToDouble(K);
            n = N;
            for (double i = 1; i <= n; i++)
            {
                result = result - Math.Pow(N, K);
                N--;
            }
            Console.WriteLine(result);
        }
    }
}
