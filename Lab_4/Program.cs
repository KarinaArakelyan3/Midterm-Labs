using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void A(in int x)
        {
            Console.WriteLine("My favourite number is "+x);
        }
        static void B(out int x)
        {
            x = 3;
            Console.WriteLine("Unasigned number -> asigned "+x);
        }
        static void C(ref int x)
        {
            x += 5;
            Console.WriteLine("Changed number = "+x);
        }

        static int SumValues(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static int DefaultParameter(int z = 10)
        {
            return z;
        }
        static void Main(string[] args)
        {
            int x = 3;
            A(in x);
            int y;
            B(out y);
            Console.WriteLine("Unchanged number = " + x);
            C(ref x);

            Console.WriteLine("Sum of numbers 3, 4, 7: " + SumValues(3, 4, 7));
            Console.WriteLine("Sum of numbers 3, 4: " + SumValues(3, 4));

            Console.WriteLine("Default: " + DefaultParameter());
            Console.WriteLine("Not default: " + DefaultParameter(3));
        }
    }
}
