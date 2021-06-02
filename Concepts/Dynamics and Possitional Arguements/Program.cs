using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This program is designed help illustrate how dynamics work as well how to use named arguments and positional arguments
/// </summary>
namespace HW9
{
    class Program
    {
        //acting as the executable
        static void Main(string[] args)
        {
            int number1 = 7;
            int number2 = 14;
            int number3 = 7;
            dynamic sum = Add(number1, number2, number3);

            //Calling the Add method and printing
            Console.WriteLine("{0} + {1} + {2} = {3}",number1, number2, number3, sum);

            //Calling Display twice showing the difference of positional and named argument 
            Display("Neytiri","Na'vi", 18);
            Display(course:"Na'vi",name: "Neytiri", age:18);

            //Calling Print with getting the default age
            Display("Neytiri", "Na'vi");
        }

        //Will add all the variable that come in and return the sum
        public static dynamic Add(dynamic input1, dynamic input2, int int1)
        {
            return input1 + input2 + int1;
        }

        //Displays the inputs that are taken in. Checks if age has a number other than defualt
        public static void Display(string name, string course, int age = -1)
        {
           var ageValidate = age ==-1 ? "unknown" : age.ToString();
           System.Console.WriteLine("name= {0}, age = {1}, course = {2}", name, ageValidate, course);
        }
    }
}
