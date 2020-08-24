using System;

namespace Testtirelire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime d = DateTime.Now;
            Console.WriteLine(d);

            Test1 t1 = new Test1();
            t1.date = DateTime.Now;
            Console.WriteLine(t1.date);
        }
    }
}
