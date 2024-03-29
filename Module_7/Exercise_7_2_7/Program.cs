using Exercise_7_2_7.Models;

namespace Exercise_7_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            D d =new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
        }
    }
}
