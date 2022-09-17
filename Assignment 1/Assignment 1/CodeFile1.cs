using System;

namespace SampleConApp
{
    class ArraysDemo
    {
        static void Main(string[] args)
        {
            firstDemo();
            
        }

      

        static void firstDemo()
        {
            //datatype [] name = new datatype[size];
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            string[] myTeam = new string[size];
            Console.WriteLine("----------------Data Entry has begun!!!!---------------");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the Name");
                myTeam[i] = Console.ReadLine();
            }
            Console.WriteLine("----------------All the data is entered!!!!---------------");

            Console.WriteLine("-----------------Displaying the values of the Array----------------------");
            foreach (var member in myTeam)
            {
                Console.WriteLine(member);
            }
        }
    }
}

