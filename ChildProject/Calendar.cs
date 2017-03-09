using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject
{
    class Calendar
    {
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
                        bool test = Leap(year);
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

        public bool Leap(int year)
        {
            int god = year % 4;
            if (god == 0)
            {
                return true;
            }
            return false;
        }
    }
}
