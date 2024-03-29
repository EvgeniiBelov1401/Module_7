using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_5_09.Models
{
    internal static class IntExtensions
    {
        public static int GetNegative(this int value)
        {
            if (value < 0 ||value==0) return value;
            else return value*-1;
        }
        public static int GetPositive(this int value)
        {
            if (value > 0 || value == 0) return value;
            else return value * -1;
        }
    }
}
