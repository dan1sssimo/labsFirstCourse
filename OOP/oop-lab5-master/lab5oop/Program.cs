using System;
using System.Text;


namespace lab5oop
{
    class Program
    {
        struct company
        {
            public string Name;
            public string Position;
            public int Salary;
            public company(string name,string position,int salary)
            {
                Name = name;
                Position = position;
                Salary = salary;
            }
        }
        struct Worker
        {
            public string NameRob;
            public int Year;
            public int Month;
            public company WorkPlace;
            public Worker(string nameRob,int year,int month, company workPlace)
            {
                NameRob = nameRob;
                Year = year;
                Month = month;
                WorkPlace = workPlace;           
            }
            public int GetWorkExperience()
            {
                int nowmonth = DateTime.Now.Month;
                int nowyear = DateTime.Now.Year;
                int rez = (nowyear - Year) * 12 - Month + nowmonth;
                return rez;
            }
            public int GetTotalMoney()
            {
                int worktime = GetWorkExperience();
                int rez = worktime * WorkPlace.Salary;
                return rez;
            }
          
        }
        static void ReadWorkersArray(out company[] companyArray,out Worker[] WorkerArray,ref int n)
        {
            bool ok;
            do
            {
                Console.WriteLine("Введіть кількість працівників: ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if(ok==false|| n <1)
                {
                    Console.WriteLine("Помилка введення значення!!!");
                }    
            } while (ok == false || n < 1);
            companyArray = new company[n];
            WorkerArray = new Worker[n];
            Console.WriteLine("Через клавішу Enter введіть дані по черзі\n"+ "Назва компанії,\nПосада,\nЗарплата,\nПІБ,\nРік початку роботи,\n"
            + "Місяць початку роботи.\n");
            for(int i=0;i<n ;i++ )
            {
                Console.WriteLine($"Працівник {i + 1}");
                companyArray[i] = new company(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                WorkerArray[i] = new Worker(Console.ReadLine(), int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),companyArray[i]);
                Console.WriteLine("\n");
            }
        }
        static void PrintWorker(Worker  WorkerArray)
        {
            Console.WriteLine($"Назва компанії: {WorkerArray.WorkPlace.Name}");
            Console.WriteLine($"Посада: {WorkerArray.WorkPlace.Position}");
            Console.WriteLine($"Зарплата: {WorkerArray.WorkPlace.Salary}");
            Console.WriteLine($"ПІБ: {WorkerArray.NameRob}");
            Console.WriteLine($"Рік початку роботи: {WorkerArray.Year}");
            Console.WriteLine($"Місяць початку роботи: {WorkerArray.Month}");
        }
        static void PrintWorkers(Worker[] WorkerArray, ref int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Робітник{i + 1}:");
                Console.WriteLine($"Назва компанії: {WorkerArray[i].WorkPlace.Name}");
                Console.WriteLine($"Посада: {WorkerArray[i].WorkPlace.Position}");
                Console.WriteLine($"Зарплата: {WorkerArray[i].WorkPlace.Salary}");
                Console.WriteLine($"ПІБ: {WorkerArray[i].NameRob}");
                Console.WriteLine($"Рік початку роботи: {WorkerArray[i].Year}");
                Console.WriteLine($"Місяць початку роботи: {WorkerArray[i].Month}");
                Console.WriteLine("\n");
            }
        }
        static void GetWorkersInfo(Worker[] WorkerArray, ref int n, out int maxsalary, out int minsalary)
        {
            maxsalary = int.MinValue;
            minsalary = int.MaxValue;
            for(int i=0;i<n;i++)
            {
                if (WorkerArray[i].WorkPlace.Salary > maxsalary)
                    maxsalary = WorkerArray[i].WorkPlace.Salary;       
            }
           for(int j=0;j<n;j++)
                if (WorkerArray[j].WorkPlace.Salary < minsalary)
                    minsalary = WorkerArray[j].WorkPlace.Salary;
        }

        static void SortWorkerBySalary(Worker[] WorkerArr, ref int n)
        {
            Worker tmp;
            for (int i = 1; i < n; i++)
            {
                tmp = WorkerArr[i];
                for (int j = i - 1; j >= 0 && WorkerArr[j].WorkPlace.Salary < tmp.WorkPlace.Salary; j--)
                {
                    WorkerArr[j + 1] = WorkerArr[j];
                    WorkerArr[j] = tmp;
                }
            }
            Console.WriteLine("Сортування завершено");
        }
        static void SortWorkerByWorkExpirience(Worker[] WorkerArray, ref int n)
        {
            Worker tmp;
            for (int i = 1; i < n; i++)
            {
                tmp = WorkerArray[i];
                for (int j = i - 1; j >= 0 && WorkerArray[j].GetWorkExperience() > tmp.GetWorkExperience(); j--)
                {
                    WorkerArray[j + 1] = WorkerArray[j];
                    WorkerArray[j] = tmp;
                }
            }  
            Console.WriteLine("Сортування завершено");
        }
        static void Check(out int x)
        {
            bool ok;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out x);
                if (!ok)
                    Console.WriteLine("Некоректне введення! Повторіть спробу.");
            } while (!ok);
        }
        static int Menu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Виберіть дію:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Додати робітників - 1");
            Console.WriteLine("Вивести інформацію про робітника - 2");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вивести інформацію про всіх робітників - 3");
            Console.WriteLine("Вивести найбільшу та найменшу зарплату - 4");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Посортувати робітників за спаданням ціни - 5");
            Console.WriteLine("Посортувати робітників за зростанням стажу роботи - 6");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Обрахувати стаж роботи робітників - 7");
            Console.WriteLine("Обрахувати загальну суму грошей зароблених робітником - 8");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вийти - 0");
            int x;
            Check(out x);
            return x;
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Лабораторна робота №5";
            Console.SetWindowSize(100, 25);
            company[] CompanyArray = { };
            Worker[] WorkerArray = { };
            int n=0;
            int s;
            do
            {
                s = Menu();
                switch (s)
                {
                    case 1:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Program.ReadWorkersArray(out CompanyArray, out WorkerArray, ref n);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            int num;
                            bool check;
                            do
                            {
                                Console.Write("Введіть номер робітника: ");
                                check = int.TryParse(Console.ReadLine(), out num);        
                                if (check == false || num > n) Console.WriteLine($"Помилка. Значення повине бути менше {n + 1}.");
                            } while (check == false || num > n);
                            Program.PrintWorker(WorkerArray[num - 1]);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Program.PrintWorkers(WorkerArray, ref n);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            int max, min;
                            Program.GetWorkersInfo(WorkerArray, ref n, out max, out min);
                            Console.WriteLine($"Найвища зарплата:{max}\nНайнижча зарплата: {min}");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Program.SortWorkerBySalary(WorkerArray, ref n);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            SortWorkerByWorkExpirience(WorkerArray, ref n);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 7:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            int num, rez;
                            bool check;
                            do
                            {
                                Console.Write("Введіть номер робітника: ");
                                check = int.TryParse(Console.ReadLine(), out num);
                                if (check == false || num > n) Console.WriteLine($"Помилка. Значення повине бути менше {n + 1}.");
                            } while (check == false || num > n);
                            rez = WorkerArray[num - 1].GetWorkExperience();
                            Console.WriteLine($"Стаж роботи у місяцях: {rez}");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 8:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            int number, rez;
                            bool check;
                            do
                            {
                                Console.Write("Введіть номер робітника: ");
                                check = int.TryParse(Console.ReadLine(), out number);
                                if (check == false || number > n) Console.WriteLine($"Помилка. Значення повине бути меньше {n + 1}.");
                            } while (check == false || number > n);
                            rez = WorkerArray[number - 1].GetTotalMoney();
                            Console.WriteLine($"Загальна кількість зароблених грошей: {rez}");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 0:
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Завершення роботи...");
                            break;
                        }
                }
            } while (s != 0);
        }
    }
}
