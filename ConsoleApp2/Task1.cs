using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public class Task1 : ITask
    {
        public void Execute()
        {
            const int varNum = 5;
            int arrBorder = 10 + varNum;

            Console.WriteLine("Enter 3 whole numbers:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numbers that suit the interval [1, {arrBorder}]:");

            if (num1 >= 1 && num1 <= arrBorder) Console.WriteLine(num1);
            if (num2 >= 1 && num2 <= arrBorder) Console.WriteLine(num2);
            if (num3 >= 1 && num3 <= arrBorder) Console.WriteLine(num3);
        }
    }
}