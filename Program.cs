using System;

namespace Static_MEthod
{
    class Program
    {
        public static void withoutObj()
        {
            Console.WriteLine("Hello");
        }
        static void Main()
        {
            Program.withoutObj();
            Console.ReadKey();
        }
    }
}
