using System;

namespace ClassLibrary1
{
    public class Entrant
    {
        protected string name;
        protected int idNum;
        protected int coursePoints;
        protected int avgPoints;
        protected ZNO[] znoResults;
        protected int dengi;
        protected string dengiVal;
        public string DengiVal
        {
            set { dengiVal = value; }
            get { return dengiVal; }
        }
        public int DengiMonth
        {
            set { dengi = value; }
            get { return dengi; }
        }
        public int DengiYear
        {
            set { dengi = value/10; }
            get { return dengi; }
        }
        public int DengiAll
        {
            set { dengi = value/40; }
            get { return dengi; }
        }
        public Entrant(string Name, int IdNum, int CoursePoints, int AvgPoints, ZNO[] ZNOResults, int Dengi, string DengiVal )
        {
            name = Name;
            idNum = IdNum;
            coursePoints = CoursePoints;
            avgPoints = AvgPoints;
            znoResults = ZNOResults;
            dengi = Dengi;
            dengiVal = DengiVal;
        }
        public Entrant(string Name, int IdNum, int CoursePoints, int AvgPoints, ZNO[] ZNOResults)
        {
            name = Name;
            idNum = IdNum;
            coursePoints = CoursePoints;
            avgPoints = AvgPoints;
            znoResults = ZNOResults;
            dengi = 100;
            dengiVal = "grn";
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
            dengi = 102;
            dengiVal = "grn";
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
            dengi = 150;
            dengiVal = "grn";
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
            dengi = 140;
            dengiVal = "grn";
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
            dengi = 120;
            dengiVal = "grn";
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
            dengi = 130;
            dengiVal = "grn";
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
}
