using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_1_10.Models
{
    internal class DerivedClass:BaseClass
    {
        public string Description;
        public int Counter;

        public DerivedClass(string name,string description,int couunter):base(name)
        {
            Description = description;
            Counter = couunter;
        }
        public DerivedClass(string name,string description):base(name)
        {
            Description=description;
        }
    }
}
