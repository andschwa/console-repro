namespace Repro
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("If you quit with `exit`, the ECHO TTY mode will remain disabled.");
            Console.WriteLine("If you quit with an interrupt (Ctrl-C), it will be re-enabled.");

            while (true)
            {
                Console.Write("$ ");
                string input = readline();
                Console.WriteLine(input);
                if (input == "exit")
                    return;
            }
        }

        public static string readline()
        {
            string input = "";
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                string str = key.KeyChar.ToString();
                Console.Write(str);
                if (key.Key == ConsoleKey.Enter)
                    return input;
                input += str;
            }
        }
    }
}
