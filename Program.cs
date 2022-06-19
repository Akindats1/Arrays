using System;

namespace FreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int c = 0;
            while (c <= 20)
            {
              if(c % 3 == 0);
              {
                sum += c;
              }
            }
            Console.WriteLine($"The sum of the numbers are:{sum}");
        }
    }
}
