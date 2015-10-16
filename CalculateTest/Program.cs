using ClassFundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var object1 = new MyClass1();

            int myInt = object1.calculate();
            Console.WriteLine(myInt);
            Console.ReadLine();
            object1.X = 5;
            object1.Y = 6;
            Console.WriteLine(object1.calculate());
            Console.ReadLine();

            int a = 219;
            string b = "Chesapeake";
            int c = 63109;

            Address john = new Address(a, b, c);


            Address joyride = new Address(221, "B Baker St", 63109);
            Console.WriteLine("Sherlock Holmes is at {0} {1} {2}, {3} {4}", joyride.Number, joyride.Street,
                joyride.City, joyride.State, joyride.Zip);
            Console.ReadLine();

            MyClass3 haystack = new MyClass3();
            Console.WriteLine("Sherlock Holmes is at {0} {1} {2}, {3} {4}", haystack.cornstalk.Number, haystack.cornstalk.Street,
               haystack.cornstalk.City, haystack.cornstalk.State, haystack.cornstalk.Zip);
            Console.ReadLine();

            Address tim = new Address();
            tim.Number = 2281;
            tim.Street = "Broadway St.";
           
        }
    }
}
