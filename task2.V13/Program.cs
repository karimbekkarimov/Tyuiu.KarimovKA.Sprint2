using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:"); int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x * x + y * y <= 100)
            {
                Console.WriteLine("Точка с координатами( "+x + ", " + y + ") находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка с координатами(" +x + ", " + y + ") не находится в заштрихованной области.");
            }
            Console.ReadKey();
        }
    }
}
