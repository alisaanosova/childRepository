using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject.lab_1.option_2
{
    class Article
    {
        public Person _person { set; get; }
        public string _name { set; get; }
        public double _raiting { set; get; }

        public Article()
        {
            _person = new Person();
            _name = "unknown";
            _raiting = 0;
        }

        public Article(Person person, string name, double raiting)
        {
            _person = person;
            _name = name;
            _raiting = raiting;
        }

        public override string ToString()
        {
            return $"{_person} {_name} {_raiting}";
        }
    }
}
