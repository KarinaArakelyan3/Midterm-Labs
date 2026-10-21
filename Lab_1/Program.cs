using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixClass matrix = new MatrixClass(5, 1, 10);
            matrix.ShowMatrix();
            Console.WriteLine("Quantity of od numbers: " + matrix.QuantityOdd());
        }
    }
}
