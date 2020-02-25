using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s;
            double a;
            Console.Write("Enter side of the triangle:");
            a = Convert.ToDouble(Console.ReadLine());
            double h;
            Console.Write("Enter the height of the side of the triangle:");
            h = Convert.ToDouble(Console.ReadLine());
            s = 0.5 * a * h;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
    
}
