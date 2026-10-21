using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of movies: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Movie[] movies = new Movie[count];

            for(int i = 0; i< count; i++)
            {
                Console.WriteLine("Movie " + (i + 1) + ": ");
                movies[i] = new Movie();
            }

            Console.WriteLine("_____________________________________________________________________________");
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(movies[i].ToString());
            }
        }
    }
}
