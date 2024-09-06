using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icpc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Area ;

            Console.WriteLine("enter radius ");

            double R = double.Parse(Console.ReadLine());

            const double pi = 3.14 ;

            Area = R*R*pi;

            Console.WriteLine("Area of Circle = " + Area);


            Console.ReadKey();
        }
    }
}
