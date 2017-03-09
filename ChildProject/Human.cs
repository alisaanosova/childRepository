using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject
{
    class Human
    {
        private object value;

        public Human(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + value.ToString();
        }
    }
}

