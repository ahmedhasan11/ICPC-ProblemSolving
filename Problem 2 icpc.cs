using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icpc_problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
           int  y = int.Parse(Console.ReadLine());
           int  z = int.Parse(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine("Biggest number : " + x);
            }


            else if (y > x && y > z)
            {
                Console.WriteLine("Biggest Number: " + y);
            }

            else
            {
                Console.WriteLine("Biggest number: " + z);
            }
        }
    }
}
