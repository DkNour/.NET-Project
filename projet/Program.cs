using projet.Models;
using System;

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
            }
            }
            }
    }
