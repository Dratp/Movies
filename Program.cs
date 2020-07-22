using System;
using System.Collections.Generic;
using System.Threading;

namespace Movies
{
    class Movie
    {
        private string _title;
        private string _category;

        public Movie(string name, string type)
        {
            _title = name;
            _category = type;
        }

        public string Title
        {
            get
            {
                return _title;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> mycollection = new List<Movie>();
            mycollection.Add(new Movie("Beauty and the Beast", "animated"));
            mycollection.Add(new Movie("Equilibrum", "sci-fi"));
            mycollection.Add(new Movie("Gattaca", "sci-fi"));
            mycollection.Add(new Movie("Pacific Rim", "sci-fi"));
            mycollection.Add(new Movie("Ruroni Kenshin", "fantasy"));
            mycollection.Add(new Movie("The Movie Hero", "comedy"));
            mycollection.Add(new Movie("The Lion King", "animated"));
            mycollection.Add(new Movie("The Truman Show", "comedy"));
            mycollection.Add(new Movie("The Pirates Who Don't Do Anything: A VeggieTales Movie", "animated"));
            mycollection.Add(new Movie("Astropia", "comedy"));
            mycollection.Add(new Movie("Forbidden Kingdom", "fantasy"));
            mycollection.Add(new Movie("Ender's Game", "sci-fi"));

            string proceed;

            Console.WriteLine("Welcome to the Movie List Application!");
            do
            {
                Console.WriteLine($"\nThere are {mycollection.Count} movies in the list.");
                Console.Write($"What category are you instrested in? ");
                string input = Console.ReadLine().ToLower();
                int count = 0;
                Queue<string> list = new Queue<string>();
                for (int i = 0; i < mycollection.Count; i++)
                {
                    if (input == mycollection[i].Category)
                    {
                        list.Enqueue(mycollection[i].Title);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine($"There are no movies of the category {input}");
                }
                else
                {
                    Console.WriteLine($"{count} movies match that category they are:\n");
                    for (int i = 0; i < count; i++)
                    {
                        string current = list.Dequeue();
                        Console.WriteLine(current);
                    }
                }
                Console.WriteLine();
                proceed = GetYesOrNo("Continue? (y/n): ");
            } while (proceed == "Y");

            Console.WriteLine("Goodbye!");

        }
        static string GetYesOrNo(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y" || answer == "N" || answer == "YES" || answer == "NO")
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("That was not a valid input");
                }
            }

        }    // Takes a question prints it out and returns only a "Y" or a "N" from the user
    }
}
