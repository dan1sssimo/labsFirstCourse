using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Fraction
    {
        protected long number;
        protected long dennumber;
        public Fraction(long Number, long Dennumber)
        {
            number = Number;
            dennumber = Dennumber;
        }
        public static Fraction operator ++(Fraction a)
        {
            Fraction res = new Fraction(a.number, a.dennumber);
            a.number = a.number + a.dennumber;
            int tmp=0;
            for (int i = 1; i <= a.dennumber; i++)
            {
                if (a.number % i == 0 && a.dennumber % i == 0)
                {
                    tmp = i;
                }
            }
             a.number = a.number / tmp;
             a.dennumber = a.dennumber / tmp;
             return res;
        }
        public static Fraction operator --(Fraction a)
        {
            Fraction res = new Fraction(a.number, a.dennumber);
            a.number = a.number - a.dennumber;
            int tmp=0;
            for (int i = 1; i <= a.dennumber; i++)
            {
                if (a.number % i == 0 && a.dennumber % i == 0)
                {
                    tmp = i;
                }
            }
            a.number = a.number / tmp;
            a.dennumber = a.dennumber / tmp;
            return res;
        }
        public static Fraction Zved(Fraction res)
        {
            int tmp = 0;
            if (res.number > res.dennumber)
            {
                for (int i = 1; i <= res.dennumber; i++)
                {
                    if (res.number % i == 0 && res.dennumber % i == 0)
                    {
                        tmp = i;
                    }
                }
                res.number = res.number/ tmp;
                res.dennumber = res.dennumber/ tmp;
                return res;
            }
            else
            {
                if (res.number < res.dennumber)
                {
                    for (int i = 1; i <= res.number; i++)
                    {
                        if (res.number % i == 0 && res.dennumber % i == 0)
                        {
                            tmp = i;
                        }
                    }
                    res.number = res.number / tmp;
                    res.dennumber = res.dennumber / tmp;
                    return res;
                }
                else
                {
                    res.number = 1;
                    res.dennumber = 1;
                    return res;
                }
            }
        }
        public override string ToString()
        {
            if (dennumber != 1)
                return $"{number}/{dennumber}";
            else
                return $"{number}";
        }
        public static Fraction operator +(Fraction x,Fraction y)
        {
            Fraction res = new Fraction(x.number * y.dennumber + x.dennumber * y.number, x.dennumber * y.dennumber);
            Zved(res);
            return res;
        }
        public static Fraction operator -(Fraction x,Fraction y)
        {
            Fraction res = new Fraction(x.number * y.dennumber - x.dennumber * y.number, x.dennumber * y.dennumber);
            Zved(res);
            return res;
        }
        public static Fraction  operator *(Fraction x,Fraction y)
        {
            Fraction res = new Fraction(x.number * y.number, x.dennumber * y.dennumber);
            Zved(res);
            return res;
        }
        public static Fraction operator /(Fraction x, Fraction y)
        {
            Fraction res = new Fraction(x.number*y.dennumber, x.dennumber * y.number);
            Zved(res);
            return res;
        }
        public static bool operator >(Fraction x, Fraction y)
        {
            Fraction rezx = new Fraction(x.number * y.dennumber, x.dennumber * y.dennumber);
            Fraction rezy = new Fraction(y.number * x.dennumber, x.dennumber * y.dennumber);
            return rezx.number > rezy.number;
        }
        public static bool operator <(Fraction x, Fraction y)
        {
            Fraction rezx = new Fraction(x.number * y.dennumber, x.dennumber * y.dennumber);
            Fraction rezy = new Fraction(y.number * x.dennumber, x.dennumber * y.dennumber);
            return rezx.number < rezy.number;
        }
        public static bool operator >=(Fraction x, Fraction y)
        {
            Fraction rezx = new Fraction(x.number * y.dennumber, x.dennumber * y.dennumber);
            Fraction rezy = new Fraction(y.number * x.dennumber, x.dennumber * y.dennumber);
            return rezx.number >= rezy.number;
        }
        public static bool operator <=(Fraction x, Fraction y)
        {
            Fraction rezx = new Fraction(x.number * y.dennumber, x.dennumber * y.dennumber);
            Fraction rezy = new Fraction(y.number * x.dennumber, x.dennumber * y.dennumber);
            return rezx.number <= rezy.number;
        }
        public static bool operator ==(Fraction x, Fraction y)
        {
            Fraction rezx = new Fraction(x.number * y.dennumber, x.dennumber * y.dennumber);
            Fraction rezy = new Fraction(y.number * x.dennumber, x.dennumber * y.dennumber);
            return rezx.number == rezy.number;
        }
        public static bool operator !=(Fraction x, Fraction y)
        {
            Fraction rezx = new Fraction(x.number * y.dennumber, x.dennumber * y.dennumber);
            Fraction rezy = new Fraction(y.number * x.dennumber, x.dennumber * y.dennumber);
            return rezx.number != rezy.number;
        }
        public double GetDouble()
        {
            return number / (double)dennumber;
        }

    }
}
