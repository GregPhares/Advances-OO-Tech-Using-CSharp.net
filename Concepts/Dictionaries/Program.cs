using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This program is designed to illustrate how to use dictionaries and how to use them you
/// have understand how to use the key and values to be able access the data stored in the 
/// dictionary
/// </summary>
namespace HW6
{
    class Program
    {
        //Method acts as the executable for the program, calling all other methods in the program
        static void Main(string[] args)
        {
            string importString = "Hello everyone. How are you doing? I hope you are doing well." +
                " Well, hello.And I said work work work work work.";    
            var createdDictionary = CreateDictionary(GetWords(importString));
            int totalWords = GetWords(importString).Count();
            Console.WriteLine("There are a total of {0} word", totalWords);
            DisplayWordCount(createdDictionary);
        }

        //This method creates a dictionary and checks to see if the key "string" is 
        //already in the dictionary, if so increments it +1 the value "int" 
        public  static Dictionary <string,int> CreateDictionary(string[] words)
        {
            int iteratorNum = 0;
            var myDictionary = new Dictionary<string, int>();

            foreach (string word in words)
            {

                words[iteratorNum] = word;
                if (myDictionary.ContainsKey(word))
                {
                    myDictionary[word] ++;
                }
                else
                {
                    myDictionary[word] = 1;
                }
                iteratorNum++;
            }
            return myDictionary;
        }

        //This method calls sends the values to a List and sorts them, then calls the 
        //value associated with the key
        public static void DisplayWordCount(Dictionary<string,int> dictionary)
        {
            List<string> wordList = new List<string>(dictionary.Keys);
            wordList.Sort();
            
            foreach (var word in wordList) 
            {
                Console.WriteLine("{0}: {1}",word, dictionary[word]);
            }
            
        }

        //This method takes in the string and cuts out any characters that are not part of a word
        //then sets the words into and arraylist.
        public static string[] GetWords(string text)
        {
            
           // string countWords = "";
            char[] separationChars = " .,?".ToCharArray();
            string[] words = text.ToLower().Split(separationChars, StringSplitOptions.RemoveEmptyEntries);
            return words;
            
        }
    }
}
