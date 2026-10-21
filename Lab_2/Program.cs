using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static int ToMultiplicate(int x, int N = 2)
        {
            int y = 0;
            for(int i =0; i < N; i++)
            {
                y += x;
            }
            return y;
        }

        static double ToMultiplicate(double x, int N = 2)
        {
            double y = 0;
            for (int i = 0; i < N; i++)
            {
                y += x;
            }
            return y;
        }

        static string ToMultiplicate(string x, int N = 2)
        {
            string y = "";
            for (int i = 0; i < N; i++)
            {
                y += x + " ";
            }
            return y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("int -> "+ ToMultiplicate(5, 3));
            Console.WriteLine("int + default -> " + ToMultiplicate(3));
            Console.WriteLine("double -> " + ToMultiplicate(3.3, 3));
            Console.WriteLine("string -> " + ToMultiplicate("Karina", 3));
            Console.WriteLine("string + default -> " + ToMultiplicate("Karina"));
        }
    }
}
