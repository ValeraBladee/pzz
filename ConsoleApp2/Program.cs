using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITask[] tasks = new ITask[]
            {
            new Task1(),
            new Task2(),
            new Task3(),
            new Task4()
            };

            foreach (ITask task in tasks)
            {
                task.Execute();
                Console.WriteLine("-------------");
            }
        }
    }
}
