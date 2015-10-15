using System;

namespace UsingMethods
{
    class Program
    {
        private static int userNumber1, userNumber2;
        private static string message = "";
        static void Main(string[] args)
        {            
            
            GetTwoNumbers();
            message = ChangeMessage();
            Console.WriteLine("This message was generated using the ChangeMessage() method that returns a string: {0}", message);

            message = string.Empty;

            ChangeMessage(ref message);
            Console.WriteLine("This message was generated using the ChangeMessage() method that returns nothing: {0}", message);
            Console.ReadLine();
        }
        /// <summary>
        /// Checks to see which userNumber is bigger and returns a string saying greater than,
        /// less than or equal to
        /// </summary>
        /// <returns>string message</returns>
        private static string ChangeMessage()
        {
            message = userNumber1 > userNumber2 ? ">" : "<";
            return message;
        }

        /// <summary>
        /// Checks to see which userNumber is bigger and accepts a paramater of type string to modify to
        /// greater than, less than or equal to
        /// </summary>
        /// <param name="message">string to modify</param>
        private static void ChangeMessage(ref string message)
        {
            message = userNumber1 > userNumber2 ? ">" : "<";
        }

        /// <summary>
        /// Example method. This code could just have easily been in main but here we use a method to illustrate
        /// the concept of code reuse. 
        /// </summary>
        private static void GetTwoNumbers()
        {
            Console.Write("Enter a number: ");
            userNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\r");
            Console.Write("Enter a second number: ");
            userNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\r");
        }
    }
}
