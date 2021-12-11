using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {

        class FrozenSecretSanta
        {
            string name;
            string desire;
            

          
            public FrozenSecretSanta(string _name, string _desire)
            {
                name = _name;
                desire = _desire;
            }

           
            public string Name
            {
                get { return name; }
            }
            public string Desire
            {
                get { return desire; }
            }
            
        }

        static void Main(string[] args)
        {
            
            List<FrozenSecretSanta> myFrozens = new List<FrozenSecretSanta>();
            string[] frozensFromFile = GetDataFromFile();

          
            foreach (string line in frozensFromFile)
            {
                string[] tempArray = line.Split(new Char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                FrozenSecretSanta newFrozenSecretSanta = new FrozenSecretSanta(tempArray[0], tempArray[1]);
                myFrozens.Add(newFrozenSecretSanta);
            }

            foreach (FrozenSecretSanta frozenFromList in myFrozens)
            {
                Console.WriteLine($"{frozenFromList.Name} wants {frozenFromList.Desire}.");
            }

        }

       
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Laptop\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

    }
}
