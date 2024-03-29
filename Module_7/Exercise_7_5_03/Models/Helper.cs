using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_5_03.Models
{
    internal class Helper
    {
        public static int temp;
        public static void Swap(ref int num1,ref int num2)
        {
            temp = num1;
            num1 = num2;
            num2=temp;
        }
    }
}
