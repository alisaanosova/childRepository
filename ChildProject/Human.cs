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
        private object value;
        private object value1;
        private object value2;

        public Human(object value, object value1, object value2)
        {
            this.value = value;
            this.value2 = value2;
            this.value1 = value1;

        }

        public string Name()
        {
            return ToString() + ": " + value;

        }
        public string Surname()
        {
            return ToString() + ": " + value1;

        }
        public string Age()
        {
            return ToString() + ": " + value2;

        }
        
    }
}

