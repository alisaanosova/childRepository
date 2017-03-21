using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject.lab_1.option_2
{
    class Article
    {
        //лучше не называть переменную именем класса тем более в одной строчке. не ошибка. но стиль кода не хороший.
        //это было бы допустимо с переменной, потому что ты просто с маленькой буквы пишешь и не юзаешь ее много раз
        // но тут не очень хорошо
        public Person Person { set; get; }
        public string Name { set; get; }
        public double Raiting { set; get; }

        public Article()
        {
            Person = new Person();
            Name = "unknown";
            Raiting = 0;
        }

        public Article(Person person, string name, double raiting)
        {
            Person = person;
            Name = name;
            Raiting = raiting;
        }

        public override string ToString()
        {
            return $"{Person} {Name} {Raiting}";
        }
    }
}
