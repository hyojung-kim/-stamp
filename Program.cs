using System;

namespace STAR3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 9;
            for(int i = 0; i < 10; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                m--;
            }
            Console.ReadLine();
        }
    }
}
    