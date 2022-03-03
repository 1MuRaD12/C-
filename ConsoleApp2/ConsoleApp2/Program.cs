using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5, j = 8;

            if (i > j)
            {
                Console.WriteLine("i boyukdur j den");
            }
            else if (i < j)
            {
                Console.WriteLine("i kicikdir j den");
            }

            else
            {
                Console.WriteLine("i beraberdi j ye");
            }
        }
    }
}
