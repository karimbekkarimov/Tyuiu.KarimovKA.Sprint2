using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 45;
            int y = 127;

            bool[] result = { false, true, false, true, false, true };

            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        result[i] = (x == 45);
                        break;
                    case 1:
                        result[i] = (y != 128);
                        break;
                    case 2:
                        result[i] = (x < y);
                        break;
                    case 3:
                        result[i] = (x > y);
                        break;
                    case 4:
                        result[i] = (x <= y);
                        break;
                    case 5:
                        result[i] = (x >= y);
                        break;
                }
            }
        }
    }
}
