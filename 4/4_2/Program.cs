using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            double num = Convert.ToDouble(Console.ReadLine());
            if (3 < num && num < 7 || 8 <= num && num < 9 || 11 < num && num < 22.4)
            {
                Console.WriteLine("belongs");
            }
            else
            {
                Console.WriteLine("no belongs");
            }
            Console.ReadKey();
        }
    }
}
