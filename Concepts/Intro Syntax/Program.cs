using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * This program is designed to introduce us into syntax of using C#
 * while using the Pascal Case.
 */
namespace HW1
{
    class Program
    {
        //These are constants that will be used to convert weight
        private const float MoonRelativeGravity = 1.622F;
        private const float EarthRelativeGravity = 9.81F;

        static void Main(string[] args)
        {
            //Introduces the Class via Console Printing
            Console.WriteLine("Hellow from CS3020 001");

            //For-Loop number Printer
            for (int LoopCounter = 0; LoopCounter < 10; LoopCounter++)
            {
                Console.WriteLine(LoopCounter);
            }
                        
            //Reads from the console what the user input for the calculation
            float MyWeight = 128F;
            Console.WriteLine("My weight on the moon is " + (MyWeight / EarthRelativeGravity) * MoonRelativeGravity + " pounds");

        }
    }
}
