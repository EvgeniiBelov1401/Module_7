using Exercise_7_5_09.Models;

namespace Exercise_7_5_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetPositive());
            Console.WriteLine(num1.GetNegative());
            Console.WriteLine(num2.GetPositive());
            Console.WriteLine(num2.GetNegative());
            Console.WriteLine(num3.GetPositive());
            Console.WriteLine(num3.GetNegative());
        }
    }
}
