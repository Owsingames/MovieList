using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {


                //get user input to select movie category
                //movie categories = animated, drama, horror, scifi
                string message = "Please select a movie genre: Animated, Drama, Horror, Scifi";
                string input = GetUserInput(message);
                //Console.WriteLine(input);


                //list of movies objects
                List<Movie> movieList = new List<Movie>();
                //add new object to movieList
                movieList.Add(new Movie("Men of Honor", "Drama"));
                movieList.Add(new Movie("Gladiator", "Drama"));
                movieList.Add(new Movie("Ip man 2", "Drama"));
                movieList.Add(new Movie("Star Wars: Episode III", "Scifi"));
                movieList.Add(new Movie("Guardians of the Galexy 1", "Scifi"));
                movieList.Add(new Movie("The Martian", "Scifi"));
                movieList.Add(new Movie("Demon Slayer: Mugen Train", "Animated"));
                movieList.Add(new Movie("Howels Moving Castle", "Animated"));
                movieList.Add(new Movie("Spirited Away", "Animated"));
                movieList.Add(new Movie("Nightmare on Elm street", "Horror"));
                movieList.Add(new Movie("IT.", "Horror"));
                movieList.Add(new Movie("The Conjuring", "Horror"));

                if (input == "animated")
                {
                    List<Movie> animatedMovies = new List<Movie>();
                    animatedMovies = movieList.Where(x => x.Category.ToLower() == "animated").ToList();
                    Console.WriteLine("Animated movies: ");

                    for (int i = 0; i < animatedMovies.Count; i++)
                    {
                        Movie userChoice = animatedMovies[i];
                        string movieName = userChoice.Title;
                        Console.WriteLine(movieName);
                    }
                }
                else if (input == "drama")
                {
                    List<Movie> dramaMovies = new List<Movie>();
                    dramaMovies = movieList.Where(x => x.Category.ToLower() == "drama").ToList();
                    Console.WriteLine("Drama based movies: ");

                    for (int i = 0; i < dramaMovies.Count; i++)
                    {
                        Movie userChoice = dramaMovies[i];
                        string movieName = userChoice.Title;
                        Console.WriteLine(movieName);
                    }
                }
                else if (input == "horror")
                {
                    List<Movie> horrorMovies = new List<Movie>();
                    horrorMovies = movieList.Where(x => x.Category.ToLower() == "horror").ToList();
                    Console.WriteLine("Horror based movies: ");

                    for (int i = 0; i < horrorMovies.Count; i++)
                    {
                        Movie userChoice = horrorMovies[i];
                        string movieName = userChoice.Title;
                        Console.WriteLine(movieName);
                    }
                }
                else if (input == "scifi")
                {
                    List<Movie> scifiMovies = new List<Movie>();
                    scifiMovies = movieList.Where(x => x.Category.ToLower() == "scifi").ToList();
                    Console.WriteLine("Scifi based movies: ");

                    for (int i = 0; i < scifiMovies.Count; i++)
                    {
                        Movie userChoice = scifiMovies[i];
                        string movieName = userChoice.Title;
                        Console.WriteLine(movieName);
                    }
                }

                Console.WriteLine();
                again = PickAgain();
            }



        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();

            if(input == "animated" || input == "drama" || input == "horror" || input == "scifi")
            {
                return input;
            }
            else if(input == "")
            {
                Console.Clear();
                string emptyInput = "please make a selection: Animated, Drama, Horror, Scifi";
                return GetUserInput(emptyInput);
            }
            else
            {
                Console.Clear();
                string wrongInput = "I didn't understand, please make a selection: Animated, Drama, Horror, Scifi";
                return GetUserInput(wrongInput);
            }
        }

        public static bool PickAgain()
        {
            Console.WriteLine("Would you like to see more movies? y/n");
            string input = Console.ReadLine().ToLower().Trim();

            if(input == "yes" || input == "y")
            {
                Console.Clear();
                return true;
            }
            else if(input == "no" || input == "n")
            {
                Console.WriteLine("Goodbye");
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I didn't understand...");
                return PickAgain();
            }
        }
    }
}
