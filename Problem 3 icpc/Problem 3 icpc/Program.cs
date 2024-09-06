using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_icpc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of digits of ur number:");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("enter ur number value:");

            int x = int.Parse(Console.ReadLine());


            string[] Numbers = new string[n ];

            if ( int.Parse(Numbers[n-1]) > 5)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("BAD");
            }

            Console.ReadKey();

        }
    }
}
