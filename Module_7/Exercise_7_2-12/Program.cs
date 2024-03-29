using System.Numerics;

namespace Exercise_7_2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obj a = new Obj { Value = 5 };
            Obj b = new Obj { Value = 3 };
            Obj c = a + b;
            Console.WriteLine(c.Value);
        }
    }
}
