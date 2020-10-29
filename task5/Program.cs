using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] rndarray = new int[10];
            int max = 10;
            int a = 1;
            int b = 10000;
                        
            Console.WriteLine("Random number list");
            
            for (int i = 0; i <= max-1; i++)
            {
                rndarray[i] = rnd.Next(a, b+1);
            }
            Console.WriteLine($"{string.Join(", ", rndarray)}");
            Console.WriteLine();

            ArraySegment<int> partone = new ArraySegment<int>( rndarray, 0, 5 );
            ArraySegment<int> parttwo = new ArraySegment<int>( rndarray, 5, 5 );
            
            Console.WriteLine("Part one\n");
            Console.WriteLine($"{string.Join(", ", partone)}");
            Console.WriteLine("Part two");
            Console.WriteLine($"{string.Join(", ", parttwo)}");

        }

    }
}
