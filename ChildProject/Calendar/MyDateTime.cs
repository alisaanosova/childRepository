using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject.Calendar
{
    class MyDateTime
    {
        private int _day;
        private int _month;
        private int _year;

        public MyDateTime()
        {
            _day = 0;
            _month = 0;
            _year = 0;
        }

        public MyDateTime(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public int DayOfMounth(int year, int month)
        {
            int feb = 28;
            if (Leap(year))
            {
                feb = 29;
            }
            int[] days = { 0, 31, feb, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return days[month];
        }

        public bool Leap(int year)
        {
            int god = year % 4;
            if (god == 0)
            {
                return true;
            }
            return false;
        }
        public int IsDateValue(int year, int month, int day)
        {
            if (DayOfMounth(year, month) >= day && day > 0)
            {
                return _day;
            }
            return 0;

        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public void Chrono(ref MyDateTime date, ref MyDateTime date2)
        {
            if (date.Year > date2.Year)
            {
                ChronoChange(ref date, ref date2);
            }
            else if (date.Year == date2.Year)
            {
                if (date.Month > date2.Month)
                {
                    ChronoChange(ref date, ref date2);
                }
                else if (date.Month == date2.Month)
                {
                    if (date.Day > date2.Day)
                    {
                        ChronoChange(ref date, ref date2);
                    }

                }
            }
        }
        public void ChronoChange(ref MyDateTime date, ref MyDateTime date2)
        {
            MyDateTime val = date;
            date = date2;
            date2 = val;
        }
        public void Calculated(MyDateTime date1, MyDateTime date2, out int result)

        {
            result = 0;
            int res = 0;
            int sum;
            for (int j = date1.Year; j <= date2.Year; j++)
            {
                if (j == date1.Year && j == date2.Year)
                {
                    for (int i = date1.Month; i <= date2.Month; i++)
                    {

                        if (i == date1.Month && i == date2.Month)
                        {
                            sum = date2.Day - date1.Day;
                        }
                        else if (i == date1.Month && j == date1.Year)
                        {
                            sum = DayOfMounth(date2.Year, date1.Month) - date1.Day;
                        }
                        else if (i == date2.Month && j == date2.Year)
                        {
                            int info = DayOfMounth(date2.Year, date2.Month) - date2.Day;
                            sum = DayOfMounth(date2.Year, date2.Month) - info;
                        }

                        else
                        {
                            sum = DayOfMounth(date1.Year, i);
                        }
                        res += sum;
                    }
                }
                else if (j == date2.Year)
                {
                    for (int i = 1; i <= date2.Month; i++)
                    {

                        if (i == date2.Month && j == date2.Year)
                        {
                            int info = DayOfMounth(date2.Year, date2.Month) - date2.Day;
                            sum = DayOfMounth(date2.Year, date2.Month) - info;
                        }
                        else
                        {
                            sum = DayOfMounth(date1.Year, i);
                        }
                        res += sum;
                    }
                }

                else
                {
                    for (int i = date1.Month; i <= 12; i++)
                    {
                        if (i == date1.Month && j == date1.Year)
                        {
                            sum = DayOfMounth(date1.Year, i) - date1.Day;
                        }
                        else
                        {
                            sum = DayOfMounth(date1.Year, i);
                        }

                        res += sum;
                    }
                }
                result = res;
            }

        }

        public override string ToString()
        {
            if (IsDateValue(_year, _month, _day) == 0)
            {
                return "error";
            }
            return $"{Day}.{Month}.{Year}";
        }
    }

}
