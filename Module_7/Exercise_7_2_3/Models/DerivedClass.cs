using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_2_3.Models
{
    internal class DerivedClass:BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}
