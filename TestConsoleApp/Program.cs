using System;

namespace TestConsoleApp
{
    public class Program
    {
        // Protected, readonly field as per review criteria
        protected readonly int value;

        // Constructor with int parameter, saves value
        public Program(int i)
        {
            value = i;
        }

        static void Main(string[] args)
        {
            // Instance creation as required
            var app = new Program(42);
            Console.WriteLine("Hello, World!");
        }
    }
}
