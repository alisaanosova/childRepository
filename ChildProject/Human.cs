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
        private object name;
        private object surname;
        private object age;

        public Human(object name, object surname, object age)
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

