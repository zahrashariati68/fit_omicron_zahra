using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Linq
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> doSomething;
            Func<string,int> doSomething1;
            doSomething = WriteColoredMessage;

            doSomething("Calling an existing method...");

            //Anonymous method: 
            //doSomething?.Invoke("Calling an existing method...."); same as the line above, plus the null check possiblity -> check if doSomething is null, otherwise run Invoke
            doSomething = delegate (string msg)
            {
                Console.WriteLine(msg);
                Console.Beep();
            };
            doSomething.Invoke("hi");
            doSomething("Test");

            doSomething1 = delegate (string msg)
            {
                Console.WriteLine(msg);
                Console.Beep();
                return 10; 
            };
            int returnVal=doSomething1.Invoke("Hello");


            //introduction to Lambda
            doSomething = (string msg) =>    // the point is that using this delegate, we already know and guarantee that the signature of this action is a string. So repeating it can be removed. As followed
            {
                Console.WriteLine(msg);
            };
            // EQUALS TO:
            doSomething = (msg) => Console.WriteLine(msg); // then we can remove the {} because it's just a one liner. 
            //msg is the input parameter, the functionality is the writeLine method
            doSomething("Hello Lambda");


            //example
            var valueList = new List<int> { 5, 8, 10, 2, 15, 20, 29 };
            var filteredValues = FilterToOdd(valueList);

            var evenValues = Filter(valueList, x=> x%2==0); // we send a delegate as the input parameter of the funtion => Lambda expression

            var greaterThan10Values = Filter(valueList, x => x > 10);

            var greaterThan8Values = Filter(valueList, GreaterThan8);

            //LINQ

            valueList.Where(x => x > 5)  //where is a filtering action, 
                .Select(x => 2 * x).Select(x => 2 * x);     // and then perform the desired action on the filtered list. Here we're doubling the values in the list that are greater than 5

        }

        private static bool GreaterThan8(int value)
        {
            if (value > 8)
                return true;
            return false;
        }

        private static IEnumerable<int> Filter(IEnumerable<int> valueList, Predicate<int> filterCondition)
        {
            var resultList = new List<int>();
            foreach (var value in valueList)
            {
                if (filterCondition(value))
                {
                    resultList.Add(value);
                }
            }
            return resultList;
        }

        // To make it more generic =>
        /*private static IEnumerable<int> Filter(IEnumerable<int> valueList, Predicate<int> filterCondition)
        {
            var resultList = new List<int>();
            foreach (var value in valueList)
            {
                if (filterCondition(value))
                {
                    resultList.Add(value);
                }
            }
            return resultList;
        }*/

        private static IEnumerable<int> FilterToOdd(List<int> valueList)    //IEnumerable is the base type of several collection types. used when you want to return the list of some values but without all the complicated features of the list. it's the basic version of a list of values
        {
            var resultList = new List<int>();
            foreach (var value in valueList) { 
                if(value%2 != 0)
                    resultList.Add(value);
            }
            return resultList;
        }

        private static void WriteColoredMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
