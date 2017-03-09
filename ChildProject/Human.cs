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
        private string name;
        private string surname;
        private int age;
        
        //добавь конструктор без параметров, еще называется по-умолчанию
        //типа имя будет анноун нарп и т.п.
        public Human(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

        }

        public override string ToString()
        {
            return $" Name: {name},\r\n Surname: {surname},\r\n Age: {age}";

        }
        
    }
}

