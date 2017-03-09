using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChildProject;

namespace secondcalendar
{
    class MyClass
    {
        MyClass my = null;

        public void СhangeСhronology(ref int day1, ref int month1, ref int year1, ref int day2, ref int month2,
            ref int year2)
        {
            int d1 = day1;
            int m1 = month1;
            int y1 = year1;

            day1 = day2;
            month1 = month2;
            year1 = year2;

            day2 = d1;
            month2 = m1;
            year2 = y1;
        }

        public void Сhronology(ref int day1, ref int month1, ref int year1, ref int day2, ref int month2,
            ref int year2)
        {


            if (year1 < year2)
            {
                СhangeСhronology(ref day1, ref month1, ref year1, ref day2, ref month2, ref year2);
            }
            else if (year1 == year2)
            {
                if (month1 > month2)
                {
                    СhangeСhronology(ref day1, ref month1, ref year1, ref day2, ref month2, ref year2);
                }
                else if (month1 == month2)
                {
                    if (day1 > day2)
                    {
                        СhangeСhronology(ref day1, ref month1, ref year1, ref day2, ref month2, ref year2);
                    }

                }
            }
        }

        public void startDays(int endyear, int endmonth, int endday, out int res)
        {
            res = 0;
            int sum;
            int res1 = 0;
            for (int j = 1; j <= endyear; j++)
            {
                if (j == endyear)
                {
                    for (int i = 1; i <= endmonth; i++)
                    {
                        sum = DayOfMounth(j, i);
                        if (i == endmonth && j == endyear)
                        {
                            int info = DayOfMounth(endyear, endmonth) - endday;
                            sum = DayOfMounth(endyear, endmonth) - info;
                        }
                        res1 += sum;
                    }
                }

                else
                {
                    for (int i = 0; i <= 12; i++)
                    {
                        sum = DayOfMounth(j, i);
                        res1 += sum;
                    }
                }
                res = res1;

            }
        }

        public void daySum(int year, int endyear, int endmonth, int endday, int startday, int month, out int res)

        {
            res = 0;
            int sum;
            int res1 = 0;
            for (int j = year; j <= endyear; j++)
            {
                if (j == year && j == endyear)
                {
                    for (int i = month; i <= endmonth; i++)
                    {

                        if (i == month && i == endmonth)
                        {
                            sum = endday - startday;
                        }
                        else if (i == month && j == year)
                        {
                            sum = DayOfMounth(endyear, month) - startday;
                        }
                        else if (i == endmonth && j == endyear)
                        {
                            int info = DayOfMounth(endyear, endmonth) - endday;
                            sum = DayOfMounth(endyear, endmonth) - info;
                        }

                        else
                        {
                            sum = DayOfMounth(year, i);
                        }
                        res1 += sum;
                    }
                }
                else if (j == endyear)
                {
                    for (int i = 1; i <= endmonth; i++)
                    {

                        if (i == endmonth && j == endyear)
                        {
                            int info = DayOfMounth(endyear, endmonth) - endday;
                            sum = DayOfMounth(endyear, endmonth) - info;
                        }
                        else
                        {
                            sum = DayOfMounth(year, i);
                        }
                        res1 += sum;
                    }
                }

                else
                {
                    for (int i = month; i <= 12; i++)
                    {
                        if (i == month && j == year)
                        {
                            sum = DayOfMounth(year, i) - startday;
                        }
                        else
                        {
                            sum = DayOfMounth(year, i);
                        }

                        res1 += sum;
                    }
                }
                res = res1;

            }

        }

        public bool isDateValue(int year, int month, int day)
        {
            if (DayOfMounth(year, month) >= day && day > 0)
            {
                return true;
            }
            return false;

        }

        public int DayOfMounth(int year, int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return 31;
                    }
                case 2:
                    {
                        bool test = leap(year);
                        if (test)
                        {
                            return 29;
                        }
                        return 28;
                    }
                case 3:
                    {
                        return 31;
                    }
                case 4:
                    {
                        return 30;
                    }
                case 5:
                    {
                        return 31;
                    }
                case 6:
                    {
                        return 30;
                    }
                case 7:
                    {
                        return 31;
                    }
                case 8:
                    {
                        return 31;
                    }
                case 9:
                    {
                        return 30;
                    }
                case 10:
                    {
                        return 31;
                    }
                case 11:
                    {
                        return 30;
                    }
                case 12:
                    {
                        return 31;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        private bool leap(int year)
        {
            int god = year % 4;
            if (god == 0)
            {
                return true;
            }
            return false;
        }

        public bool Leap(int year)
        {
            my = new MyClass();
            return leap(year);
        }
    }
    internal class Program
    {
        //дей инфо убери, он тут не нужен, у тебя есть отдельный метод для проверки сколько дней в месяце, это чуть матрешка выходит
        //и назови что-то типа изДейтВалид потому что неонятно что делает метод
        //и еще важно. привыкай называть методы всегда с большой буквы
        //еще надо чекнуть перед этим всем адекватен ли год, вдруг он меньше нуля. хотя, если считать что это типа до н.э.)



        static void Main(string[] args)
        {
            string globalAnswer;
            Human human = new Human(Console.ReadLine(), Console.ReadLine(),Console.ReadLine());
            Console.WriteLine(human.Name());
            Console.WriteLine(human.Surname());
            Console.WriteLine(human.Age());
            do
            {
                int res;
                MyClass my = new MyClass();
                

                Console.WriteLine("\r\n" + "if you want to perform actions with dates write 'act'.");
                Console.WriteLine("If you want to know whether a leap year write  'leap'");
                Console.Write("Write what you need: ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    
                    case "act":
                        #region actions
                        #region enter values
                        {
                            Console.WriteLine("If you want to know the number of days between dates write 'amount'.");
                            Console.WriteLine("If you want to know the number of days from the beginning of our era write 'era'");
                            Console.WriteLine("if you want to arrange the dates in chronological order write 'chrono'.");
                            Console.Write("Write what you need: ");
                            string answer2 = Console.ReadLine();

                            Console.WriteLine("Enter first date.");
                            Console.Write("Enter day: ");
                            int day;
                            bool testday = int.TryParse(Console.ReadLine(), out day);
                            while (!testday ^ day < 0)
                            {
                                Console.Write("Incorret value! Try again: ");
                                testday = int.TryParse(Console.ReadLine(), out day);
                            }
                            Console.Write("Enter month: ");
                            int month;
                            bool testmonth = int.TryParse(Console.ReadLine(), out month);
                            while (!testmonth ^ month < 0)
                            {
                                Console.Write("Incorret value! Try again: ");
                                testmonth = int.TryParse(Console.ReadLine(), out month);
                            }
                            Console.Write("Enter year: ");
                            int year;
                            bool testyear = int.TryParse(Console.ReadLine(), out year);
                            while (!testyear ^ year < 0)
                            {
                                Console.Write("Incorret value! Try again: ");
                                testyear = int.TryParse(Console.ReadLine(), out year);
                            }

                            int daycheck = my.DayOfMounth(year, month);

                            bool test1 = my.isDateValue(year, month, day);

                            if (answer2 == "amount" ^ answer2 == "chrono")
                            {
                                if (test1)
                                {
                                    Console.WriteLine("\n\r" + "Enter second date.");
                                    Console.Write("Enter day: ");
                                    int endday;
                                    bool testendday = int.TryParse(Console.ReadLine(), out endday);
                                    while (!testendday ^ endday < 0)
                                    {
                                        Console.Write("Incorret value! Try again: ");
                                        testendday = int.TryParse(Console.ReadLine(), out endday);
                                    }
                                    Console.Write("Enter month: ");
                                    int endmonth;
                                    bool testendmonth = int.TryParse(Console.ReadLine(), out endmonth);
                                    while (!testendmonth ^ endmonth < 0)
                                    {
                                        Console.Write("Incorret value! Try again: ");
                                        testendmonth = int.TryParse(Console.ReadLine(), out endmonth);
                                    }
                                    Console.Write("Enter year: ");
                                    int endyear;
                                    bool testendyear = int.TryParse(Console.ReadLine(), out endyear);
                                    while (!testendyear ^ endyear < 0)
                                    {
                                        Console.Write("Incorret value! Try again: ");
                                        testendyear = int.TryParse(Console.ReadLine(), out endyear);
                                    }
#endregion
                                    daycheck = my.DayOfMounth(endyear, endmonth);

                                    bool test2 = my.isDateValue(endyear, endmonth, endday);
                                    if (test2)
                                    {
                                        if (answer2 == "amount")
                                        {
                                            my.Сhronology(ref day, ref month, ref year, ref endday, ref endmonth, ref endyear);
                                            my.daySum(year, endyear, endmonth, endday, day, month, out res);
                                            Console.WriteLine("Amount of days: {0} ", res);
                                        }
                                        else if (answer2 == "chrono")
                                        {
                                            my.Сhronology(ref day, ref month, ref year, ref endday, ref endmonth, ref endyear);
                                            Console.WriteLine("\r\n" + "{0}.{1}.{2}", day, month, year);
                                            Console.WriteLine("{0}.{1}.{2}", endday, endmonth, endyear);
                                        }
                                    }
                                    else
                                        Console.WriteLine("Month {0} have only {1} days.", month, daycheck);
                                }
                            }
                            else if (answer2 == "era")
                            {
                                my.startDays(year, month, day, out res);
                                Console.WriteLine(" {0}", res);
                            }
                            else
                            {
                                Console.WriteLine("Month {0} have only {1} days.", month, daycheck);
                            }


                            break;
                        }
#endregion
                    case "leap":
#region leap year
                        {
                            Console.Write("Enter year: ");
                            int year;
                            bool testyear = int.TryParse(Console.ReadLine(), out year);
                            while (!testyear ^ year < 0)
                            {
                                Console.Write("Incorret value! Try again: ");
                                testyear = int.TryParse(Console.ReadLine(), out year);
                            }

                            bool test = my.Leap(year);
                            if (test)
                            {
                                Console.WriteLine("{0} leap year.", year);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("{0} not a leap year!", year);
                                break;
                            }
                        }

                }
#endregion
                Console.Write("\r\n" + "Try again? y/n;");
                globalAnswer = Console.ReadLine();
            }
            while (globalAnswer == "y");

        }
    }
}
