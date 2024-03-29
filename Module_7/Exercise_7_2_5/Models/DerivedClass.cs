using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_2_5.Models
{
    internal class DerivedClass:BaseClass
    {
        public virtual void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}
