using System;

namespace CheckTriangle
{
    public class TriangleCheck
    {
        public bool Check_Triangle(double a, double b, double c)
        {
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
                Console.WriteLine("Such Triangle can't exist");
                return false;
            }
        }
    
    }
}
