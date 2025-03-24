using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =5;
            if (number > 0 && number < 10)
            {
                Console.WriteLine("Number is out of range");
            }
            if (number < 0 || number > 10)
            {
                Console.WriteLine("Number is out of range");
            }
            if (number == 4)
            {
                Console.WriteLine("Number is 4");
            }
            else
            {
                Console.WriteLine("Number is not 4");
            }
        }
    }
}
