using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp_V1
{
    class Program
    {
        /*
         Write an application with which student data can be managed. Following features should be implemented:

        - Console application
        - Clear user guidance through formatting and color coding (e.g.: color inputs)
        - Student data should be able to be entered
        - Participant data should be displayed on the screen
        - All entries should be implemented in an exception free manner

        a) Initial implementation for one student only
            - Name
            - Birthday
            - Address (Postal Code, City)

         */
        static void Main(string[] args)
        {
            string studentName = string.Empty;
            string userInput= string.Empty;
            string studentCity;
            int postalCode;
             
            Console.BackgroundColor= ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Black;
            DateTime DOB;
            Console.Write("Please enter your name: ");
            studentName = Console.ReadLine();
            Console.Write("Please enter your birth day in the following format: DD.MM.YYYY: ");
            userInput = Console.ReadLine();
            try
            {
                DOB = DateTime.Parse(userInput);
            } 
            catch (Exception ex)
            {
                Console.WriteLine("The value you entered is not valid");
                Console.WriteLine("Error: " + ex.Message);
                return;

            }
 
            Console.Write("Please enter your postal code in number: ");
            userInput = Console.ReadLine();
            try
            {
                postalCode = int.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The value you entered is not valid");
                Console.WriteLine("Error: " + ex.Message);
                return;
            }

            Console.Write("Please enter your city: ");
            studentCity = Console.ReadLine();

            Console.Write("\nHello " + studentName);
            Console.Write("\nStudent's DOB:" + DOB);
            Console.Write("\nStudent's city:" + studentCity+ "\n\n"); 
            Console.Write("\nStudent's city:" + studentCity);
            Console.Write("- Postal Code:" + postalCode + "\n\n");
        }
    }
}
