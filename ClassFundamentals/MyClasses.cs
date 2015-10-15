using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFundamentals
{
    public class MyClass1
    {
        public int x = 1;
        public int y = 2;
    }

    public static class MyClass2
    {
        public static int x = 3;
        public static int y = 4;

        public static int multiply(int x, int y)
        {
            return x * y;
        }
    }
}
