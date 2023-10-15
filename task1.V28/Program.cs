using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.V28
{
    class Program
    {
        private static int result;

        static void Main(string[] args)
        {
            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;

            bool[] results = { true, false, true, false, true, false };

            bool expr1 = (a == 247) && (b == 654);
            bool expr2 = (c != 672) || (d != 671);
            bool expr3 = (a < b) & (c > d);
            bool expr4 = (a > b) | (c < d);
            bool expr5 = (a <= b) ^ (c >= d);
            bool expr6 = (a >= b) || (c <= d);

            for (int i = 0; i < result;)

    foreach (bool result in results)
                    Console.Write(result ? "True" : "False");
            Console.ReadLine();
        }
    }
}
