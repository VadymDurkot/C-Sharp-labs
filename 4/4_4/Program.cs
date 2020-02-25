using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("x=");
            x = Convert.ToInt32(Console.ReadLine());
            if ((Math.Pow(x,2) + Math.Log(x)) > 0)
                Console.WriteLine(Math.Cos(Math.Pow(x, 2) + Math.Log(x)));
            else if((Math.Pow(x, 2) + Math.Log(x)) < 0)
                Console.WriteLine(1 / (Math.Pow(x, 2) + Math.Log(x)));
            else if((Math.Pow(x, 2) + Math.Log(x)) == 0)
                Console.WriteLine(Math.Cos(x));
            else
                Console.WriteLine(0);
            Console.ReadKey();
        }
        
        
    }
}
