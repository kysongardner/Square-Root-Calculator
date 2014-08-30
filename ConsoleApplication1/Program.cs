using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to get the square!:");
            double x = Square(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Our Square:{0}",x);
            double y = SqaureRoot(x);
            Console.WriteLine("Our Square Root:{0}",y);
            int b = Isqrt(Convert.ToInt32(x));
            Console.WriteLine("Int Sqaure Root:{0}",b);
        }
        static double Square(double x)
        {
            x *= x;
            return x;
        }
        static double SqaureRoot(double y)
        {
            var Close = y;
            var PointNine = .99;
            var OnePointOOne = 1.001;
            var HowManyTimesToIterate = 0;
            var s = y / 2;
            while (HowManyTimesToIterate <= 100000)
            {
                while (s * s >= y)
                    s *= PointNine;
                while (s * s <= y)
                    s *= OnePointOOne;
                HowManyTimesToIterate++;
                PointNine += (1 - PointNine) * .01;
                OnePointOOne -= (OnePointOOne - 1) * .01;
                //Console.WriteLine(s);
                //Console.WriteLine("\t {0}", PointNine);
                //Console.WriteLine("\t {0}",OnePointOOne);
                if (Close != s)
                    Close = s;
                else
                    break;
            }
            return s;
        }
        public static int Isqrt(int num)
        {
            if (0 == num) { return 0; }  // Avoid zero divide  
            int n = (num / 2) + 1;       // Initial estimate, never low  
            int n1 = (n + (num / n)) / 2;
            while (n1 < n)
            {
                n = n1;
                n1 = (n + (num / n)) / 2;
            } // end while  
            return n;
        }
    }
}
