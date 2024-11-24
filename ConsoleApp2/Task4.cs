using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public class Task4 : ITask
    {
        private int M = 10;

        private void PrintArray(int[] arr)
        {
            foreach (int i in arr)
                Console.Write(i + "\t");
            Console.WriteLine();
        }

        private void FillY(int[] X, int[] Y, int N)
        {
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(X[i]) > M)
                {
                    Y[k] = X[i];
                    k++;
                }
            }
        }

        public void Execute()
        {
            int N = 15;
            Random random = new Random();

            int[] X = new int[N];
            for (int i = 0; i < N; i++)
                X[i] = random.Next() % 201 - 100;

            Console.Write("X: ");
            PrintArray(X);

            int P = 0;
            foreach (int i in X)
            {
                if (Math.Abs(i) > M)
                    P++;
            }

            int[] Y = new int[P];
            FillY(X, Y, N);

            Console.Write("\nY: ");
            PrintArray(Y);
        }
    }
}