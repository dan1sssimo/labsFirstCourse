using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public class ZNO
    {
        protected string subject;
        protected int points;
        public ZNO(string Subject, int Points)
        {
            subject = Subject;
            points = Points;
        }
        public ZNO(string Subject)
        {
            subject = Subject;
            points = 150;
        }
        public ZNO()
        {
            subject = "Укр.мова";
            points = 150;
        }
        public void SetSubject(string Subject)
        {
            if (Subject.Length > 0)
                subject = Subject;
        }
        public string GetSubject()
        {
            return subject;
        }
        public void SetPoints(int Points)
        {
            if (points > 0 && points <= 200)
                points = Points;
        }
        public int GetPoints()
        {
            return points;
        }
    }
    public class Entrant
    {
        protected string name;
        protected int idNum;
        protected int coursePoints;
        protected int avgPoints;
        protected ZNO[] znoResults;
        public Entrant(string Name, int IdNum, int CoursePoints, int AvgPoints, ZNO[] ZNOResults)
        {
            name = Name;
            idNum = IdNum;
            coursePoints = CoursePoints;
            avgPoints = AvgPoints;
            znoResults = ZNOResults;
        }
        public Entrant(string Name, int IdNum, int CoursePoints, int AvgPoints)
        {
            name = Name;
            idNum = IdNum;
            coursePoints = CoursePoints;
            avgPoints = AvgPoints;
            znoResults = new ZNO[4];
            for (int i = 0; i < 4; i++)
            {
                znoResults[i] = new ZNO();
            }
        }
        public Entrant(string Name, int IdNum, int CoursePoints)
        {
            name = Name;
            idNum = IdNum;
            coursePoints = CoursePoints;
            avgPoints = 150;
            znoResults = new ZNO[4];
            for (int i = 0; i < 4; i++)
            {
                znoResults[i] = new ZNO();
            }
        }
        public Entrant(string Name, int IdNum)
        {
            name = Name;
            idNum = IdNum;
            coursePoints = 150;
            avgPoints = 150;
            znoResults = new ZNO[4];
            for (int i = 0; i < 4; i++)
            {
                znoResults[i] = new ZNO();
            }
        }
        public Entrant(string Name)
        {
            name = Name;
            idNum = 0001;
            coursePoints = 150;
            avgPoints = 150;
            znoResults = new ZNO[4];
            for (int i = 0; i < 4; i++)
            {
                znoResults[i] = new ZNO();
            }
        }
        public Entrant()
        {
            name = "Валентин В.В";
            idNum = 0001;
            coursePoints = 150;
            avgPoints = 150;
            znoResults = new ZNO[4];
            for (int i = 0; i < 4; i++)
            {
                znoResults[i] = new ZNO();
            }
        }
        public void SetName(string Name)
        {
            if (Name.Length > 0)
                name = Name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetIdNum(int IdNum)
        {
            if (IdNum >= 0)
                idNum = IdNum;
        }
        public int GetIdNum()
        {
            return idNum;
        }
        public void SetCoursePoints(int CoursePoints)
        {
            if (CoursePoints > 0 && CoursePoints <= 200)
                coursePoints = CoursePoints;
        }
        public int GetCoursePoints()
        {
            return coursePoints;
        }
        public void SetAvgPoints(int AvgPoints)
        {
            if (AvgPoints <= 200 && AvgPoints > 0)
                avgPoints = AvgPoints;
        }
        public int GetAvgPoints()
        {
            return avgPoints;
        }
        public void SetZNOResults(int m)
        {
            znoResults = new ZNO[m];
            for (int i = 0; i < m; i++)
            {
                znoResults[i] = new ZNO();
                Console.Write($"Введіть назву ЗНО №{i + 1}:");
                znoResults[i].SetSubject(Console.ReadLine());
                Console.Write($"Кількість балів із цього предмету №{i + 1}:");
                znoResults[i].SetPoints(int.Parse(Console.ReadLine()));
            }
        }
        public void GetZNOResults()
        {
            for (int i = 0; i < znoResults.Length; i++)
            {
                Console.WriteLine($"Предмет ЗНО №{i + 1}: {znoResults[i].GetSubject()}");
                Console.WriteLine($"Ваша оцінка з предмета №{i + 1}: {znoResults[i].GetPoints()}");
            }
        }
        public double GetCompMark()
        {
            if (znoResults.Length < 3) return 0;
            else
            {
                double ZNOsum = 0;
                ZNOsum += znoResults[0].GetPoints() * 0.25;
                ZNOsum += znoResults[1].GetPoints() * 0.4;
                ZNOsum += znoResults[2].GetPoints() * 0.2;
                ZNOsum += coursePoints * 0.05;
                ZNOsum += avgPoints * 0.1;
                return ZNOsum;
            }
        }
        public string GetBestSubject(Entrant x)
        {
            int best = int.MinValue;
            string bestsubject = "";
            for (int j = 0; j < x.znoResults.Length; j++)
            {
                if (x.znoResults[j].GetPoints() > best)
                {
                    best = x.znoResults[j].GetPoints();
                    bestsubject = x.znoResults[j].GetSubject();
                }
            }
            return bestsubject;
        }
        public string GetWorstSubject(Entrant x)
        {
            int worst = int.MaxValue;
            string worstsubject = "";
            for (int j = 0; j < x.znoResults.Length; j++)
            {
                if (x.znoResults[j].GetPoints() < worst)
                {
                    worst = x.znoResults[j].GetPoints();
                    worstsubject = x.znoResults[j].GetSubject();
                }
            }
            return worstsubject;
        }
    }

    class Program
    {
        static void ReadEntrantArray(out Entrant[] EntrantArray, out int n)
        {
            bool check;
            do
            {
                Console.Write("Виберіть кількість абітурієнтів:");
                check = int.TryParse(Console.ReadLine(), out n);
                if (check == false || n < 1) Console.WriteLine("Помилка, введіть кількість абітурієнтів ще раз!!!");
            } while (check == false || n < 1);
            EntrantArray = new Entrant[n];
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                EntrantArray[i] = new Entrant();
                Console.WriteLine($"Абітурієнт №{i + 1}:");
                Console.Write("Введіть ім'я абітурієнта: ");
                EntrantArray[i].SetName(Console.ReadLine());
                Console.Write("Введіть ідентифікаційний код абітурієнта: ");
                EntrantArray[i].SetIdNum(int.Parse(Console.ReadLine()));
                Console.Write("Введіть бали за підготовчі курси: ");
                EntrantArray[i].SetCoursePoints(int.Parse(Console.ReadLine()));
                Console.Write("Введіть середній бал атестату: ");
                EntrantArray[i].SetAvgPoints(int.Parse(Console.ReadLine()));
                int m;
                do
                {
                    Console.Write("Виберіть кількість предметів ЗНО:");
                    check = int.TryParse(Console.ReadLine(), out m);
                    if (check == false || m < 1)
                        Console.WriteLine("Помилка, введіть кількість абітурієнтів ще раз!!!");
                } while (check == false || m < 1);
                EntrantArray[i].SetZNOResults(m);
                Console.ReadKey();
            }

        }
        static void PrintEntrant(Entrant EntrantArray, int n)
        {
            Console.WriteLine($"Абітурієнт {n}:");
            Console.WriteLine($"Ім'я абітурієнта: {EntrantArray.GetName()}");
            Console.WriteLine($"Ідентифікаційний код абітурієнта: {EntrantArray.GetIdNum()}");
            Console.WriteLine($"Бали за підготовчі курси: { EntrantArray.GetCoursePoints()}");
            Console.WriteLine($"Середній бал атестату: { EntrantArray.GetAvgPoints()}");
            EntrantArray.GetZNOResults();
        }
        static void PrintEntrants(Entrant[] EntrantArray)
        {
            for (int i = 0; i < EntrantArray.Length; i++)
            {
                Console.WriteLine($"Абітурієнт {i + 1}:");
                Console.WriteLine($"Ім'я абітурієнта: {EntrantArray[i].GetName()}");
                Console.WriteLine($"Ідентифікаційний код абітурієнта: {EntrantArray[i].GetIdNum()}");
                Console.WriteLine($"Бали за підготовчі курси: { EntrantArray[i].GetCoursePoints()}");
                Console.WriteLine($"Середній бал атестату: { EntrantArray[i].GetAvgPoints()}");
                EntrantArray[i].GetZNOResults();
                Console.Write("\n");
            }
        }
        static void GetEntrantsInfo(Entrant[] EntrantArray, out double maximum, out double minimum)
        {
            maximum = double.MinValue;
            minimum = double.MaxValue;
            for (int i = 0; i < EntrantArray.Length; i++)
            {
                if (EntrantArray[i].GetCompMark() > maximum)
                    maximum = EntrantArray[i].GetCompMark();
                else
                    if (EntrantArray[i].GetCompMark() < minimum)
                    minimum = EntrantArray[i].GetCompMark();
            }
        }
        public static int SortEntrantArrayByPointsComparator(Entrant x, Entrant y)
        {
            double point1 = x.GetCompMark();
            double point2 = y.GetCompMark();
            if (point1 > point2)
                return 1;
            if (point1 < point2)
                return -1;
            return 0;
        }
        static void SortEntrantArrayByPoints(Entrant[] EntrantArray)
        {
            Array.Sort(EntrantArray, SortEntrantArrayByPointsComparator);
            Array.Reverse(EntrantArray);
            Console.WriteLine("Сортування успішно завершено!!!");
        }
        public static int SortEntrantArrayByNameComparator(Entrant x, Entrant y)
        {
            string name1 = x.GetName();
            string name2 = y.GetName();
            if (String.Compare(name1, name2) > 0)
                return 1;
            if (String.Compare(name1, name2) < 0)
                return -1;
            return 0;
        }
        static void SortEntrantArrayByName(Entrant[] EntrantArray)
        {
            Array.Sort(EntrantArray, SortEntrantArrayByNameComparator);
            Console.WriteLine("Сортування успішно завершено!!!");
        }

        static void Main(string[] args)
        {

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Лабораторна робота №6";
            Console.SetWindowSize(150, 50);
            Entrant[] EntrantArray = { };
            int ok;
            int n;
            bool check;
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Виберіть дію:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Додати нових абітурієнтів - 1");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вивести інформацію про абітурієнта - 2");
                    Console.WriteLine("Вивести інформацію про всіх абітурієнтів - 3");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вивести найбільший і найменший конкурсний бал абітурієнтів - 4");
                    Console.WriteLine("Сортувати абітурієнтів за спаданням конкурсного балу - 5");
                    Console.WriteLine("Сортувати абітурієнтів за прізвищем - 6");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Обрахувати конкурсний бал абітурієнта - 7");
                    Console.WriteLine("Вийти з програми -0");
                    check = int.TryParse(Console.ReadLine(), out ok);
                    if (check == false) 
                        Console.WriteLine("Помилка. Такого пункту меню не існує!!!");
                } while (check == false);
                switch (ok)
                {
                    case 1:
                        {
                            Console.Clear();
                            Program.ReadEntrantArray(out EntrantArray, out n);
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            int num;
                            bool okey;
                            do
                            {
                                Console.Write("Введіть номер абітурієнта: ");
                                okey = int.TryParse(Console.ReadLine(), out num);
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (okey == false || num < 1 || num > EntrantArray.Length)
                                    Console.WriteLine($"Помилка. Номер має бути менше {EntrantArray.Length + 1}.");
                            } while (okey == false || num < 1 || num > EntrantArray.Length);
                            Program.PrintEntrant(EntrantArray[num - 1], num);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Program.PrintEntrants(EntrantArray);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            double max, min;
                            Program.GetEntrantsInfo(EntrantArray, out max, out min);
                            Console.WriteLine($"Найбільший конкурсний бал: {max}");
                            Console.WriteLine($"Найменший конкурсний бал: {min}");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        }
                    case 5:
                        {
                            Console.Clear();
                            Program.SortEntrantArrayByPoints(EntrantArray);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Program.SortEntrantArrayByName(EntrantArray);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            int number;
                            bool okey;
                            do
                            {
                                Console.Write("Введіть номер абітурієнта: ");
                                okey = int.TryParse(Console.ReadLine(), out number);
                                if (okey == false || number < 1 || number > EntrantArray.Length)
                                    Console.WriteLine($"Помилка. Номер має бути менше {EntrantArray.Length + 1}.");
                            } while (okey == false || number < 1 || number > EntrantArray.Length);
                            Console.WriteLine($"Конкурсний бал: {EntrantArray[number - 1].GetCompMark()}");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Завершення роботи");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                }
            } while (ok != 0);

        }
    }
}