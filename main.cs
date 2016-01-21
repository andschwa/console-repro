namespace Repro
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("About to use AppContext.BaseDirectory");
            Console.WriteLine($"It is {AppContext.BaseDirectory}");
        }
    }
}
