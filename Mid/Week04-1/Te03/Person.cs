using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Te03
{
    internal class Person
    {
        public int Number
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Information => $"name = {Name}  number = {Number} ";
    }
}
