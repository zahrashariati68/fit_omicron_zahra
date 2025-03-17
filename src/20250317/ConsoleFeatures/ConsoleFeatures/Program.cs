using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFeatures
{
    class Program
    {
        static void Main()
        {
            /*
             *Write an application that produces the following outputs:
             *
             *   Name:              <your name>
             *   Place of residence:<your place of residence>
             *   
             *<Here should be your motto>.
             *
             */
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Enter your name:");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter your place of residence:");
            String Residence = Console.ReadLine();
            Console.WriteLine("\n   Name:\t\t"+ Name);
            Console.WriteLine("   Place of residence:\t"+ Residence+"\n");
            Console.WriteLine("Be stronger than your excuses.\n");
            Console.ReadKey();
        }
    }
}
