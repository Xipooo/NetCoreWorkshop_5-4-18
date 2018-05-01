using System;
using NetCoreWorkshop_5_4_18.Operations;

namespace NetCoreWorkshop_5_4_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will print Hello World 5 times.");
            Incrementer inc = new Incrementer();
            MyClass myClass = new MyClass();

            int totalWrites = 0;
            for (int i = 1; i <= 5; inc.IncrementInteger(i))
            {
                Console.WriteLine("Hello World!");
                
                if (++totalWrites > 5){
                    Console.WriteLine("Too many!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
