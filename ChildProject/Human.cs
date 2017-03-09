using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject
{
    class Human
    {
        //добавь нижнее подчеркивание
        private string _name;
        private string _surname;
        private int _age;

        public Human()
        {
            _name = "unnamed";
            _surname = "unnamed";
            _age = 0;
        }
        
        //добавь конструктор без параметров, еще называется по-умолчанию
        //типа имя будет анноун нарп и т.п.
        public Human(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;

        }

        public override string ToString()
        {
            return $" Name: {_name} \r\n Surname: {_surname} \r\n Age: {_age}";

        }
        
    }
}

