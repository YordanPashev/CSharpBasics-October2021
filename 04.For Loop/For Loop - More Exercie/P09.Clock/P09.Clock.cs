using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if (j < 10)
                    {
                        Console.WriteLine($"{i} : {j}");
                    }

                    else
                    {
                        Console.WriteLine($"{i} : {j}");
                    }
                }
            }   
        }
    }
}