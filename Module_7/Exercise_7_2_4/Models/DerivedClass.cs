using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_2_4.Models
{
    internal class DerivedClass:BaseClass
    {
        public int counter;
        public override int Counter 
        { 
            get
            {
                return counter;
            }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Значение не должно быть меньше 0");
                }
                else
                {
                    counter = value;
                }
            }
        }
    }
}
