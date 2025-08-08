namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var app = new Program(42);
        }

        private readonly int value;
        public Program(int i)
        {
            this.value = i;
        }
    }
}
