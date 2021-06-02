using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This program is designed to illustrate the power of generics and how usefull they can be,
/// while showing how items can be inherited through out programs. If these items have methods 
/// available to them, allowing for items such as the waitlist to be created then manipulated.
/// Also, this program is design the give first exposure to nullable items and how they will 
/// function.
/// </summary>
namespace hw4
{
    class Program
    {
        //Acts as the executable for this program
        static void Main(string[] args)
        {

            //bool returnBool =true;
            Airline waitlist =new Airline();

            //This displays the size fo the waitlist from the Airport Class
            waitlist.DisplayWaitListCapacity();

            //Loading the initial waitlist with names, and stating if successfully added or not
            String[] namesToAddInitially = {"Tim","Sam","Linda","Becky","Trina","Zoe","Edward"};
            foreach(string name in namesToAddInitially)
            {
                waitlist.AddToWaitList(name);
            }
            Console.WriteLine();

            //Displaying the waitlist
            waitlist.DisplayWaitList();
            Console.WriteLine();

            //Removing some names from the waitlist that is now load
            String[] namesToRemove = { "Sammy", "Sam", "Trina"};
            foreach(string name in namesToRemove)
            {
                waitlist.RemoveFromWaitList(name);
            }

            //Redisplaying the waitlist
            Console.WriteLine();
            waitlist.DisplayWaitList();

            //Readding some names to the waitlist
            String[] namesToAdd = {"Zoe","Edward"};
            foreach(string name in namesToAdd)
            {
                waitlist.AddToWaitList(name);
            }

            //Redisplaying the waitlist
            Console.WriteLine();
            waitlist.DisplayWaitList();
            Console.WriteLine();

            //Nullable Int Array, converting nulls to 0. And printed
            int?[] nullable = { 1, null, 3, 4, 5, null, 7};
            foreach(int? number in nullable)
            {
                int? nullNumber = number ?? 0;
                Console.WriteLine(nullNumber);
            }
        }
    }

    //This class is designed to create a general queue used by other classes 
    // in this program, creating methods to interact with the queue.
    class Queue<T>
    {
        private readonly int maxQueueSize;
        private List<T> queue = new List<T>();

        //Set the initial size before an queue is created
        public Queue(int maxSize = 10)
        {
           this.maxQueueSize =maxSize;
        }

        //Adds generic value to the array if they are not already contained in the queue
        public bool Add(T value)
        {
            bool added = true;

            if (queue.Count.Equals(maxQueueSize))
            {
                return !added;
            }
            else
            {
                queue.Add(value);
                return added;
            }
        }

        //Checks the queue to see if it contains a generic value 
        public bool Contains(T value)
        {
            bool found = true;
 

                if (queue.Contains(value))
                {
                return found;
                }
                else
                {
                return !found;
                }
        }

        //Prints out the content of each item in the queue
        public void DisplayQueueEntries()
        {
            foreach (T value in queue)
            {
                Console.WriteLine(value);
            }
        }

        //Getter for the Capacity of the queue
        public int GetMaxQueueSize()
        {
            return maxQueueSize;
        }
        
        //Removes generic items from the queue if they are found
        public bool Remove(T value)
        {
            bool found = Contains(value);

            if (found == true)
            {
                queue.Remove(value);
                return found;
            }
            else
            {
                return !found;
            }
        }
    }

    //Class that will be inheriting the queue methods and manipulating the waitlist
    class Airline

    {
        private readonly Queue<String> waitlist= new Queue<String>(5);

        //Adds a string to the waitlist if the name is not already on the list and tells the console if it has or has not been added
        public bool AddToWaitList(string name)
        {
            bool added = waitlist.Add(name);
            
            if (added == false)
            {
                Console.WriteLine("Waitlist is full " + name + " could not be added.");
                return !added;
            }
            else
            {
                Console.WriteLine("Added: " + name + " to the waitlist");
                return added;
            }
        }

        //Prints to the console the waitlist to the console
        public void DisplayWaitList()
        {
            waitlist.DisplayQueueEntries();
        }
        
        //Prints to the console the Max Size of the waitlist
        public void DisplayWaitListCapacity()
        {
            Console.WriteLine("The max size for the waitlist is: " + waitlist.GetMaxQueueSize());
            Console.WriteLine();
        }

        //Remove strings from the waitlist if it contains the string being searched to remove, then prints to console if its removed
        public bool RemoveFromWaitList(string name)
        {
            bool removed = waitlist.Contains(name);
            if (removed == true)
            {
                waitlist.Remove(name);
                Console.WriteLine("Removed " + name + " from the waitlist");
                return removed;
            }
            else
            {
                Console.WriteLine(name+" is not on the waitlist.");
                return !removed;
            }
        }
    }
}



