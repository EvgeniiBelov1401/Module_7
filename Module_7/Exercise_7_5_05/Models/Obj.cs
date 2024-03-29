using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_5_05.Models
{
    internal class Obj
    {
        public string Name;
        public string Deskription;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            Parent = "System.Object";`
            DaysInWeek = 7;
            MaxValue = 100000;
        }
    }
}
