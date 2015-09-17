using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Change these variable declarations to be more specific.
            //      Change the variable names as well to be more descriptive.
            var variable1 = 10;
            var variable2 = .10F;
            var variable3 = .0010D;
            var variable4 = 'A';
            var variable5 = "Variable";


            //TODO: Change these console statements to reflect the new variable names you entered above.
            Console.WriteLine("This variable is: {0}", variable1.GetType());
            Console.WriteLine("This variable is: {0}", variable2.GetType());
            Console.WriteLine("This variable is: {0}", variable3.GetType());
            Console.WriteLine("This variable is: {0}", variable4.GetType());
            Console.WriteLine("This variable is: {0}", variable5.GetType());
            Console.ReadLine();
        }
    }
}
