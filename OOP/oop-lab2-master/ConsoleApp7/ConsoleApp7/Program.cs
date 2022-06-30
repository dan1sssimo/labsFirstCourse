using System;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int Parni = 0, NeParni = 0, Dod = 0, Vid = 0, number = 1;
            Console.WriteLine("Vvedit chusla\nPru zakinchenni vvedenya natusnit '0'");
            while (number != 0)
            {
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                { break; }
                if (number % 2 == 0)
                { Parni++; }
                else
                { NeParni++; }
                if (number > 0)
                { Dod++; }
                else
                { Vid++; }
            }
            Console.WriteLine($"Kilkist parnuh = {Parni}, Kilkist ne parnuh = {NeParni} Kilkist dodatnih = {Dod} Kilkist vid`emnuh = {Vid}");
        }
    }
}

