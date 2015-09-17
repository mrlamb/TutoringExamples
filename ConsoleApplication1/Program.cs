using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var variable1 = 10;
            var variable2 = .10F;
            var variable3 = .0010D;
            var variable4 = 'A';
            var variable5 = "Variable";

            Console.WriteLine("This variable is: {0}", variable1.GetType());
            Console.WriteLine("This variable is: {0}", variable2.GetType());
            Console.WriteLine("This variable is: {0}", variable3.GetType());
            Console.WriteLine("This variable is: {0}", variable4.GetType());
            Console.WriteLine("This variable is: {0}", variable5.GetType());
            Console.ReadLine();
        }
    }
}
