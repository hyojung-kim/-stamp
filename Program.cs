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
          
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            m = 10;
            for (int i = 1; i < 11; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                m--;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

           
            for (int i = 1; i < 11; i++)
            {
                for (int k = 0; k < 11-i; k++)
                {
                    Console.Write(" ");
                }
                for (int j =0; j<2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 9; i > 0; i--)
            {
                for (int j = 0; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
               
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int stop = 30, low = 1, high =29;

            for (int i = 1; i < stop; i++)
            {
                for (int j = 1; j < stop; j++)
                {
                    if (j <= low)
                    {
                        Console.Write("*");
                    }
                    else if (j >= high)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i > stop / 2 - 1)
                {
                    low--;
                    high++;
                }
                else if (i < stop/2)
                {
                    low++;
                    high--;
                }

                Console.WriteLine("");
            }


            Console.ReadLine();
        }
    }
}
