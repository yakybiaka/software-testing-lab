using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleMeth
{
    class TriangleCheck
    {
        public static bool Check_Triangle(int a, int b, int c)
        {
            if ((a < 0) || (b < 0) || (c < 0))
            {
                Console.WriteLine("Incorrect data was entered");
            }

            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    return false;
                }

                return true;
            }

            else
            {
                Console.WriteLine("This can not be.");
                return false;
            }
        }
    }
}
