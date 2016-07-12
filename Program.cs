using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            Console.Write("> ");
            String user_name = Console.ReadLine();//read from terminal save to a variable
            //input has to be a string above
            Console.WriteLine(user_name);
            //user_name.ToUpper() is turning user's name to uppercase
            //ToUpper() is functionality specific to strings
            //ToUpper() accepts no arguments
            Console.WriteLine(user_name.ToUpper() + " is..GRAND!");
        }
    }
}
