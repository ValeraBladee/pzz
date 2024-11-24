using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public class Task3 : ITask
    {
        private void DisplayNumbers(int[] numbers)
        {
            Console.WriteLine("Generated numbers:");
            foreach (int num in numbers)
                Console.Write($"{num}\t");
            Console.WriteLine();
        }

        private void FindMinMax(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }

            int minValue = numbers[0];
            int maxValue = numbers[0];

            foreach (int num in numbers)
            {
                if (num < minValue) minValue = num;
                if (num > maxValue) maxValue = num;
            }

            Console.WriteLine($"Minimal value: {minValue}");
            Console.WriteLine($"Maximal value: {maxValue}");
        }

        public void Execute()
        {
            int varNum = 5;
            int[] numbers = GenerateRandomNumbers(10 + varNum);

            DisplayNumbers(numbers);
            FindMinMax(numbers);
        }

        private int[] GenerateRandomNumbers(int size)
        {
            Random random = new Random();
            int[] randomNumbers = new int[size];

            for (int i = 0; i < size; i++)
                randomNumbers[i] = random.Next(0, 51);

            return randomNumbers;
        }
    }
}