
using System;
using System.Text; 
namespace Assignment_3
{
    class Fruit
    {
        public string FruitName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
    class Ex11_Parameters
    {
        static void mathFunc(double v1, double v2, out double addedValue, out double subValue, out double mulVal, out double divVal, out double sqr, out double sqrt)
        {
            //When U have an out parameter, the function must set a value to it. 
            addedValue = v1 + v2;
            subValue = v1 - v2;
            mulVal = v1 * v2;
            divVal = v1 / v2;
            sqr = v1 * v1;//v2 is ignored.
            sqrt = Math.Sqrt(v1);//v2 is ignored.
        }




        static void Main(string[] args)
        {
            passByValueFunc();

            

        }




        




        private static void passByValueFunc()
        {
            Console.WriteLine("Enter the First value");
            double value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second value");
            double value2 = double.Parse(Console.ReadLine());
            double addedValue, subValue, mulVal, divVal = 0, sqr, sqrt;
            mathFunc(value1, value2, out addedValue, out subValue, out mulVal, out divVal, out sqr, out sqrt);
            Console.WriteLine("The Added value {0}\nThe subtracted value {1}\n The multiplied value {2}\n Divided Value {3}\nThe Square of {4} is {5}\nThe SquareRoot of {4} is {6}", addedValue, subValue, mulVal, divVal, 123, sqr, sqrt);


        }
    }
}