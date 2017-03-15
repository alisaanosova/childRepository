using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject
{
    class Person
    {
        private string _name;
        private string _surname;
        private DateTime _date;

        public Person()
        {
            _name = "unnamed";
            _surname = "unnamed";
            _date = DateTime.MinValue;
        }
        
        public Person(string name, string surname, DateTime date)
        {
            _name = name;
            _surname = surname;
            _date = date;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Year
        {
            get { return _date.Year; }
            set
            {
                DateTime date = new DateTime(value,_date.Month,_date.Day);
                _date = date;
            }
        }


        public override string ToString()
        {
            return $" Name: {Name}\r\n Surname: {Surname} \r\n Date: {Date}";
        }
        public virtual string ToSortString()
        {
            return $" Name: {Name}\r\n Surname: {Surname}";
        }
    }

}
