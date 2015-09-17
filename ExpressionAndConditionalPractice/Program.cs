using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber1, userNumber2;
            string message = "";

            Console.Write("Enter a number: ");
            userNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\r");
            Console.Write("Enter a second number: ");
            userNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\r");

            //TODO: Check for which number is bigger and update the message
            //      variable to say greater then, less then or equal to

            Console.WriteLine("{0} is {1} {2}", userNumber1, message, userNumber2);
            Console.ReadLine();
        }
    }
}
