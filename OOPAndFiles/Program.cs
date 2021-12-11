using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {

        class Movie //uue klassi loomine
        {
            string title;
            string rating;
            string year;

            // klassi konstruktor
            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

            //getters for Movie (juurdepääsud)
            public string Title
            {
                get { return title; }
            }
            public string Rating
            {
                get { return rating; }
            }
            public string Year
            {
                get { return year; }
            }
        }
    
       static void Main(string[] args)
        {
            // DisplayElementsFromArray(GetDataFromFile());
            //Listi - nimekirja loomine
            List<Movie> myMovies = new List<Movie>();
            string[] moviesFromFile = GetDataFromFile();

            // uue, ajutise massiivi - tempArray loomine kuhu salvestatakse andmed igast reast 1 massiiv 3 elemendiga:
            // tempArray[0] = title;  tempArray[1] = rating; tempArray[2] = year;
            // andmed selleks, et luua Movie objekt
            foreach(string line in moviesFromFile)
            {
                string[] tempArray = line.Split(new Char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                // Console.WriteLine($"title from TempArray: {tempArray[0]}");
                // Console.WriteLine($"rating from TempArray: {tempArray[1]}");
                // Console.WriteLine($"year from TempArray: {tempArray[2]}");
                // Console.WriteLine();
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);
                myMovies.Add(newMovie);
            }

            foreach(Movie movieFromList in myMovies)
            {
                Console.WriteLine($"Title --> {movieFromList.Title}. Rating --> {movieFromList.Rating}.Year --> {movieFromList.Year}.");
            }

        }

        // meetod loeb andmeid massiivist ja kuvab neid, vajab kontrollimiseks
        public static void DisplayElementsFromArray(string[]someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        //funktsiooni loomine, mis loeb andmed failist maha
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Laptop\samples\movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

    }
}
