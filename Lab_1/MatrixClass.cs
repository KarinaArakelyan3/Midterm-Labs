using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class MatrixClass
    {
        private int N { get; set; }
        private int A { get; set; }
        private int B { get; set; }
        private int[,] matrix;

        public MatrixClass(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matrix = new int[N, N];
            FillMatrix();
        }
        private void FillMatrix()
        {
            Random randNum = new Random();
            for (int i = 0; i < N; i++)
            {
                 for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = randNum.Next(A, B + 1);
                }
            }
        }
        public void ShowMatrix()
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.WriteLine("matrix[" + i + "][" + j + "]: " + matrix[i, j]);
                }
            }
        }
        public int QuantityOdd()
        {
            int q = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(matrix[i, j] % 2 != 0)
                    {
                        q++;
                    }
                }
            }
            return q;
        }
    }
}
