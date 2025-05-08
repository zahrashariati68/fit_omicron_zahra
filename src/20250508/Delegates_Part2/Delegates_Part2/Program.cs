using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Part2
{
    public delegate void DoSomething(string message);  //=> Actions

    public delegate bool Check(string message);        //=> Function
    //Predicate -> a delicate with the return type of bool and only one input


    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, int , string> action = WriteColorMessage;
            DoSomething customAction = WriteColorMessage2;

            Func<string, bool> funtion = CheckParameter;
            Check cutomFuntion = CheckParameter;
            
            Predicate<string> preCheck = CheckParameterValue;
             
        }

        private static bool CheckParameterValue(string param)
        {
            throw new NotImplementedException();
        }

        private static bool CheckParameter(string arg)
        {
            return true;
        }

        private static void WriteColorMessage(string arg1, int arg2, string arg3)
        {
            throw new NotImplementedException();
        }

        private static void WriteColorMessage2(string message)
        {
            throw new NotImplementedException();
        }
    }
}
