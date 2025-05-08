using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            int number;
            int[] numbers;
            numbers = new int[5];  //memory is allocated here

            //initialization 
            number = -1;
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 2;
                Console.WriteLine("value: " + numbers[i]);
            }
        }
    }
}
