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
            int postalCode=0;
            DateTime DOB=DateTime.MinValue;
            bool userInputIsInvalid=true;

            Console.BackgroundColor= ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Write("Please enter your name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            studentName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Please enter your birth day in the following format: DD.MM.YYYY: ");
            while (userInputIsInvalid) {
                Console.ForegroundColor = ConsoleColor.Red;
                userInput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Black;
                try
                {
                    DOB = DateTime.Parse(userInput);   //select line -> Snippet -> Surround with-> try
                    userInputIsInvalid = false;
                }
                catch (Exception ex)
                {
                    userInputIsInvalid = true;
                    Console.WriteLine("The value you entered is not valid");
                    Console.WriteLine("Error: " + ex.Message);
                    Console.Write("Please try again: ");

                }
            }

            userInputIsInvalid = true; 
            Console.Write("\nPlease enter your postal code in number: ");
            while (userInputIsInvalid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                userInput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Black;
                try
                {
                    postalCode = int.Parse(userInput);
                    userInputIsInvalid = false;
                }
                catch (Exception ex)
                {
                    userInputIsInvalid = true;
                    Console.WriteLine("The value you entered is not valid");
                    Console.WriteLine("Error: " + ex.Message);
                    Console.Write("Please try again: ");
                }
            }
            Console.Write("\nPlease enter your city: ");
            Console.ForegroundColor = ConsoleColor.Red;
            studentCity = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("\nHello " + studentName);
            Console.Write("\nStudent's DOB:" + DOB);
            Console.Write("\nStudent's city:" + studentCity);
            Console.Write(" - Postal Code:" + postalCode + "\n\n");
        }
    }
}
