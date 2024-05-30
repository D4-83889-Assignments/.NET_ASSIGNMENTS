using System.Data.Common;
using System.Runtime.CompilerServices;

namespace Ques_6
{

    class Date
    {



        private int day;
        private int month;
        private int year;

        public Date()
        {

        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public int _year
        {
            get { return year; }
            set { year = value; }
        }






        public int _month
        {
            get { return month; }
            set { month = value; }
        }



        public int _day
        {
            get { return day; }
            set { day = value; }
        }


        public void acceptDate()
        {
            Console.WriteLine("Enter day");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());


        }

        public void displayDate()
        {
            Console.WriteLine("Day/Month/Year: " + day + "/" + month + "/" + year);
        }

        public bool isValidDate()
        {
            if (day <= 31 && day >= 1)
            {
                if (month <= 12 && month >= 1)
                {
                    if (year <= 2400 && year >= 1900)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Day/Month/Year: {day}/{month}/{year}";
        }

        public static int operator -(Date d1, Date d2)
        {
            return Math.Abs(d1.year - d2.year);
        }


    }


    internal class Program
    {

        public static int difference(Date d1, Date d2)
        {
            return Math.Abs(d1._year - d2._year);
        }
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Date d2 = new Date();
            d1.acceptDate();
            d2.acceptDate();
            d1.displayDate();
            d2.displayDate();
            Console.WriteLine("Difference in year of two dates: " + (d1 - d2));
            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());
        }
    }
}
