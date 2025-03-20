using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCircularCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double diameter = 15.12;
            double circumference = 0.0;
            circumference = diameter * Math.PI;
            Console.WriteLine("the circumference is: "+circumference);
            Console.ReadKey();
        }
    }
}
