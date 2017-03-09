using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject
{
    class CalendarActions
    {
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
                return leap(year);
            }
        }
    }

