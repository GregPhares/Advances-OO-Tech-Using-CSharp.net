using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This program is designed to illustrate inheritance of classes that normal and abstract. This will show the Is-A relationship 
/// using classes of Animal as the parent or base class, while the lion and dog are the childern classes. This will show how classes
/// can inherit data and well as methods, thus how inherited methods need to either be inherited directly or overriden. 
/// </summary>
namespace HW3
{
    //This class will inicialize objects from the classes and create instances of them and of the methods
    class Program
    {
        static void Main(string[] args)
        {
            Animal doggy = new Dog(2);
            doggy.SpeakIntroduction();
        
            Animal leoTheLion = new Lion(1);
            leoTheLion.SpeakIntroduction();

        }
    }

    //This is the Parent class that will be inherited by the Lion class and the Dog class.
    abstract class Animal
    {
        private int age;
        private int ageMultiplier;

        //Animal Constructor
        public Animal(int age, int ageMultiplier)
        {
            this.age = age;
            this.ageMultiplier = ageMultiplier;
        }
        
        //This method gets the age of the animal and converts it to human years
        public virtual int GetAgeInHumanYears()
        {
            int ageResultant;
            ageResultant = age * ageMultiplier;
            return ageResultant;
        }
          
        //This method prints out the desired messages along with the manditory pretext of each animal's message
        public abstract void Speak(string message);

        //This calls the Speak Method and tells the user the animals age and age in human years
        public virtual void SpeakIntroduction()
        {
            string message = "I am " + age + ". That is " + GetAgeInHumanYears() + " in human years";
            Speak(message);
         } 
    }

    //Child of Animal, this class will be inheritting methods and variables from the parent class.    
    class Dog : Animal
    {
        //Constructor for the Dog Class, inheriting the age from the parent
        public Dog(int age): base(age,7)
        {
        
        }

        //Overrding the parent method from abstrac, to allow it to be more useful for printing
        public override void Speak(string message)
        {
            Console.WriteLine("Dog says woof:" +message);
        }

        //Calls the print method and introduces the Dog by printing its info
        public override void SpeakIntroduction()
        {
            
            base.SpeakIntroduction();
            Speak("I love doggy snacks.");
            Speak("Hello");
            Console.WriteLine();
        }
    }

    //Child of Animal, this class will be inheritting methods and variables from the parent class.  
    class Lion : Animal
    {
        //Constructor for the Lion Class, inheriting the age from the parent
        public Lion(int age) : base(age, 5)
        {
        
        }

        //Overrding the parent method from abstrac, to allow it to be more useful for printing
        public override void Speak(string message)
        {
            Console.WriteLine("Lion says roar:" + message);
        }

        //Calls the print method and introduces the Dog by printing its info
        public override void SpeakIntroduction()
        {
            base.SpeakIntroduction();
            Speak("I love living outside.");
            Speak("Hello");
            Console.WriteLine();
        }

    }

}
