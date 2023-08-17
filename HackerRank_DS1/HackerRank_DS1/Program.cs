using System;

namespace HackerRank_DS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            string input = Console.ReadLine();
            string[] inputValue = input.Split(' ');

            for (int i = 0; i < a; i++)
            {
                if (int.TryParse(inputValue[i], out int value))
                {
                    b[i] = value;
                }
            }

            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
