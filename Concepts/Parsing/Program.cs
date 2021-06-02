using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///This program is designed to illustrate that parses an array containing strings
///and to parse any strings into integers. And display any errors that occur during
///the parsing process.
///<summary>

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates and loads the Array with strings
            String[] myArray = new String[7] { "1","two","3","4","five","6","7"};

            //Iterates through the array and prints the values of each string
            for (int loopControl = 0; loopControl < 7;loopControl++)
            {
                Console.WriteLine("string: "+ myArray[loopControl]);
            }
            Console.WriteLine();

            //Second iteration of the array while executing MyTryParse for each 
            //string within the array
            for (int loopControl = 0; loopControl<7; loopControl++)
            {
                int returnValue;
                int arrayIndex = loopControl;
                MyTryParse(myArray[arrayIndex],out returnValue);
            }
        }   

        //This method is designed to take in strings and attempt to parse into ints
        private static bool MyTryParse(string testValue, out int goodValue)
        {
            goodValue =0;

            //Creating the try and catch for input values into this method
            try
            {
                goodValue= int.Parse(testValue);
                Console.WriteLine("parsed int = " + goodValue);
                return true;
            }

            catch(ArgumentNullException exception)
            {
                Console.WriteLine("Argument is null. Error: " + exception.Message);
                return false;
            }
            catch(FormatException exception)
            {
                Console.WriteLine("Unable to parse " +testValue+". Error: " +exception.Message);
                return false;
            }
            catch(OverflowException exception)
            {
                Console.WriteLine("Not a proper Int. Error: " + exception.Message);
                return false;
            }
        }
    }
}
