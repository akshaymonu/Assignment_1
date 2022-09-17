using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Byte.MaxValue);
            Console.WriteLine(Byte.MinValue);
            Console.WriteLine(SByte.MaxValue);
            Console.WriteLine(SByte.MinValue);
            Console.WriteLine(Int16.MaxValue);
            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(UInt16.MaxValue);
            Console.WriteLine(UInt16.MinValue);
            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(UInt32.MaxValue);
            Console.WriteLine(UInt32.MinValue);
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            
        }
    }
}
