using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
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
            points = 120;
        }
        public ZNO()
        {
            subject = "Укр.мова";
            points = 120;
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
}
