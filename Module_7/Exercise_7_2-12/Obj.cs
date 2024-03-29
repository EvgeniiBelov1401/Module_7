using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_2_12
{
    internal class Obj
    {
        public int Value;

        public static Obj operator +(Obj a,Obj b) 
        { 
            return new Obj 
            { 
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }
}
