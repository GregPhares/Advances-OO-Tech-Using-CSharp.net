using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///This program is designed to illustrate the use of getters and setters to be able to get and change values.
///Also, to show recursion and how a method can call itself, till reached the base case.
/// </summary>
namespace hw10
{
    class Program
    {
        //private variable for that can be called 
        private int percent;
       
        //This creates getters and setters for percent
        public int Percent
        {
            get => this.percent;

            set
            {
                if (value < 0)
                {
                   this.percent = 0;
                }
                else if (value > 100)   
                {
                    this.percent = 100;
                }
                else
                {
                    this.percent = value;
                }
            }
        }

        //Main acts as the executable for this homework
        static void Main(string[] args)
        {
            Program program = new Program();
   
            //loops that will get and set the Percent
            for (int value = -1; value <= 101; value++) 
            {
                program.Percent = value;
                Console.WriteLine("{0}%",program.Percent);
            }

            //this creates integers and uses the method that does recursion
            int number = 3;
            int power = 5;
            double product= Program.PowerOf(number,power);
            Console.WriteLine("The product of {0} to the {1}th power is: {2}", number, power, product);
        }

        //This method is recursive, that calls itself
        public static int PowerOf(int number, int power)
        {        
            if (power == 0)
            {
                return 1;
            }
            return number * PowerOf(number, power -1);  
        }
     }
}
