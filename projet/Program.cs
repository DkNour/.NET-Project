using projet.Models;
using System;
using System.Linq;

namespace projet
{
    class Program
    {
        static void Main(string[] args)
        {
            string MovieLink, Name, About, Category, Director, Producer, Actors, Watchtime, Release, Ratings;
            Console.WriteLine("Get the link:");
            MovieLink = Console.ReadLine();
            Console.WriteLine("The movie name:");
            Name = Console.ReadLine();
            Console.WriteLine("The description:");
            About = Console.ReadLine();
            Console.WriteLine("The Category:");
            Category = Console.ReadLine();
            Console.WriteLine("The Director:");
            Director = Console.ReadLine();
            Console.WriteLine("The Producer:");
            Producer = Console.ReadLine();
            Console.WriteLine("The Actors:");
            Actors = Console.ReadLine();
            Console.WriteLine("The Watchtime:");
            Watchtime = Console.ReadLine();
            Console.WriteLine("The Release:");
            Release = Console.ReadLine();
            Console.WriteLine("The Ratings:");
            Ratings = Console.ReadLine();
            using (var context = new Models.ProjectDBContext())
            {
                MovieDB movie = new MovieDB();
                movie.Name = Name;
                movie.About = About;
                movie.Category = Category;
                movie.Director = Director;
                movie.Actors = Actors;
                movie.Producer = Producer;
                movie.Watchtime = Watchtime;
                movie.Release = Release;
                movie.Ratings = Ratings;
                movie.MovieLink = MovieLink;

                context.MoviesDb.Add(movie);
                context.SaveChanges();

                Console.WriteLine("The name of the movie that you want to modify");
                string modif = Console.ReadLine();
                var MovieModif = context.MoviesDb.Where(s => s.Name == modif).ToList();
                if (MovieModif.Count != 0)
                {
                    var stdMod = MovieModif.First();
                    Console.WriteLine("The new Name");
                    string newName = Console.ReadLine();
                    stdMod.Name = newName;
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Not Found");


                Console.WriteLine("The name of the movie that you want to delete");
                string rmv = Console.ReadLine();
                var MovieRemv = context.MoviesDb.Where(s => s.Name == rmv).ToList();
                if (MovieRemv.Count != 0)
                {
                    var stdRemv = MovieRemv.First();
                    context.MoviesDb.Remove(stdRemv);
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Not Found");
            }
        }
            }
    }
