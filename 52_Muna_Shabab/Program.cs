
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

//chapter 5-6 52
//written by: Muna Shabab
//date:9-24-2020
namespace _52_Muna_Shabab
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables to hold the  values for the length of each side
            int sideA;
            int sideB;
            int sideC;
            string input;

            //prompt the user for the first number
            Console.WriteLine("please enter a positive integer for the first side:");
            //read the value entered into a string variable
             input=Console.ReadLine();

            //loop through until the value is a positive integer
            while ((!(int.TryParse(input, out sideA)))|| sideA<=0)
            {

                Console.WriteLine( input + " is not a valid  input");
                Console.WriteLine("please enter a positive integer:");
                input = Console.ReadLine();
            }

            //prompt the user for the second number
            Console.WriteLine("please enter a positive integer for the second side:");
            //read the value entered into a string variable
            input = Console.ReadLine();

            //loop through until the value is a positive integer
            while ((!(int.TryParse(input, out sideB)))||sideB<= 0)
            {
                Console.WriteLine(input + " is not a valid  input");
                Console.WriteLine("please enter a positive integer:");
                input = Console.ReadLine();
            }

            //prompt the user for the third number
            Console.WriteLine("please enter a positive integer for the third side:");
            //read the value entered into a string variable
            input = Console.ReadLine();

            //loop through until the value is a positive integer
            while ((!(int.TryParse(input, out sideC))) || sideC <= 0)
            {
                Console.WriteLine(input + " is not a valid  input");
                Console.WriteLine("please enter a positive integer:");
                input = Console.ReadLine();
            }


            //test if the measurements are valid for sides of a triangle
            if (((sideA+sideB)>sideC) && ((sideB + sideC) > sideA) && ((sideA + sideC)> sideB))
            {
                Console.WriteLine(sideA.ToString() + " and " + sideB.ToString() + " and " + sideC.ToString()
                    + " are valid measurements for a triangle");
                  
            }

            //if not 
            else
            {
                Console.WriteLine(sideA.ToString() + " and " + sideB.ToString() + " and " + sideC.ToString()
                                    + " are not valid measurements for a triangle");
            }
            Console.ReadLine();
        }
    }
}
