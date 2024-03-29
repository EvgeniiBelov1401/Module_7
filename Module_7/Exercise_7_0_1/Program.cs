namespace Exercise_7_0_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj=new Obj("Объект","Нет описания");
            Console.WriteLine(obj.name+" "+obj.description);
        }
    }
}
