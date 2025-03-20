using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string userInput = string.Empty;
            int birthYear = 0;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Hello " + name);
            Console.Write(". Please enter your birth year: ");
            userInput = Console.ReadLine();
            try
            {
                birthYear = int.Parse(userInput);
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("Format Exception: " + formatEx.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;

            }
            finally
            {
                Console.WriteLine("Ping");
            }
            int age = DateTime.Now.Year - birthYear;
            Console.WriteLine("Your age is: " + age);
        }
    }
}
