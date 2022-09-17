using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Array_Assignment_2
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
                int[] myTeam = new int[size];
                Console.WriteLine("----------------Data Entry has begun!!!!---------------");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Enter the value");
                    myTeam[i] = int.Parse(Console.ReadLine());
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


