using Exercise_7_2_3.Models;

namespace Exercise_7_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseClass=new BaseClass();
            var derivedClass=new DerivedClass();

            baseClass.Display();
            derivedClass.Display();
        }
    }
}
