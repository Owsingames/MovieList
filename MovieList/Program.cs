using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
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

            if(input == "animated")
            {

                List<Movie> animatedMovies = new List<Movie>();
                animatedMovies = movieList.Where(x => x.Title.ToLower() == "animated").ToList();

                Console.WriteLine(animatedMovies.Count);
                for(int i = 0; i < animatedMovies.Count; i++)
                {
                    Movie userChoice = animatedMovies[i];
                    string movieName = userChoice.Title;
                    Console.WriteLine(movieName);
                }

            }

            
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();
            return input;

            /*
            if(input == "")
            {
                string emptyInput = "Please enter make a selection";
                return GetUserInput(emptyInput);
            }
            else if()
            */
        }
    }
}
