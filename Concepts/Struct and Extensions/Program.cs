using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This program is designed to show how to create structs and use extensions, to teach how they are created and implemented
/// </summary>
namespace HW7
{
    class Program
    {
        //The executable of the program
        static void Main(string[] args)
        {
            int[] yearList = { 1900, 1992, 2000, 2019, 2020 };
            foreach (int year in yearList)
            {
                Console.WriteLine(year.IsLeapYear() ? year + " is a leap year" : year + " is not a leap year");
            }

            Console.WriteLine();
            Currency theCurrency = new Currency(20, 50, 1);
            Console.WriteLine("There is {0} gold, {1} silver, and {2} copper", theCurrency.gold, theCurrency.silver, theCurrency.copper);

            Console.WriteLine();
            int copperCovertion = theCurrency.GetTotalCopper();
            bool copperComparison1 = copperCovertion.HasMoreCopperThan(14000);
            Console.WriteLine("The currency balance of " + (copperComparison1 ? copperCovertion + " is more than 14000" : copperCovertion + " is less than 14000"));

            Console.WriteLine();
            bool copperCompairson2 = copperCovertion.HasMoreCopperThan(17000);
            Console.WriteLine("The currency balance of " + (copperCompairson2 ? copperCovertion + " is more than 17000" : copperCovertion + " is less than 17000"));

            var student = new
            {
                name = "Neytiri",
                grade = "A",
                course = "CS 3020"
            };

            StudentScanner(student);
        }

        //Method that interacts with the student annoymous variable
        public static void StudentScanner(dynamic student)
        {
            Console.WriteLine();
            Console.WriteLine("{0} has an {1} in {2}", student.name, student.grade, student.course);
        }

    }

    //class that creates currency
    struct Currency
    {
        public int copper, silver, gold;

        //public method of the class
        public Currency(int copper,int silver, int gold)
        {
            this.copper = copper;
            this.silver = silver;
            this.gold = gold;
        }
    }

    //This creates a class that is designed to interact with extensions
    static class ExtionMethods
    {

        //method that sorts if the year that comes in is a leap year
        public static bool IsLeapYear(this int year)
        {
            bool leapYear = false;
            if (year % 4 ==0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                       leapYear = true;
                    } 
                }
                else
                {
                    leapYear = true;
                }
            }
                return leapYear;
        }

        //method that takes in all forms for currency and convert to copper
        public static int GetTotalCopper(this Currency currency)
        {
            int totalCopper = currency.copper;
            totalCopper += currency.silver * 100;
            totalCopper += currency.gold * 10000;
            return totalCopper;
         }

        //method that does a compare of the currency total
        public static bool HasMoreCopperThan(this int currentCopper, int newCopper )
        {
            bool moreNativeCopper = false;
            
            if(currentCopper.CompareTo(newCopper) == 1)
            {
                moreNativeCopper = true;
            }
            return moreNativeCopper;
        }
    }

}
