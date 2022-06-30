using System;
using ClassLibrary1;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int k;
            do
            {
                bool ok;
                Console.WriteLine("Ввести приклад ще раз-1\n\nВихід з програми-0");
                int.TryParse(Console.ReadLine(), out k);
                if (k == 0)
                    break;
                else
                {
                    int x1, x2, y1, y2;
                    Console.WriteLine("Введіть чисельник 1 дробу");
                    int.TryParse(Console.ReadLine(), out x1);
                    Console.WriteLine("Введіть чисельник 2 дробу");
                    int.TryParse(Console.ReadLine(), out x2);
                    Console.WriteLine("Введіть знаменник 1 дробу");
                    int.TryParse(Console.ReadLine(), out y1);
                    Console.WriteLine("Введіть знаменник 2 дробу");
                    int.TryParse(Console.ReadLine(), out y2);
                    Fraction x = new Fraction(x1, y1);
                    Fraction y = new Fraction(x2, y2);
                    Console.WriteLine("Введіть дію");
                    int vuraz;
                    Console.WriteLine("Унарна дія ++ для 1 дробу-1");
                    Console.WriteLine("Унарна дія ++ для 2 дробу-2");
                    Console.WriteLine("Унарна дія -- для 1 дробу-3");
                    Console.WriteLine("Унарна дія -- для 2 дробу-4");
                    Console.WriteLine("Додавання-5");
                    Console.WriteLine("Віднімання-6");
                    Console.WriteLine("Множення-7");
                    Console.WriteLine("Ділення-8");
                    Console.WriteLine("Порівняння: 1 дріб > 2 дробу-9");
                    Console.WriteLine("Порівняння: 1 дріб < 2 дробу-10");
                    Console.WriteLine("Порівняння: 1 дріб >= 2 дробу-11");
                    Console.WriteLine("Порівняння: 1 дріб <= 2 дробу-12");
                    Console.WriteLine("Порівняння: 1 дріб == 2 дробу-13");
                    Console.WriteLine("Порівняння: 1 дріб != 2 дробу-14");
                    Console.WriteLine("Вихід-0");
                    do
                    {
                        do
                        {
                            ok = int.TryParse(Console.ReadLine(), out vuraz);
                            if (!ok)
                                Console.WriteLine("Некоректне введення! Повторіть спробу.");
                        } while (!ok);
                        switch (vuraz)
                        {
                            case 1:
                                Console.Write($"{x}++= ".ToString());
                                Console.WriteLine((x++).ToString());
                                break;
                            case 2:
                                Console.Write($"{y}++= ".ToString());
                                Console.WriteLine((y++).ToString());
                                break;
                            case 3:
                                Console.Write($"{x}--= ".ToString());
                                Console.WriteLine((x--).ToString());
                                break;
                            case 4:
                                Console.Write($"{y}--= ".ToString());
                                Console.WriteLine((y--).ToString());
                                break;
                            case 5:
                                Console.Write($"{x}+{y}= ".ToString());
                                Console.WriteLine((x + y).ToString());
                                break;
                            case 6:
                                Console.Write($"{x}-{y}= ".ToString());
                                Console.WriteLine((x - y).ToString());
                                break;
                            case 7:
                                Console.Write($"{x}*{y}= ".ToString());
                                Console.WriteLine((x * y).ToString());
                                break;
                            case 8:
                                Console.Write($"{x}:{y}= ".ToString());
                                Console.WriteLine((x / y).ToString());
                                break;
                            case 9:
                                Console.Write($"{x}>{y} це ".ToString());
                                Console.WriteLine((x > y).ToString());
                                break;
                            case 10:
                                Console.Write($"{x}<{y} це ".ToString());
                                Console.WriteLine((x < y).ToString());
                                break;
                            case 11:
                                Console.Write($"{x}>={y} це ".ToString());
                                Console.WriteLine((x >= y).ToString());
                                break;
                            case 12:
                                Console.Write($"{x}<={y} це ".ToString());
                                Console.WriteLine((x <= y).ToString());
                                break;
                            case 13:
                                Console.Write($"{x}=={y} це ".ToString());
                                Console.WriteLine((x == y).ToString());
                                break;
                            case 14:
                                Console.Write($"{x}!={y} це = ".ToString());
                                Console.WriteLine((x  != y).ToString());
                                break;
                            case 0:         
                                break;
                        }
                    } while (vuraz != 0);
                }
            } while (true);
        }

    }
}

