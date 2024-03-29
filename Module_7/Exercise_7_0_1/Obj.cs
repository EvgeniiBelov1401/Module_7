using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_0_1
{
    internal class Obj
    {
        public string name;
        public string description;

        public Obj()
        {
            Console.WriteLine("Вызван конструктор без параметров");
        }

        public Obj(string name,string description):this()
        {
            this.name = name;   
            this.description = description;
        }
    }
}
